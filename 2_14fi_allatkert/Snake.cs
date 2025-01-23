using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14fi_allatkert
{
    class Snake : Animal
    {
        public Snake(string name, string type):base(name, type)
        {
            AnimalPanel.BackColor = System.Drawing.Color.Brown;
            
            this.ForeColor = System.Drawing.Color.White;
        }

    }
}
