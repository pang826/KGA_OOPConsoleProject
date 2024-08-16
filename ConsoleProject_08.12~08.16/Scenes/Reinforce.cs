using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Reinforce : Scene
    {
        public Reinforce(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("대장간으로 이동합니다");
            Waits.Wait(1);
            
        }

        public override void Input()
        {

        }

        public override void Update()
        {
            Console.WriteLine("미완성");
            Waits.Wait(1);
            game.ChangeScene(Enums.SceneType.Village);
        }

        public override void Render()
        {

        }

        public override void Exit()
        {

        }
    }
}
