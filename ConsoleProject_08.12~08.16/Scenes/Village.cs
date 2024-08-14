using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Village : Scene
    {
        public Village(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("마을로 진입합니다");
            Waits.Wait(2);
        }

        public override void Input()
        {

        }

        public override void Update()
        {

        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("마을이다");
            game.player.PrintStat();
        }

        public override void Exit()
        {

        }
    }
}
