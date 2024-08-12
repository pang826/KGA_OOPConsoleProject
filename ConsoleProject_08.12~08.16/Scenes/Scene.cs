using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    public abstract class Scene
    {
        Enums.SceneType sceneType;
        

        public abstract void Enter();
        public abstract void Input();
        public abstract void Render();
        public abstract void Update();
        public abstract void Exit();
    }
}
