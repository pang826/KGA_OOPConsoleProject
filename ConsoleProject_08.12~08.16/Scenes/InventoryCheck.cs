using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    public class InventoryCheck : Scene
    {
        enum InvenCheck { enter, }
        public InventoryCheck(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("인벤토리를 확인합니다.");
            Waits.Wait(1);
        }

        public override void Render()
        {
            if (game.player.inventory.GetInvenCount() == 0 && game.player.dropInventory.GetDropCount() == 0)
            {
                Console.WriteLine("인벤토리가 비었습니다.");
                Waits.Wait(1);
            }
            else
            {
                Console.WriteLine("장비 인벤토리 : ");
                game.player.ShowInven();
                Console.WriteLine("");
                Console.WriteLine("드랍템 인벤토리 : ");
                game.player.ShowDropInven();
                Console.WriteLine("");

                //미완성
                
            }
            
        }

        public override void Input()
        {
            // inputStr = Console.ReadLine();
        }

        public override void Update()
        {
            Console.WriteLine("미완성");
            Waits.Wait(1);
            game.ChangeScene(Enums.SceneType.Village);
        }
        public override void Exit() { }
    }
}
