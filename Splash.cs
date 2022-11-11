using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private int ImageNumber = 1;
        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber > 5)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Administrator\source\repos\MyProject\MyProject\Images\" + ImageNumber + ".jpg");
            LoadChecked();
        }

        private void LoadPrevImages()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 5;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Administrator\source\repos\MyProject\MyProject\Images\" + ImageNumber + ".jpg");
            LoadChecked();
        }

        private void LoadChecked()
        {
            switch (ImageNumber)
            {
                case 1:
                    cb1.Checked = true;
                    break;
                case 2:
                    cb2.Checked = true;
                    break;
                case 3:
                    cb3.Checked = true;
                    break;
                case 4:
                    cb4.Checked = true;
                    break;
                case 5:
                    cb5.Checked = true;
                    break;
            }
        }

        private void ChangedCheck()
        {
            timer1.Start();
            if (cb1.Checked == true)
            {
                ImageNumber = 1;
            }
            else if (cb2.Checked == true)
            {
                ImageNumber = 2;
            }
            else if (cb3.Checked == true)
            {
                ImageNumber = 3;
            }
            else if (cb4.Checked == true)
            {
                ImageNumber = 4;
            }
            else if (cb5.Checked == true)
            {
                ImageNumber = 5;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Administrator\source\repos\MyProject\MyProject\Images\" + ImageNumber + ".jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer2.Start();
            cb1.Checked = true;
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Administrator\source\repos\MyProject\MyProject\Images\" + ImageNumber + ".jpg");
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangedCheck();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                this.Hide();
                timer2.Stop();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
