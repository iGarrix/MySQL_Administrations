namespace Lb3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.бібліотекаріToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бібліотекаріToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.читачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відділиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бібліотекаріToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // бібліотекаріToolStripMenuItem
            // 
            this.бібліотекаріToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бібліотекаріToolStripMenuItem1,
            this.читачіToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.відділиToolStripMenuItem,
            this.посадиToolStripMenuItem});
            this.бібліотекаріToolStripMenuItem.Name = "бібліотекаріToolStripMenuItem";
            this.бібліотекаріToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.бібліотекаріToolStripMenuItem.Text = "Довідники";
            // 
            // бібліотекаріToolStripMenuItem1
            // 
            this.бібліотекаріToolStripMenuItem1.Name = "бібліотекаріToolStripMenuItem1";
            this.бібліотекаріToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.бібліотекаріToolStripMenuItem1.Text = "Бібліотекарі";
            // 
            // читачіToolStripMenuItem
            // 
            this.читачіToolStripMenuItem.Name = "читачіToolStripMenuItem";
            this.читачіToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.читачіToolStripMenuItem.Text = "Читачі";
            this.читачіToolStripMenuItem.Click += new System.EventHandler(this.читачіToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // відділиToolStripMenuItem
            // 
            this.відділиToolStripMenuItem.Name = "відділиToolStripMenuItem";
            this.відділиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відділиToolStripMenuItem.Text = "Відділи";
            // 
            // посадиToolStripMenuItem
            // 
            this.посадиToolStripMenuItem.Name = "посадиToolStripMenuItem";
            this.посадиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.посадиToolStripMenuItem.Text = "Посади";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem бібліотекаріToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бібліотекаріToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem читачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відділиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посадиToolStripMenuItem;
    }
}

