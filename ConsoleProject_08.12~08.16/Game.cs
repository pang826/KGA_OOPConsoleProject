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

        public Game()
        {
            scenes = new Scene[(int)Enums.SceneType.size];
            scenes[(int)Enums.SceneType.StartScene] = new StartScene();
            scenes[(int)Enums.SceneType.Choice] = new Choice();
            scenes[(int)Enums.SceneType.Village] = new Village();
            scenes[(int)Enums.SceneType.Reinforce] = new Reingforce();
            scenes[(int)Enums.SceneType.SkillState] = new SkillState();
            scenes[(int)Enums.SceneType.HuntingGround] = new HuntingGround();
            scenes[(int)Enums.SceneType.Store] = new Store();
            scenes[(int)Enums.SceneType.Hospital] = new Hospital();
        }

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Input();
                Render();
                Update();
            }
            End();
        }
        public void Start()
        {
            this.isRunning = true;

            curscene = scenes[(int)Enums.SceneType.StartScene];
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

        public void Update()
        { 
            curscene.Update();
        }
    }
}
