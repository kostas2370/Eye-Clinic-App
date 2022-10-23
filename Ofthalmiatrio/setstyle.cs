using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofthalmiatrio
{
    internal class setstyle
    {
        public static void setStyle(Form x)
        {
            x.MaximizeBox = false;
            x.FormBorderStyle = FormBorderStyle.FixedSingle;
            x.StartPosition = FormStartPosition.CenterScreen;
            x.Text = "Οφθαλμιατρείο Διπαέ"; 
           
        }
    }
}
