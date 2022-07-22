using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rd
{
    public partial class Form1 : Form
    {
        private bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                (sender as Button).BackColor = Color.Red;
            }
            else if (check == true)
            {
                check = false;
                (sender as Button).BackColor = Color.Blue;
            }
        }
    }
}
