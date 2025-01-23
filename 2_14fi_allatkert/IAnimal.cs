using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14fi_allatkert
{
    interface IAnimal
    {
        string animalName { get; set; }
        int age { get; set; }
        int weight { get; set; }
        string typeOFanimal { get; set; }
        string foodType { get; set; }
        Label nameLabel { get; set; }
        Label typeLabel { get; set; }
        PictureBox picture { get; set; }
        Panel AnimalPanel { get; set; }
    }
}
