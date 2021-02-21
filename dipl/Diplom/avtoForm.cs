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
    
    public partial class avtoForm : Form
    {
        public string choosenavto { get; set; }

        public void chooseavt()
        {
            this.Hide();
            chooseMarsh choose = new chooseMarsh();
            choose.Show();
            
        }
        public avtoForm()
        {
            InitializeComponent();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttons.text = button1.Text;
            chooseavt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttons.text = button2.Text;
            chooseavt();
        }
    }
}
