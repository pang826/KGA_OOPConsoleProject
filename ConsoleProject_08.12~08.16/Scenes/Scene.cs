using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16.Players;

namespace ConsoleProject_08._12_08._16.Scenes
{
    
    public abstract class Scene
    {
        public Enums.SceneType SceneType;
        protected Game game;
        protected string inputStr;
        public Player player;
        public Scene(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();

        public abstract void Input();

        public abstract void Update();

        public abstract void Render();

        public abstract void Exit();
    }
}
