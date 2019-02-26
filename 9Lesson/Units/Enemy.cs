using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.Game
{
    class Enemy : Unit
    {
        private int _id;
 

        public Enemy (int id, int x, int y, string name) : base (x, y, name)
        {
            _id = id;
     
        }

        public void MoveDown()
        {
            if (Y>0)
            Y++;
            
        }

        public void EnemyPrintInfo()
        {
            Console.Write("Enemy: " + _id + " ");
            PrintInfo();
        }

        public int GetId()
        {
            return _id;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(GetId());
        }
    }
}
