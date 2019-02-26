using _9Lesson.GUI;
using _9Lesson.MyGameGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.Game
{
    class GameController
    {
        private GameScreen myGameScreen = new GameScreen(49, 20);

        public GameController()

        {

        }


        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }

        public void InitGame()
        {

            int enemycount = 0;
            Random rnd = new Random();



            myGameScreen.SetHero(new Hero(5, 18, "Hero AZ"));
            myGameScreen.ClearEnemyList();

            //  myGameScreen.AddEnemy(new Enemy(100001, 5, 1, "Enemy 1AZ1"));

            for (int i = 0; i < 10; i++)
            {
                myGameScreen.AddEnemy(new Enemy(enemycount, rnd.Next(1, 48), rnd.Next(1, 10), "Enemy" + enemycount));
                enemycount++;
            }
        }



        public void StartGameLoop()
        {

            bool needToRender = true;
            myGameScreen.Render();

            DateTime currenttime = DateTime.Now;//sitas dasidejo
            do
            {

 
                    if (DateTime.Now >= currenttime.AddSeconds(5))
                    {
                        MoveEnemiesDown();
                        Console.Clear();
                        myGameScreen.Render();
                        currenttime = DateTime.Now;
                    }

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                        switch (pressedChar.Key)
                        {
                            case ConsoleKey.Escape:
                                needToRender = false;

                                break;
                            case ConsoleKey.RightArrow:
                                myGameScreen.MoverHeroRight();
                                break;
                            case ConsoleKey.LeftArrow:
                                myGameScreen.MoverHeroLeft();
                                break;

                        }
                        Console.Clear();
                        myGameScreen.Render();
                    }
  
                

              }
            while (needToRender == true);


        }

        public void MoveEnemiesDown()
        {
            myGameScreen.MoveAllEnemiesDown();
        }


    }

}

