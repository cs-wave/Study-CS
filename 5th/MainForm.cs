using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5th
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ResizeEnd += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.text_box.Size = this.ClientSize - new Size(24, 15 + this.main_menu.Height);

            Debug.WriteLine("Form resize");
        }

        private void ClickOpen(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "텍스트 파일|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dialog.OpenFile());
                string str = reader.ReadToEnd();
                reader.Close();

                this.text_box.Text = str;
            }

            Debug.WriteLine("Click Open");
        }

        private void ClickSave(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "텍스트 파일|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);
                writer.WriteLine(this.text_box.Text);
                writer.Close();
            }

            Debug.WriteLine("Click Save");
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if ( MessageBox.Show("H", "hi", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
