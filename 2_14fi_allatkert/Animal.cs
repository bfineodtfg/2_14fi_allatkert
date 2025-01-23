using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = true,
                Top = 3,
                Left = 3
            };
            typeLabel = new Label()
            {
                Text = type,
                Top = nameLabel.Bottom,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = true,
                Left = 3
            };
            this.Controls.Add(nameLabel);
            this.Controls.Add(typeLabel);
            this.Width = typeLabel.Width+6;
            this.Height = typeLabel.Bottom+6;
            AnimalPanel = new Panel()
            {
                BackColor = System.Drawing.Color.Gold,
                Width = typeLabel.Width,
                Height = typeLabel.Bottom,
                Top = 3,
                Left = 3
            };
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(AnimalPanel);
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
