using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Hospital : Scene
    {
        public Hospital(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("병원으로 향합니다");
            Waits.Wait(1);
        }

        public override void Input()
        {

        }

        public override void Update()
        {

        }

        public override void Render()
        {

        }

        public override void Exit()
        {

        }
    }
}
