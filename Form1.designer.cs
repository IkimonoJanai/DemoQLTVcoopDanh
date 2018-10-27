namespace DemoFormLog
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAdd1 = new System.Windows.Forms.Label();
            this.txtSup1 = new System.Windows.Forms.Label();
            this.txtId1 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(0, 264);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(476, 94);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 240);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAdd1);
            this.panel2.Controls.Add(this.txtSup1);
            this.panel2.Controls.Add(this.txtId1);
            this.panel2.Controls.Add(this.txtAdd);
            this.panel2.Controls.Add(this.txtSup);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Location = new System.Drawing.Point(249, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 240);
            this.panel2.TabIndex = 1;
            // 
            // txtAdd1
            // 
            this.txtAdd1.AutoSize = true;
            this.txtAdd1.Location = new System.Drawing.Point(2, 106);
            this.txtAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(30, 13);
            this.txtAdd1.TabIndex = 1;
            this.txtAdd1.Text = "ADD";
            // 
            // txtSup1
            // 
            this.txtSup1.AutoSize = true;
            this.txtSup1.Location = new System.Drawing.Point(3, 70);
            this.txtSup1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSup1.Name = "txtSup1";
            this.txtSup1.Size = new System.Drawing.Size(29, 13);
            this.txtSup1.TabIndex = 1;
            this.txtSup1.Text = "NCC";
            // 
            // txtId1
            // 
            this.txtId1.AutoSize = true;
            this.txtId1.Location = new System.Drawing.Point(12, 43);
            this.txtId1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(18, 13);
            this.txtId1.TabIndex = 1;
            this.txtId1.Text = "ID";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(50, 106);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(72, 20);
            this.txtAdd.TabIndex = 0;
            // 
            // txtSup
            // 
            this.txtSup.Location = new System.Drawing.Point(50, 70);
            this.txtSup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(72, 20);
            this.txtSup.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(50, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 20);
            this.txtId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSCToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eSCToolStripMenuItem
            // 
            this.eSCToolStripMenuItem.Name = "eSCToolStripMenuItem";
            this.eSCToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.eSCToolStripMenuItem.Text = "Dang Nhap";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exitToolStripMenuItem.Text = "Log in";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label txtAdd1;
        private System.Windows.Forms.Label txtSup1;
        private System.Windows.Forms.Label txtId1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;

    }
}

