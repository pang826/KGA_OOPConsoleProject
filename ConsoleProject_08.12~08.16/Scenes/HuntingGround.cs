using ConsoleProject_08._12_08._16.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class HuntingGround : Scene
    {
        enum SceneState { enter, spawn, exit}
        SceneState state;
        Random random;
        Monster ranMonster;
        int ranMonSpawn;
        
        public HuntingGround(Game game) : base(game) 
        {
            random = new Random();
            
        }
        
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("사냥터로 진입합니다");
            Waits.Wait(1);
            state = SceneState.enter;

        }

        public override void Input()
        {
            inputStr = Console.ReadLine();
        }

        public override void Update()
        {
            if(int.Parse(inputStr) != 1)
            {
                game.ChangeScene(Enums.SceneType.Village);
            }
            else if(state == SceneState.enter)
            {
                int ranMonSpawn = random.Next(1, 7);
                ranMonster = MonsterFactory.SpawnMon(ranMonSpawn);
                state = SceneState.spawn;
            }
            else if(state == SceneState.spawn)
            {
                
            }
        }

        public override void Render()
        {
            if (state == SceneState.enter)
            {
                Console.Clear();
                
                Console.WriteLine("나를 노려보는 시선이 느껴진다");
                Waits.Wait(1);
                Console.WriteLine("어떻게 하시겠습니까?");
                Console.WriteLine("1. 전투를 준비한다. // 2. 도망간다.");
            }
            else if(state == SceneState.spawn)
            {
                Console.WriteLine("몬스터가 등장합니다.");
                Console.WriteLine($"\"{ranMonster.name}\"이/가 수풀 속에서 나타났습니다.");
            }
        }

        public override void Exit()
        {

        }


    }
}
