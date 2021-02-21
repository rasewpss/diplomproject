using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtoForm avtoForm = new avtoForm();
            this.Hide();
            avtoForm.Show();
            string type = "bus";
            buttons.type = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trForm trForm = new trForm();
            this.Hide();
            trForm.Show();
            string type = "tbus";
            buttons.type = type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ostanovki ostanovki = new ostanovki();
            this.Hide();
            ostanovki.Show();
        }
    }
}
