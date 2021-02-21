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
    public partial class choosingMarshByOST : Form
    {
        DBconnect dBconnect = new DBconnect();
        public choosingMarshByOST()
        {
            InitializeComponent();
            dBconnect.ConnOpen();
            SqlCommand command = new SqlCommand($"SELECT [{buttons.choosenost}] FROM avtoSTOPS", dBconnect.SqlConnection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add($"{read[buttons.choosenost]}");
            }
            read.Close();
        }

    }
}
