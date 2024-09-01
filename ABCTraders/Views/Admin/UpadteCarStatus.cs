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
        }

        private void Btn_UpadteCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
