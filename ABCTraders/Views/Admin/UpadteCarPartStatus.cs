using ABCTraders.Controllers;
using ABCTraders.Model;
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
    public partial class UpadteCarPartStatus : Form
    {
        public UpadteCarPartStatus()
        {
            InitializeComponent();
        }

        private void UpadteCarPartStatus_Load(object sender, EventArgs e)
        {
            Drop_UpdatePartOrderStatus.SelectedIndex = 1;   
            Drop_PartOrderStatus.SelectedIndex = 1;
            Tbl_AdminParts.ClearSelection();
            PopulatePartTable();
        }

        private void Btn_UpadtePartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulatePartTable()
        {
            var orderContorller = new OrderController();
            var partList = orderContorller.GetAllCarPartOrdersByStaus(Drop_PartOrderStatus.SelectedIndex);
            Tbl_AdminParts.Rows.Clear();
            foreach (var part in partList)
            {
                Tbl_AdminParts.Rows.Add(new object[]
                {
                    part.Id,
                    part.PartName,
                    part.Price,
                    part.Quantity,
                    part.FristName,
                    part.Email,
                    part.Description,
                });
            }
        }

        private void Btn_UpadtePartStatus_Click(object sender, EventArgs e)
        {

        }

        private void Drop_PartOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePartTable();
        }
    }
}
