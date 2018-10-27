namespace DemoQuanLyThuVien.fOrigin
{
    partial class FormAdminInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.drawCircle1 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(177, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // drawCircle1
            // 
            this.drawCircle1.BackColor = System.Drawing.Color.Red;
            this.drawCircle1.Location = new System.Drawing.Point(290, 49);
            this.drawCircle1.Name = "drawCircle1";
            this.drawCircle1.Size = new System.Drawing.Size(179, 149);
            this.drawCircle1.TabIndex = 7;
            this.drawCircle1.Text = "drawCircle1";
            this.drawCircle1.UseVisualStyleBackColor = false;
            // 
            // FormAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 456);
            this.Name = "FormAdminInfo";
            this.Text = "FormAdminInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DrawHinhThoi drawCircle1;
    }
}