
namespace MyProject
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb5 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 381);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb1.CheckedState.BorderThickness = 0;
            this.cb1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.cb1.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.cb1.Location = new System.Drawing.Point(10, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(18, 17);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "guna2CustomRadioButton1";
            this.cb1.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb1.UncheckedState.BorderThickness = 2;
            this.cb1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cb5);
            this.panel2.Controls.Add(this.cb4);
            this.panel2.Controls.Add(this.cb3);
            this.panel2.Controls.Add(this.cb2);
            this.panel2.Controls.Add(this.cb1);
            this.panel2.Location = new System.Drawing.Point(433, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 24);
            this.panel2.TabIndex = 2;
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb2.CheckedState.BorderThickness = 0;
            this.cb2.CheckedState.FillColor = System.Drawing.Color.Red;
            this.cb2.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.cb2.Location = new System.Drawing.Point(34, 4);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(18, 17);
            this.cb2.TabIndex = 2;
            this.cb2.Text = "guna2CustomRadioButton1";
            this.cb2.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb2.UncheckedState.BorderThickness = 2;
            this.cb2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb3
            // 
            this.cb3.BackColor = System.Drawing.Color.Transparent;
            this.cb3.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb3.CheckedState.BorderThickness = 0;
            this.cb3.CheckedState.FillColor = System.Drawing.Color.Red;
            this.cb3.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.cb3.Location = new System.Drawing.Point(58, 4);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(18, 17);
            this.cb3.TabIndex = 3;
            this.cb3.Text = "guna2CustomRadioButton1";
            this.cb3.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb3.UncheckedState.BorderThickness = 2;
            this.cb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb5
            // 
            this.cb5.BackColor = System.Drawing.Color.Transparent;
            this.cb5.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb5.CheckedState.BorderThickness = 0;
            this.cb5.CheckedState.FillColor = System.Drawing.Color.Red;
            this.cb5.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.cb5.Location = new System.Drawing.Point(106, 4);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(18, 17);
            this.cb5.TabIndex = 5;
            this.cb5.Text = "guna2CustomRadioButton2";
            this.cb5.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb5.UncheckedState.BorderThickness = 2;
            this.cb5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb4
            // 
            this.cb4.BackColor = System.Drawing.Color.Transparent;
            this.cb4.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb4.CheckedState.BorderThickness = 0;
            this.cb4.CheckedState.FillColor = System.Drawing.Color.Red;
            this.cb4.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.cb4.Location = new System.Drawing.Point(82, 4);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(18, 17);
            this.cb4.TabIndex = 4;
            this.cb4.Text = "guna2CustomRadioButton1";
            this.cb4.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb4.UncheckedState.BorderThickness = 2;
            this.cb4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading...";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Firebrick;
            this.progressBar1.Location = new System.Drawing.Point(12, 496);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(976, 32);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(460, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}