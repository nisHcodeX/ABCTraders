using ABCTraders.DbConection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABCTraders.Repository
{
    internal class LoginRepository : DbConnection
    {
        public LoginRepository() {
            try { 
                using(SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception ex) {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
