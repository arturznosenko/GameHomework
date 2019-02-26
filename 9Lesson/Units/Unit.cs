using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.Game
{
    class Unit
    {
        public int X;
        protected int Y;
        protected string _name;

        public Unit (int x, int y, string name)
        {
            X = x;
            Y = y;
            _name = name;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"{_name} is on: {Y} and {X} ");
        }

        public int Xparameter()
        {
            return X;
        }

    }
}
