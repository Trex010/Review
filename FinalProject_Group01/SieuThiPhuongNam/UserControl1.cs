using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiPhuongNam
{
    public partial class UserControl1 : UserControl
    {
        public delegate void UserControl1_Click();
        public event UserControl1_Click click_event;
        public UserControl1():base()
        {
            InitializeComponent();
            this.BackColor = State_DefaultImage;
            tableLayoutPanel1.BackColor = State_DefaultImage;
            pictureBox1.BackColor = State_DefaultImage;
        }
        public void setDefaultColor(Color c)
        {
            State_DefaultImage = c;
            tableLayoutPanel1.BackColor = c;
            pictureBox1.BackColor = c;
        }
        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        public Font Font
        {
            get { return title.Font; }
            set { title.Font = value; }
        }

        public Image BackImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public Color State_DefaultImage
        {
            get;
            set;
        }

        public Color State_HoveringImage
        {
            get;
            set;
        }

        public Color State_PressedImage
        {
            get;
            set;
        }

        #region change color event
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1_MouseDown(sender, e);
        }

        private void title_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1_MouseEnter(sender, e);
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_MouseUp(sender, e);
        }

        private void title_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1_MouseLeave(sender, e);
        }
        #endregion

        #region crappy events
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            click_event();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            click_event();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click_event();
        }

        private void title_Click(object sender, EventArgs e)
        {
            click_event();
        }

        private void title_DoubleClick(object sender, EventArgs e)
        {
            click_event();
        }

        private void title_MouseClick(object sender, MouseEventArgs e)
        {
            click_event();
        }

        private void title_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            click_event();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            click_event();
        }
        #endregion
    }
}
