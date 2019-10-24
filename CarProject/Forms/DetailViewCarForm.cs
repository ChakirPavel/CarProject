using CarProject.CustomControllers;
using CarProject.Models;
using CarProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject.Forms
{
    public partial class DetailViewCarForm : Form
    {
        private List<Field> customControllersFields;
        public AbstractTransport transport;

        public DetailViewCarForm()
        {
            InitializeComponent();
        }

        public void SetCorrectTransportType(AbstractTransport transport)
        {
            switch(transport.TypeTransport)
            {
                case (TransportType.Car):
                    this.transport = transport as Car;
                    break;
            }
            deleteBtn.Visible = (this.transport.ID == 0) ? false : true;
        }

        private void DetailViewCarForm_Load(object sender, EventArgs e)
        {
            customControllersFields = transport.GetCntlFieldsForDetail();
            tableViewCollection.Controls.AddRange(customControllersFields.ToArray());
        }
        private void CompleteClick(object sender, EventArgs e)
        {
            var message = this.transport.SetDataFromProps(customControllersFields);
            if (message != "OK")
            {
                MessageBox.Show(message, "Error Detected in Input",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                transport.SaveItem();
                OpenListViewCars();
            }
        }

        private void OpenListViewCars()
        {
            ListCarsView listForm = new ListCarsView();
            listForm.Show();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            OpenListViewCars();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            transport.RemoveItem();
            OpenListViewCars();
        }
    }
}
