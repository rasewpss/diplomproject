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
using System.Data;
using System.Data.SqlClient;

namespace Diplom
{
    public partial class ostanovki : Form
    {
        choosingMarshByOST choosingMarsh;
        DBconnect dBconnect = new DBconnect();
        buttons buttons = new buttons(); 
        string ostanovka;
        public ostanovki()
        {
            
            dBconnect.ConnOpen();
            InitializeComponent();
            ostanovka = label1.Text;
            SqlCommand command = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL",dBconnect.SqlConnection());
            SqlDataReader read = command.ExecuteReader();
            while(read.Read())
            {
                listBox1.Items.Add($"{read[$"{ostanovka}"]}");
            }
            read.Close();

            ostanovka = label3.Text;
            SqlCommand command1 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                listBox2.Items.Add($"{read1[$"{ostanovka}"]}");
            }
            read1.Close();

            ostanovka = label4.Text;
            SqlCommand command2 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                listBox3.Items.Add($"{read2[$"{ostanovka}"]}");
            }
            read2.Close();

            ostanovka = label5.Text;
            SqlCommand command3 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                listBox4.Items.Add($"{read3[$"{ostanovka}"]}");
            }
            read3.Close();

            ostanovka = label6.Text;
            SqlCommand command4 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read4 = command4.ExecuteReader();
            while (read4.Read())
            {
                listBox5.Items.Add($"{read4[$"{ostanovka}"]}");
            }
            read4.Close();

            ostanovka = label7.Text;
            SqlCommand command5 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read5 = command5.ExecuteReader();
            while (read5.Read())
            {
                listBox6.Items.Add($"{read5[$"{ostanovka}"]}");
            }
            read5.Close();

            ostanovka = label8.Text;
            SqlCommand command6 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read6 = command6.ExecuteReader();
            while (read6.Read())
            {
                listBox7.Items.Add($"{read6[$"{ostanovka}"]}");
            }
            read6.Close();

            ostanovka = label9.Text;
            SqlCommand command7 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read7 = command7.ExecuteReader();
            while (read7.Read())
            {
                listBox8.Items.Add($"{read7[$"{ostanovka}"]}");
            }
            read7.Close();

            ostanovka = label10.Text;
            SqlCommand command8 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read8 = command8.ExecuteReader();
            while (read8.Read())
            {
                listBox9.Items.Add($"{read8[$"{ostanovka}"]}");
            }
            read8.Close();

            ostanovka = label11.Text;
            SqlCommand command9 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read9 = command9.ExecuteReader();
            while (read9.Read())
            {
                listBox10.Items.Add($"{read9[$"{ostanovka}"]}");
            }
            read9.Close();

            ostanovka = label12.Text;
            SqlCommand command10 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read10 = command10.ExecuteReader();
            while (read10.Read())
            {
                listBox11.Items.Add($"{read10[$"{ostanovka}"]}");
            }
            read10.Close();

            ostanovka = label13.Text;
            SqlCommand command11 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read11 = command11.ExecuteReader();
            while (read11.Read())
            {
                listBox12.Items.Add($"{read11[$"{ostanovka}"]}");
            }
            read11.Close();

            ostanovka = label14.Text;
            SqlCommand command12 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read12 = command12.ExecuteReader();
            while (read12.Read())
            {
                listBox13.Items.Add($"{read12[$"{ostanovka}"]}");
            }
            read12.Close();

            ostanovka = label15.Text;
            SqlCommand command13 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read13 = command13.ExecuteReader();
            while (read13.Read())
            {
                listBox14.Items.Add($"{read13[$"{ostanovka}"]}");
            }
            read13.Close();

            ostanovka = label16.Text;
            SqlCommand command14 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read14 = command14.ExecuteReader();
            while (read14.Read())
            {
                listBox15.Items.Add($"{read14[$"{ostanovka}"]}");
            }
            read14.Close();

            ostanovka = label17.Text;
            SqlCommand command15 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read15 = command15.ExecuteReader();
            while (read15.Read())
            {
                listBox16.Items.Add($"{read15[$"{ostanovka}"]}");
            }
            read15.Close();

            ostanovka = label18.Text;
            SqlCommand command16 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read16 = command16.ExecuteReader();
            while (read16.Read())
            {
                listBox17.Items.Add($"{read16[$"{ostanovka}"]}");
            }
            read16.Close();

            ostanovka = label19.Text;
            SqlCommand command17 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read17 = command17.ExecuteReader();
            while (read17.Read())
            {
                listBox18.Items.Add($"{read17[$"{ostanovka}"]}");
            }
            read17.Close();

            ostanovka = label20.Text;
            SqlCommand command18 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read18 = command18.ExecuteReader();
            while (read18.Read())
            {
                listBox19.Items.Add($"{read18[$"{ostanovka}"]}");
            }
            read18.Close();

            ostanovka = label21.Text;
            SqlCommand command19 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read19 = command19.ExecuteReader();
            while (read19.Read())
            {
                listBox20.Items.Add($"{read19[$"{ostanovka}"]}");
            }
            read19.Close();

            ostanovka = label22.Text;
            SqlCommand command20 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read20 = command20.ExecuteReader();
            while (read20.Read())
            {
                listBox21.Items.Add($"{read20[$"{ostanovka}"]}");
            }
            read20.Close();

            ostanovka = label23.Text;
            SqlCommand command21 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read21 = command21.ExecuteReader();
            while (read21.Read())
            {
                listBox22.Items.Add($"{read21[$"{ostanovka}"]}");
            }
            read21.Close();

            ostanovka = label24.Text;
            SqlCommand command22 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read22 = command22.ExecuteReader();
            while (read22.Read())
            {
                listBox23.Items.Add($"{read22[$"{ostanovka}"]}");
            }
            read22.Close();

            ostanovka = label25.Text;
            SqlCommand command23 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read23 = command23.ExecuteReader();
            while (read23.Read())
            {
                listBox24.Items.Add($"{read23[$"{ostanovka}"]}");
            }
            read23.Close();

            ostanovka = label26.Text;
            SqlCommand command24 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read24 = command24.ExecuteReader();
            while (read24.Read())
            {
                listBox25.Items.Add($"{read24[$"{ostanovka}"]}");
            }
            read24.Close();

            ostanovka = label27.Text;
            SqlCommand command25 = new SqlCommand($"SELECT {ostanovka} FROM stops WHERE {ostanovka} IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read25 = command25.ExecuteReader();
            while (read25.Read())
            {
                listBox26.Items.Add($"{read25[$"{ostanovka}"]}");
            }
            read25.Close();

            ostanovka = label28.Text;
            SqlCommand command26 = new SqlCommand($"SELECT other FROM stops WHERE other IS NOT NULL", dBconnect.SqlConnection());
            SqlDataReader read26 = command26.ExecuteReader();
            while (read26.Read())
            {
                listBox27.Items.Add($"{read26[$"other"]}");
            }
            read26.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox1.SelectedItem.ToString();
            this.Hide();
            choosingMarsh = new choosingMarshByOST();
            choosingMarsh.Show();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox2.SelectedItem.ToString();
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox3.SelectedItem.ToString();
        }

        private void listBox4_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox4.SelectedItem.ToString();
        }

        private void listBox5_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox5.SelectedItem.ToString();
        }

        private void listBox6_DoubleClick(object sender, EventArgs e)
        {
            buttons.choosenost = listBox6.SelectedItem.ToString();
        }

        private void listBox7_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox7.SelectedItem.ToString();
        }

        private void listBox8_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox8.SelectedItem.ToString();
        }

        private void listBox9_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox9.SelectedItem.ToString();
        }

        private void listBox10_DoubleClick_1(object sender, EventArgs e)
        {
                buttons.choosenost = listBox10.SelectedItem.ToString();
        }

        private void listBox11_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox11.SelectedItem.ToString();
        }

        private void listBox12_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox12.SelectedItem.ToString();
        }

        private void listBox13_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox13.SelectedItem.ToString();
        }

        private void listBox14_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox14.SelectedItem.ToString();
        }

        private void listBox15_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox15.SelectedItem.ToString();
        }

        private void listBox16_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox16.SelectedItem.ToString();
        }

        private void listBox17_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox17.SelectedItem.ToString();
        }

        private void listBox18_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox18.SelectedItem.ToString();
        }

        private void listBox19_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox19.SelectedItem.ToString();
        }

        private void listBox20_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox20.SelectedItem.ToString();
        }

        private void listBox21_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox21.SelectedItem.ToString();
        }

        private void listBox22_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox22.SelectedItem.ToString();
        }

        private void listBox23_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox23.SelectedItem.ToString();
        }

        private void listBox24_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox24.SelectedItem.ToString();
        }

        private void listBox25_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox25.SelectedItem.ToString();
        }

        private void listBox26_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox26.SelectedItem.ToString();

        }

        private void listBox27_DoubleClick_1(object sender, EventArgs e)
        {
            buttons.choosenost = listBox27.SelectedItem.ToString();
        }
    }
}
