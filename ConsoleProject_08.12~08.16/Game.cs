using ConsoleProject_08._12_08._16.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16
{
    public class Game
    {
        private bool isRunning;

        public Scene curscene;
        public Scene[] scenes;

        public Game()
        {
            scenes = new Scene[(int)Enums.SceneType.size];
            scenes[(int)Enums.SceneType.StartScene] = new StartScene(this);
            scenes[(int)Enums.SceneType.Choice] = new Choice(this);
            scenes[(int)Enums.SceneType.Village] = new Village(this);
            scenes[(int)Enums.SceneType.Reinforce] = new Reingforce(this);
            scenes[(int)Enums.SceneType.SkillState] = new SkillState(this);
            scenes[(int)Enums.SceneType.HuntingGround] = new HuntingGround(this);
            scenes[(int)Enums.SceneType.Store] = new Store(this);
            scenes[(int)Enums.SceneType.Hospital] = new Hospital(this);
        }

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        public void ChangeScene(Enums.SceneType sceneType)
        {
            curscene = scenes[(int)sceneType];
            curscene.Enter();
        }
        public void Start()
        {
            this.isRunning = true;

            curscene = scenes[(int)Enums.SceneType.StartScene];
            curscene.Enter();
        }
        public void GameOver()
        {
            this.isRunning = false; 
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
