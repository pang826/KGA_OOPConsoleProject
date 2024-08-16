using ConsoleProject_08._12_08._16.Items;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class Store : Scene
    {
        enum StoreState { Enter, Buy, Sold, Exit }
        StoreState storeState;
        WeaponItem WoodWand;
        ArmorItem LeatherArmor;
        public Store(Game game) : base(game)
        {
            WoodWand = new WeaponItem("나무완드", "나무완드다", 250);
            WoodWand.WeaponInputDmg(10);

            LeatherArmor = new ArmorItem("가죽갑옷", "기본적인 가죽 갑옷", 300);
            LeatherArmor.ArmorInputDef(2);
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("상점으로 향합니다");
            Waits.Wait(1);
            storeState = StoreState.Enter;
            Console.Clear();
            Console.WriteLine("상점에 방문하였습니다.");
        }

        public override void Input()
        {
            inputStr = Console.ReadLine();
        }

        public override void Update()
        {

            if (storeState == StoreState.Enter)
            {
                if (int.TryParse(inputStr, out int selectStore))
                {
                    switch (selectStore)
                    {
                        case 1:
                            storeState = StoreState.Buy;
                            break;
                        case 2:
                            Console.WriteLine("미완성");
                            Waits.Wait(1);
                            // storeState = StoreState.Sold;
                            break;
                        case 3:
                            game.ChangeScene(Enums.SceneType.Village);
                            break;
                    }
                }
            }
            else if (storeState == StoreState.Buy)
            {
                if (int.TryParse(inputStr, out int BuyItemNum))
                {
                    switch (BuyItemNum)
                    {
                        case 1:
                            BuyWeaponItem(WoodWand);
                            Waits.Wait(1);
                            break;
                        case 2:
                            BuyArmorItem(LeatherArmor);
                            Waits.Wait(1);
                            break;
                    }
                }
            }
           // else if (storeState == StoreState.Sold)
           // {
           //     if (int.TryParse(inputStr, out int SoldItemNum))
           //     {
           //         switch(SoldItemNum)
           //         {
           //             //case 1:
           //
           //         }
           //     }
           // }
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 구매 // 2. 판매 // 3. 나가기");
            if (storeState == StoreState.Buy)
            {
                Console.Clear();
                Console.WriteLine("물품을 둘러봅니다.");
                Waits.Wait(1);
                Console.Clear();
                Console.WriteLine("상점품목");
                Console.WriteLine("=================================================");
                Console.WriteLine("무기");
                Console.WriteLine($"1. |{WoodWand.Name}| - {WoodWand.Description}| {WoodWand.Cost}G");
                Console.WriteLine("=================================================");
                Console.WriteLine("방어구");
                Console.WriteLine($"2. |{LeatherArmor.Name}| - {LeatherArmor.Description}| {LeatherArmor.Cost}G");
                Console.WriteLine("=================================================");
                Console.WriteLine();
                Console.Write("구매할 아이템 번호를 입력하세요 : ");
            }
            else if (storeState == StoreState.Sold)
            {
                Console.Clear();
                Console.WriteLine("물품을 판매합니다.");
                Console.Write($"인벤토리 : ");
                game.player.ShowInven();
                Console.WriteLine("무엇을 판매하시겠습니까?");
            }
        }

        public override void Exit()
        {

        }

        public void BuyWeaponItem(WeaponItem storeItem)
        {
            if (game.player.gold >= storeItem.Cost)
            {
                game.player.inventory.AddPlayerItem(storeItem);
                game.player.gold -= storeItem.Cost;
                Console.WriteLine($"{storeItem.Name}을 구매하였습니다.");
                storeState = StoreState.Enter;
            }
            else
            {
                Console.WriteLine("골드가 부족합니다");
                storeState = StoreState.Enter;
            }
        }

        public void BuyArmorItem(ArmorItem storeItem)
        {
            if (game.player.gold >= storeItem.Cost)
            {
                game.player.inventory.AddPlayerItem(storeItem);
                game.player.gold -= storeItem.Cost;
                Console.WriteLine($"{storeItem.Name}을 구매하였습니다.");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다");
            }
        }

       // public void SoldItem(WeaponItem Item)
       // {
       //     game.inventory.RemoveItem(Item);
       //
       // }
    }
}
