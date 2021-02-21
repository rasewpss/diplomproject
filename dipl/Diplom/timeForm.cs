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
    public partial class timeForm : Form
    {
        public timeForm()
        {
            InitializeComponent();
            label1.Text = "Остановка: " + buttons.ostchoosen;
            string type = buttons.type;
            if(type == "bus")
            {
                type = "Автобус №" + $"{buttons.text}";
                label2.Text = type;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
