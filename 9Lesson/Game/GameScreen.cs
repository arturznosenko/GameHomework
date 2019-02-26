using _9Lesson.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Lesson.Game
{
    class GameScreen
    {
        private int _width;
        private int _height;
        private Hero _hero;
        private List<Enemy> _enemies = new List<Enemy>();
        private Window _newWindow;


        public GameScreen(int width, int height)
        {
            _width = width;
            _height = height;

        }


        public void SetHero(Hero hero)
        {
            _hero = hero;
        }

        public void MoverHeroRight()
        {
            if (_hero.Xparameter() < _width-2)
            {
                _hero.MoveRight();
            }
        }

        public void MoverHeroLeft()
        {
            if (_hero.Xparameter() > 1)
            {
                _hero.MoveLeft();
            }
        }



        public void AddEnemy(Enemy enemy)
        {
           _enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in _enemies)
            {
                enemy.MoveDown();
            }
        }


        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in _enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        public void Render()
        {
            GameWindow();
            
            // _hero.HeroPrintInfo();
            _hero.Render();
            ///  _hero.PrintInfo();   -- cia is UNIT spausdina


            foreach (Enemy enemy in _enemies)
            {
                enemy.Render();
               // enemy.EnemyPrintInfo();
                ///  enemy.PrintInfo();   -- cia is UNIT spausdina
            }

            

        }

        public void ClearEnemyList()
        {
            _enemies.Clear();
        }

        public void GameWindow()
        {
            _newWindow = new Window(0, 0, _width, _height, '*', "Play Game");
            _newWindow.Render();
        }
    }
}
