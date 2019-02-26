using _9Lesson.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.MyGameGUI
{
    class GameWindow : Window
    {
        private Button _startButton;
        private Button _creditButton;
        private Button _quitButton;
        private List<Button> _buttons =  new List<Button>(); //kam reikalingas?
        private TextBlock _text;

        public GameWindow() : base(0,0,49,20,'*', "Game menu")
        {
            List<string> textGameWindow = new List<string>() {"Super Zaidimas" , "AZ kuryba" , "Made in Vilnius coding school!"};
            _text = new TextBlock(0, 4, 50, textGameWindow);  

            _startButton = new Button(3, 11, 10, 5, "Start");
            _creditButton = new Button(3+13+3, 11, 10, 5, "Credit");
            _quitButton = new Button(3+13+3+13+3, 11, 10, 5, "Quit");

            _buttons.Add(_startButton); //kam reikalingas?
            _buttons.Add(_creditButton); //kam reikalingas?
            _buttons.Add(_quitButton); //kam reikalingas?

        }

        public override void Render()
        {
            base.Render();
            _text.Render();
            _startButton.Render();
            _creditButton.Render();
            _quitButton.Render();
        }

        public void activeStartbutton()
        {
            _startButton.SetActive();
            _creditButton.SetToInActive();
            _quitButton.SetToInActive();
            Render();
        }

        public void activeCreditbutton()
        {
            _startButton.SetToInActive(); 
            _creditButton.SetActive();
            _quitButton.SetToInActive();
            Render();
        }

        public void activeQuittbutton()
        {
            _startButton.SetToInActive();
            _creditButton.SetToInActive();
            _quitButton.SetActive();
            Render();
        }


    }
}
