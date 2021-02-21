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
    public partial class chooseMarsh : Form
    {
        DBconnect dBconnect = new DBconnect();
        string numbermarsh;
        string marsh1;
        string marsh2;

        private void button1_Click(object sender, EventArgs e)
        {
            buttons.marsh = marsh1;
            buttons.typeStop = "stops1";
            this.Hide();
            stopsTransport stops = new stopsTransport();
            stops.Show();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttons.typeStop = "stops2";
            buttons.marsh = marsh2;
            this.Hide();
            stopsTransport stops = new stopsTransport();
            stops.Show();
            
        }
        public chooseMarsh()
        {
           

            dBconnect.ConnOpen();
            InitializeComponent();
           
            numbermarsh = buttons.text;
            SqlCommand command = new SqlCommand("SELECT marsh1 FROM avt WHERE numberOFtransport = @marsh", dBconnect.SqlConnection());
            command.Parameters.Add("@marsh", SqlDbType.VarChar).Value = buttons.text;
            SqlDataReader read = command.ExecuteReader();
            read.Read();
            marsh1 = $"{ read["marsh1"]}";
            button1.Text = marsh1;
            read.Close();

            SqlCommand command1 = new SqlCommand("SELECT marsh2 FROM avt WHERE numberOFtransport = @marsh", dBconnect.SqlConnection());
            command1.Parameters.Add("@marsh", SqlDbType.VarChar).Value = buttons.text;
            SqlDataReader read1 = command1.ExecuteReader();
            read1.Read();
            marsh2 = $"{ read1["marsh2"]}";
            button2.Text = marsh2;
            read1.Close();


          
            MessageBox.Show(buttons.marsh);
          
        }
        
       
       

    }
}
