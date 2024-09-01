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
        }

        private void Btn_UpadtePartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_UpadtePartStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
