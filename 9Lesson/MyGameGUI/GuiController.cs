using _9Lesson.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.MyGameGUI
{
    class GuiController
    {
        private GameWindow _newGameWindow;
        private CreditWindow _newCreditWindow;
        private GameController _newGameController;
        private int ActiveKey = 1;
        private bool quit = false;

        public GuiController()
        {

            GameWindow NewGameWindow = new GameWindow();
            _newGameWindow = NewGameWindow;

            CreditWindow NewCreditWindow = new CreditWindow();
            _newCreditWindow = NewCreditWindow;

            GameController NewGameController = new GameController();
            _newGameController = NewGameController;

        }

        public void showMenu()
        {

                _newGameWindow.Render();
                _newGameWindow.activeStartbutton();
                buttonfunctionality();
            
        }

        public void buttonfunctionality()

        {
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                    switch (pressedChar.Key)
                    {

                        case ConsoleKey.RightArrow:
                            if (ActiveKey < 3)
                            {
                                ActiveKey = ActiveKey + 1;
                                whichKeyisActive();
                            }
                            break;

                        case ConsoleKey.LeftArrow:
                            if (ActiveKey != 1)
                            {
                                ActiveKey = ActiveKey - 1;
                                whichKeyisActive();
                            }
                            break;

                        case ConsoleKey.Enter:
                            pressEnter();
                            break;

                        case ConsoleKey.Escape:
                            PressEscape();
                            break;

                    }
                }
            } while (quit == false);
        }

        public void whichKeyisActive()
        {
            if (ActiveKey == 1)
            {
                _newGameWindow.Render();
                _newGameWindow.activeStartbutton();
            }
            else if (ActiveKey == 2)
            {
                _newGameWindow.Render();
                _newGameWindow.activeCreditbutton();
            }
            else if (ActiveKey == 3)
            {
                _newGameWindow.Render();
                _newGameWindow.activeQuittbutton();
            }
        }

        public void pressEnter ()
        {
            if (ActiveKey == 1)
            {
                _newGameController.StartGame();
                Console.Clear();
                showMenu();
            }
            else if (ActiveKey == 2)
            {
                _newCreditWindow.Render();
                ActiveKey = 4;
            }
            else if (ActiveKey == 3)
            {
                quit = true;
            }
            else if (ActiveKey == 4)
            {
                _newGameWindow.Render();
                ActiveKey = 2;
            }
        }

        public void PressEscape()
        {
            if (ActiveKey == 4)
            {
                _newGameWindow.Render();
                ActiveKey = 2;
            }
            else
            {
                quit = true;
            }
        }


    }
}
