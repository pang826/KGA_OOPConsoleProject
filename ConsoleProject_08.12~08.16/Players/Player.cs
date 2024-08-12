using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16;

namespace ConsoleProject_08._12_08._16.Players
{
    public class Player
    {
        public Enums.JobType jobType;
        public string name;
        public int maxHp {  get; set; }
        public int curHp {  get; set; }
        public int maxMp { get; set; }
        public int curMp { get; set; }
        public int dmg { get; set; }
        public int def {  get; set; }
        public int gold { get; set; }
        public int evasion { get; set; }

        public void ChoiceJob(Enums.JobType jobType)
        {
            bool jobConfirm = false;
            do // 1차 반복문(1번째 입력을 제대로 할때까지 반복)
            {
                Console.WriteLine("직업을 선택해주세요.");
                Console.WriteLine($"1. 불마법사 // 2. 얼음마법사 // 3. 땅마법사");
                Enum.TryParse(Console.ReadLine(), out jobType);
                bool jobInput = Enum.IsDefined(jobType);
                
                if (jobInput == true)
                {
                    this.jobType = jobType;
                    do // 2차 반복문(2번째 입력을 제대로 할때까지 반복)
                    {
                        Console.WriteLine($"당신은 {jobType}입니다.");
                        Console.WriteLine("확정하시겠습니까?");
                        Console.WriteLine("Y/N");
                        string confirm = Console.ReadLine();
                        if (confirm == "Y")
                        {
                            // 다음 씬으로 넘어가는 명령
                            jobConfirm = true;
                        }
                        else if (confirm == "N")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 값을 입력하였습니다.");
                            continue;
                        }
                    } while (jobConfirm == false);
                }
                else
                {
                    Console.WriteLine("잘못된 값을 입력하였습니다.");
                    continue;
                }
            } while (jobConfirm == false);
        }
        
    }
}
