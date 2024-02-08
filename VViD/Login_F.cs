using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;



namespace VViD
{
    public partial class Login_F : Form
    {
        public Login_F()
        {
            InitializeComponent();
        }
        static string conn = ConfigurationManager.ConnectionStrings["VViD.Properties.Settings.KP_Tagmet_ConStr"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            conn=conn + "; User ID =" + TB_L.Text + " ; Password=" + TB_P.Text + ";";
            SqlConnection Serv_Con  = new SqlConnection(conn);
            string query = "SELECT SYSTEM_USER";
           
            SqlCommand Com = new SqlCommand(query, Serv_Con);
            DataTable dt = new DataTable();
            
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = Com;
                
                try {
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Подключение успешно");
                        this.Hide();
                        var F = new F_task();
                        F.Show();
                    }
                  
                }
                catch { MessageBox.Show("Введены не верные данные для авторизации"); }
            }
            
            
           
                
        }
    }
}
