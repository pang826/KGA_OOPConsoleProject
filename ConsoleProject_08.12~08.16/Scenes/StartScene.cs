using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class StartScene : Scene
    {
        
        public StartScene(Game game) : base(game) { }

        public override void Enter()
        {
            
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {
            game.ChangeScene(Enums.SceneType.Choice);
        }

        public override void Render()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                         Wizard RPG                      ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("||                                                         ||");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("시작하려면 아무키나 누르세요");
        }

        public override void Exit()
        {
            
        }
    }
}
