using _9Lesson.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.MyGameGUI
{
    class CreditWindow : Window
    {
        Button _backbutton;
        TextBlock _creditTextBlock;

        public CreditWindow(): base(10,2,30,15, '*', "Credit Window")
        {
            List<string> a = new List<String>()
            {
                "Game designer:",
                "Codiding School Design",
                " " ,
                "Programuotojas:",
                "Code School Programuotojas",
                " " ,
                "Art:",
                "Codiding School Art"
            };
            _creditTextBlock = new TextBlock(10, 4, 30, a);
            _backbutton = new Button(21, 13, 8, 3, "Back");



        }

        public override void Render()
        {
            GameWindow test3 = new GameWindow();
            test3.Render();
            base.Render();
            _backbutton.Render();
            _creditTextBlock.Render();
        }
    }
}
