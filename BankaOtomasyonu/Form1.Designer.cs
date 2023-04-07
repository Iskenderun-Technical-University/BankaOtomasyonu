namespace BankaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleName = "";
            panel1.Cursor = Cursors.IBeam;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 370);
            panel1.TabIndex = 0;
            panel1.Tag = "";
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Banka Otomasyonu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}