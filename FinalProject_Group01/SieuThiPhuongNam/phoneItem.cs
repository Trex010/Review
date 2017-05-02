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
    public partial class phoneItem : UserControl
    {
        public phoneItem()
        {
            InitializeComponent();
            textBox.Visible = false;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            label.ForeColor = Color.Red;

            pictureBox.Image = Properties.Resources.smartphone;
           
        }
        public phoneItem(Image img, string textDescription, string textTitle)
        {
            InitializeComponent();
            pictureBox.Image = img;
            textBox.Text = textDescription;
            label.Text = textTitle;

            if (enableDescription)
                textBox.Visible = false;
        }

        public string TextDescription
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public string TextTitle
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public Image BackImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public bool enableDescription { get; set; }

        public Font textDescriptionFont
        {
            get { return textBox.Font; }
            set { textBox.Font = value; }
        }

        public Font textTitleFont
        {
            get { return label.Font; }
            set { label.Font = value; }
        }

        private void item_MouseLeave(object sender, EventArgs e)
        {
            if (enableDescription)
                textBox.Visible = false;
        }

        private void item_MouseUp(object sender, MouseEventArgs e)
        {
            if (enableDescription)
                textBox.Visible = false;
        }

        private void item_MouseEnter(object sender, EventArgs e)
        {
            if (enableDescription)
                textBox.Visible = true;
        }

        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            if (enableDescription)
                textBox.Visible = true;
        }

    }
}
