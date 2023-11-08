using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad1
{
    public interface IRepository
    {
        void Save(RichTextBox text, ColorDialog colorDialog);
    }
}
