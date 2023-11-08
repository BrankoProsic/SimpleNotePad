using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NotePad1
{
    public class SaveFontColor : IRepository
    {
        public void Save(RichTextBox text, ColorDialog colorDialog)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(text.SelectedText))
                {
                    text.SelectionColor = colorDialog.Color;
                }
                else
                {
                    text.ForeColor = colorDialog.Color;
                }
            }
        }
        
    }
}
