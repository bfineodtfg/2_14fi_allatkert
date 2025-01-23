using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14fi_allatkert
{
    public partial class Form1 : Form
    {
        public static PictureBox veryBigPicture;
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            veryBigPicture = new PictureBox()
            {
                Width = (int)(this.Width * 0.8),
                Height = (int)(this.Height * 0.8),
                Left = (int)(this.Width * 0.1),
                Top = (int)(this.Height * 0.1),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(veryBigPicture);
            veryBigPicture.Hide();
            Snake oneSnake = new Snake("Boa", "óriásssskígyó");
            this.Controls.Add(oneSnake);
            veryBigPicture.Click += ClickBigPicture;
        }
        void ClickBigPicture(Object s, EventArgs e)
        {
            veryBigPicture.Hide();
        }
    }
}
