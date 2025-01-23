using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _2_14fi_allatkert
{
    internal class Animal : UserControl, IAnimal
    {
        public Animal(string name, string type)
        {
            animalName = name;
            typeOFanimal = type;
            nameLabel = new Label()
            {
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Top = 3,
                Left = 3
            };
            typeLabel = new Label()
            {
                Text = type,
                Top = nameLabel.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                BackColor = Color.Gray,
                Left = 3
            };

            AnimalPanel = new Panel()
            {
                BackColor = Color.Gold,
                Top = 3,
                Left = 3
            };
            this.BackColor = Color.Black;
            this.Controls.Add(AnimalPanel);
            AnimalPanel.Controls.Add(nameLabel);
            AnimalPanel.Controls.Add(typeLabel);
            picture = new PictureBox()
            {
                Left = 3,
                Top = typeLabel.Bottom + 3,
                Width = typeLabel.Width,
                Height = (int)((double)typeLabel.Width / 16 * 9)
                //width:9  => 9 / 16 * 9
                //egész osztás => (9/16) = 1      1 * 9 = 9
                //valós osztás => 0,5625 * 9 = 5,0625 => 5
            };
            AnimalPanel.Controls.Add(picture);

            AnimalPanel.Width = typeLabel.Width + 6;
            AnimalPanel.Height = picture.Bottom + 9;
            this.Width = typeLabel.Width + 12;
            this.Height = picture.Bottom + 15;
            picture.Click += ClickPicture;
        }
        public void ClickPicture(Object s, EventArgs e)
        {
            Form1.veryBigPicture.Image = picture.Image;
            Form1.veryBigPicture.Show();
        }
        public Label nameLabel { get; set; }
        public Label typeLabel { get; set; }
        public string animalName { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string typeOFanimal { get; set; }
        public string foodType { get; set; }
        public PictureBox picture { get; set; }
        public Panel AnimalPanel { get; set; }
    }
}
