namespace _5th
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_box = new System.Windows.Forms.RichTextBox();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.open_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.save_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_box
            // 
            this.text_box.Location = new System.Drawing.Point(12, 27);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(278, 331);
            this.text_box.TabIndex = 0;
            this.text_box.Text = "";
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_strip,
            this.save_strip});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(302, 24);
            this.main_menu.TabIndex = 1;
            this.main_menu.Text = "menuStrip1";
            // 
            // open_strip
            // 
            this.open_strip.Name = "open_strip";
            this.open_strip.Size = new System.Drawing.Size(48, 20);
            this.open_strip.Text = "Open";
            this.open_strip.Click += new System.EventHandler(this.ClickOpen);
            // 
            // save_strip
            // 
            this.save_strip.Name = "save_strip";
            this.save_strip.Size = new System.Drawing.Size(44, 20);
            this.save_strip.Text = "Save";
            this.save_strip.Click += new System.EventHandler(this.ClickSave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 370);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.main_menu);
            this.MainMenuStrip = this.main_menu;
            this.Name = "MainForm";
            this.Text = "Memo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_box;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem open_strip;
        private System.Windows.Forms.ToolStripMenuItem save_strip;
    }
}

