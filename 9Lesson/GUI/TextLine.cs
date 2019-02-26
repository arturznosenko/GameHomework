using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.GUI
{
    class TextLine : GuiObject
    {
        private string _data;


        public TextLine (int x, int y, int width,  string data) : base( x,  y,  width,  1 )
        {
             _data = data;
            
        }

        public override void Render ()
        {
            int a = X + ((Width / 2) - (_data.Length / 2));
            //Console.SetCursorPosition(a, Y);
            //Console.WriteLine(_data);


            if (Width > _data.Length)
            {
                Console.SetCursorPosition(a, Y);
                Console.Write(_data);
            }
            else
            {
                Console.SetCursorPosition(X, Y);
                string cutstring = _data.Substring(0, Width);
                Console.Write(cutstring);
            }               


        }


    }
}
