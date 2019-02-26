using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.GUI
{
    class TextBlock : GuiObject
    {
        List<TextLine> _textBlocks = new List<TextLine>();

        public TextBlock (int x, int y, int width, List<string> datalist) : base (x,y,width,datalist.Count)
        {


            for (int i = 0; i < datalist.Count; i++)
            {
                _textBlocks.Add(new TextLine(x, y+i, width, datalist[i]));
            }
        }

        public override void Render()
        {
            foreach (TextLine item in _textBlocks)
            {
                item.Render();
            }

        }
    }
}
