using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class poik : Form
    {
        public poik()
        {
            InitializeComponent();
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToString();
            SqlCommand command = new SqlCommand("SELECT parametr WHERE parametr_poiska = @search");
            command.Parameters.Add("@search", SqlDbType.VarChar).Value = search;
            //здесь уже просто внесение полученных результатов в таблицу
           
        }
    }
}
