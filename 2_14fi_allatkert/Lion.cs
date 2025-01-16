using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14fi_allatkert
{
    class Lion: UserControl, IAnimal
    {
        public Lion(string name, string type) {
            animalName = name;
            typeOFanimal = type;
            nameLabel = new Label() { Text = name };
            typeLabel = new Label() { Text = type };
        }
        public Label nameLabel { get; set; }
        public Label typeLabel { get; set; }
        public string animalName { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string typeOFanimal { get; set; }
        public string foodType { get; set; }
    }
}
