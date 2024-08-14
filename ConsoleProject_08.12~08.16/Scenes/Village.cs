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
            inputStr = Console.ReadLine();

        }

        public override void Update()
        {
            if (int.TryParse(inputStr, out int inputNum) && inputNum > 0 && inputNum < 6)
            {
                switch (inputNum)
                {
                    case 1:
                        game.ChangeScene(Enums.SceneType.Reinforce);
                        break;
                    case 2:
                        game.ChangeScene(Enums.SceneType.SkillState);
                        break;
                    case 3:
                        game.ChangeScene(Enums.SceneType.HuntingGround);
                        break;
                    case 4:
                        game.ChangeScene(Enums.SceneType.Store);
                        break;
                    case 5:
                        game.ChangeScene(Enums.SceneType.Hospital);
                        break;
                }
            }
            else { return; }
        }

        public override void Render()
        {
            Console.Clear();
            game.player.PrintStat();
            Console.WriteLine();
            Console.WriteLine("이동할 장소를 선택하세요");
            Console.WriteLine("1. 아이템 강화 // 2. 스킬 관리 // 3. 사냥터 이동 // 4. 상점 이동 // 5. 병원 이동");
        }

        public override void Exit()
        {

        }
    }
}
