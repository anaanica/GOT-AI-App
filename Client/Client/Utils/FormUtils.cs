using Client.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Utils
{
    public class FormUtils
    {
        public static bool FormValid(IEnumerable<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
