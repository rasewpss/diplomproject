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
    public partial class stopsTransport : Form
    
    {
        DBconnect dBconnect = new DBconnect();
        public stopsTransport()
        {
            InitializeComponent();
            dBconnect.ConnOpen();
            SqlCommand command = new SqlCommand($"SELECT [{buttons.typeStop}] FROM avt WHERE typeOftransport = @type AND numberOFtransport = @numbers", dBconnect.SqlConnection());
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = buttons.type;
            command.Parameters.Add("@numbers", SqlDbType.VarChar).Value = buttons.text;
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add($"{read[buttons.typeStop]}");
            }
            read.Close();
            label2.Text = buttons.text;
            if (buttons.type == "bus")
            {
                label1.Text = "Автобус №";
            }
            else
            {
                label1.Text = "Троллейбус №";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttons.ostchoosen = listBox1.SelectedItem.ToString();
            this.Hide();
            timeForm time = new timeForm();
            time.Show();
        }
    }
}
