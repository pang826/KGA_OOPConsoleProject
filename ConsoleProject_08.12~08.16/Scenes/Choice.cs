using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Choice : Scene
    {
        enum ChoiceState { Name, Job, Confirm} // 선택단계
        ChoiceState choiceState; // 선택단계 중 현재 선택한 것
        string confirmStr; // 입력받을 문자열 확인변수
        string nameInput;
        Enums.JobType jobType;
        public Choice(Game game) : base(game) { }
        public override void Enter() { }

        public override void Input()
        {
            confirmStr = Console.ReadLine();
        }

        public override void Update()
        {
            if(choiceState == ChoiceState.Name)
            {
                if(confirmStr == string.Empty)
                {
                    return;
                }
                nameInput = confirmStr;
                choiceState = ChoiceState.Job;
            }
            else if(choiceState == ChoiceState.Job)
            {
                if(Enum.TryParse(confirmStr, out jobType) == false)
                {
                    return;
                }
                else if(Enum.IsDefined(typeof(Enums.JobType), jobType) == false)
                {
                    return;
                }
                else
                {
                    switch(jobType)
                    {
                        case Enums.JobType.FireMage:
                            // firemage 객체생성
                            break;
                        case Enums.JobType.IceMage:
                            // Icemage 객체생성
                            break;
                        case Enums.JobType.EarthMage:
                            // Earthmage 객체생성
                            break;
                    }
                }
                choiceState = ChoiceState.Confirm;
            }
            else if(choiceState == ChoiceState.Confirm)
            {
                switch(confirmStr)
                {
                    case "Y":
                    case "y":
                        game.ChangeScene(Enums.SceneType.Village);
                        break;
                    case "N":
                    case "n":
                        choiceState = ChoiceState.Name;
                        break;
                    default:
                        break;
                }
            }
        }

        public override void Render()
        {
            if (choiceState == ChoiceState.Name)
            {
                Console.Clear();
                Console.WriteLine("플레이어의 이름을 입력해주세요 : ");
            }
            else if(choiceState == ChoiceState.Job)
            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("===============================================================");
                Console.WriteLine($"1. 불마법사 // 2. 얼음마법사 // 3. 땅마법사");
                Console.WriteLine("===============================================================");
            }
            else if(choiceState == ChoiceState.Confirm)
            {
                Console.Clear();
                // Console.WriteLine($"당신의 이름은 {game.player.name}입니다.");
                // Console.WriteLine($"당신의 직업은 {game.player.JobType}입니다.");
                // player 객체 얼추 만든 후 재수정 필요

                Console.WriteLine("확정 하시겠습니까? Y/N");
            }
        }

        public override void Exit()
        {

        }
    }
}
