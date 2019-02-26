using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.Game
{
    class Hero : Unit
    {

        public Hero(int x, int y, string name) : base (x, y, name)
        {
      
        }

        public void MoveRight()
        {
            X++;

        }

        public void MoveLeft()
        {
            X--;
        }

        public void HeroPrintInfo()
        {
            Console.Write("Hero: ");
            PrintInfo();
        }

        public void Render ()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("H");
        }

    }
}
