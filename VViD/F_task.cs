using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VViD
{
    public partial class F_task : Form
    {
        public F_task()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_TagmetDataSet.v_Tasks". При необходимости она может быть перемещена или удалена.
            this.v_TasksTableAdapter.Fill(this.kP_TagmetDataSet1.v_Tasks);

        }
    }
}
