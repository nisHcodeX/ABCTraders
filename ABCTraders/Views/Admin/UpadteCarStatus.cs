using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTraders.Views.Admin
{
    public partial class UpadteCarStatus : Form
    {
        public UpadteCarStatus()
        {
            InitializeComponent();
        }

        private void UpadteCarStatus_Load(object sender, EventArgs e)
        {
            Drop_CarOrderStatus.SelectedIndex = 1;
            Drop_UpdatePartOrderStatus.SelectedIndex = 1;
            PopulateCarTable();

        }

        private void Btn_UpadteCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCarTable()
        {
            var orderContorller = new OrderController();
            var carList = orderContorller.GetAllCarOrdersByStatus(Drop_CarOrderStatus.SelectedIndex);
            Tbl_CarAdmin.Rows.Clear();
            foreach (var car in carList)
            {
                Tbl_CarAdmin.Rows.Add(new object[]
                {
                    car.Id,
                    car.ModelName,
                    car.ManufacturerName,
                    car.Price,
                    car.FristName,
                    car.Email
                });
            }
        }

        private void Drop_CarOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarTable();
        }
    }
}
