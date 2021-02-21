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
    public partial class trForm : Form
    {
        public trForm()
        {
            InitializeComponent();
        }

        public void chooseavt()
        {
            this.Hide();
            chooseMarsh choose = new chooseMarsh();
            choose.Show();

        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = buttons.text;
            chooseavt();
        }
    }
}
