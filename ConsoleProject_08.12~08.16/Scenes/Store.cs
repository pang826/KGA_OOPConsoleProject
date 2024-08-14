using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Store : Scene
    {
        Items.WeaponItem WoodWand;
        Items.ArmorItem LeatherArmor;
        public Store(Game game) : base(game) 
        {
            WoodWand = new Items.WeaponItem("나무 완드", "기본적인 나무 완드",250);
            WoodWand.ItemDamage(10);
            LeatherArmor = new Items.ArmorItem("가죽갑옷", "기본적인 가죽 갑옷", 300);
            LeatherArmor.ItemDefense(2);
        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("상점으로 향합니다");
            Waits.Wait(1);
        }

        public override void Input()
        {
            inputStr = Console.ReadLine();
        }

        public override void Update()
        {
            if(int.TryParse(inputStr, out int BuyItemNum))
            {
                switch (BuyItemNum) 
                {
                    case 1:
                        WoodWand.InputInven(); // 아이템을 구매하면 인벤토리에 집어넣는 조건문
                        break;
                    case 2:
                        LeatherArmor.InputInven();
                        break;
                        // 아이템 구매, 아이템 판매, 상점 나가기 선택지를 만들어야 함.
                        
                }
            }
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("상점에 방문하였습니다.");
            Waits.Wait(1);
            Console.WriteLine("물품을 둘러봅니다.");
            Waits.Wait(1);
            Console.Clear();
            Console.WriteLine("상점품목");
            Console.WriteLine("=================================================");
            Console.WriteLine("무기");
            Console.WriteLine($"1. |{WoodWand.Name}| - {WoodWand.Description}| {WoodWand.cost}G");
            Console.WriteLine("=================================================");
            Console.WriteLine("방어구");
            Console.WriteLine($"2. |{LeatherArmor.Name}| - {LeatherArmor.Description}| {LeatherArmor.Cost}G");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.Write("구매할 아이템 번호를 입력하세요 : ");
        }

        public override void Exit()
        {

        }

        public void BuyItem()
        {
            
        }
    }
}
