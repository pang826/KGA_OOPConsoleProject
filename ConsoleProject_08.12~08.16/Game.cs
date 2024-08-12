using ConsoleProject_08._12_08._16.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16
{
    internal class Game
    {
        private bool isRunning;

        public Scene curscene;
        public Scene[] scenes;

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Input();
                Render();
                curscene.Update();
            }
            End();
        }
        public void Start()
        {
            this.isRunning = true;
        }

        public void End()
        { 
            this.isRunning = false;
        }

        public void Input()
        {
            curscene.Input();
        }
        public void Render()
        {
            curscene.Render();
        }
    }
}
