
using CarProject.CustomControllers;
using CarProject.Models;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarProject
{
    public abstract class AbstractTransport
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [TitleField("Mark")]
        public string Mark { get; set; }
        [TitleField("Model")]
        public string Model { get; set; }
        [TitleField("Year")]
        public int Year { get; set; }
        [TitleField("Color")]
        public string Color { get; set; }
        private int IntTransportType { get; set; }
        [Ignore]
        public TransportType TypeTransport { get { return (TransportType)IntTransportType; } set { IntTransportType = (int)value; } }
        [TitleField("Price")]
        public float Price { get; set; }

        public virtual void SaveItem() { }
        public virtual void RemoveItem() { }

        public bool CheckExist(string searchText)
        {
            var allData = (ID + Mark + Model + Year + Color + Price + TypeTransport).ToLower();
            return allData.Contains(searchText.ToLower());
        }

        public List<Field> GetCntlFieldsForDetail()
        {
            var prop = this.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(TitleField), true).Any()).ToList();
            var customControllers = new List<Field>();
            for (var i = 0; i < prop.Count(); i++)
            {
                var field = new Field(prop[i]);
                field.textBoxProperty.Text = prop[i].GetValue(this)?.ToString();
                customControllers.Add(field);
            }

            return customControllers;
        }

        public string SetDataFromProps(List<Field> fields)
        {
            var allProp = this.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(TitleField), true).Any()).ToList();

            foreach (var field in fields)
            {
                try
                {
                    var prop = this.GetType().GetProperty(field.NameOfProperty);
                    prop.SetValue(this, Convert.ChangeType(field.textBoxProperty.Text, prop.PropertyType));
                }
                catch(Exception ex)
                {
                    return "Field " + field.Title + " not correct. Please input correct data.";
                }
            }
            return "OK";
        }

        public static void SetDataInGrid(DataGridView dataGrid, List<AbstractTransport> listTransport)
        {
            for (var i = 0; i < listTransport.Count; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = listTransport[i].ID;
                dataGrid.Rows[i].Cells[1].Value = listTransport[i].Mark;
                dataGrid.Rows[i].Cells[2].Value = listTransport[i].Model;
                dataGrid.Rows[i].Cells[3].Value = listTransport[i].Year;
                dataGrid.Rows[i].Cells[4].Value = listTransport[i].Color;
                dataGrid.Rows[i].Cells[5].Value = listTransport[i].TypeTransport;
                dataGrid.Rows[i].Cells[6].Value = listTransport[i].Price;
            }
        }

    }
}
