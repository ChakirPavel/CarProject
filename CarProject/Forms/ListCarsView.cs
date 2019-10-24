using CarProject.CustomControllers;
using CarProject.Forms;
using CarProject.Models;
using CarProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarProject
{
    public partial class ListCarsView : Form
    {
        List<AbstractTransport> listTransport;

        public ListCarsView()
        {
            InitializeComponent();
            FillListView();
        }

        private void FillListView()
        {
            this.listTransport = DataBaseService.GetInstanse().GetAllTransports();
            AbstractTransport.SetDataInGrid(this.GridTransport, this.listTransport);
        }

        private void AddNewCarClick(object sender, EventArgs e)
        {
            OpenDetailView(new Car());
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            GridTransport.Rows.Clear();
            List<AbstractTransport> findedItems;
            if (searchBox.Text != "")
                findedItems = this.listTransport.Where(x => x.CheckExist(searchBox.Text)).ToList();
            else
                findedItems = this.listTransport;
            AbstractTransport.SetDataInGrid(this.GridTransport, findedItems);
        }

        private void GridTransport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && this.listTransport.Count > e.RowIndex)
            {
                OpenDetailView(this.listTransport[e.RowIndex]);
            }
        }

        private void OpenDetailView(AbstractTransport transport)
        {
            var detailForm = new DetailViewCarForm();
            detailForm.SetCorrectTransportType(transport);
            detailForm.Show();
            this.Hide();
        }
    }
}
