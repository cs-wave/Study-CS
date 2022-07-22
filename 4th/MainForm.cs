using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Button[] buttons;
        private Label label;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.buttons = new Button[10];

            for (int i = 0; i < 10; i++)
            {
                this.buttons[i] = new Button()
                {
                    Parent = this,
                    Visible = true,
                    Size = new Size(100, 100),
                    Location = new Point(i * 100, 50),
                    Text = i.ToString(),
                };
                this.buttons[i].Click += Clicks;
            }

            this.label = new Label()
            {
                Parent = this,
                Visible = true,
                Location = new Point(0, 0),
                Text = "",
                AutoSize = true,  
            };
        }

        private void Clicks(object sender, EventArgs e)
        {
            for (int i = 0; i < this.buttons.Length; i++)
            {
                if (this.buttons[i] == sender)
                {
                    this.label.Text += i;
                }
            }
        }
    }
}
