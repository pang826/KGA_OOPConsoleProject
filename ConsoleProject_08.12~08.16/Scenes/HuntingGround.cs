using ConsoleProject_08._12_08._16.Monsters;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Scenes
{
    internal class HuntingGround : Scene
    {
        enum SceneState { enter, spawn, battle, exit}
        SceneState state;
        Random random;
        Monster ranMonster;

        string battleInputStr;
        int ranMonSpawn; // 랜덤 몬스터 스폰
        int ranRunAway; // 랜덤 도망 확률
        bool battle;
        bool select; // input으로 선택지를 고르고 싶을땐 true 그냥 넘어가고 싶을땐 false
        
        public HuntingGround(Game game) : base(game) 
        {
            random = new Random();
            battle = true;
            select = true; 
        }
        
        public override void Enter()
        {
            select = true;
            battle = true;
            Console.Clear();
            Console.WriteLine("사냥터로 진입합니다");
            Waits.Wait(1);
            state = SceneState.enter;
        }

        public override void Input()
        {
            if (select)
            {
                inputStr = Console.ReadLine();
            }
        }

        public override void Update()
        {
            if(int.Parse(inputStr) != 1)
            {
                game.ChangeScene(Enums.SceneType.Village);
            }
            else if(state == SceneState.enter)
            {
                ranMonSpawn = random.Next(1, 7);
                ranMonster = MonsterFactory.SpawnMon(ranMonSpawn);
                state = SceneState.spawn;
            }
            else if(state == SceneState.spawn)
            {
                state = SceneState.battle;
            }
            else if (state == SceneState.battle)
            {
                game.ChangeScene(Enums.SceneType.Village);
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
                Waits.Wait(1);
                Console.WriteLine($"\"{ranMonster.name}\"이/가 수풀 속에서 나타났습니다.");
                Waits.Wait(1);
                select = false; // 선택지 입력 X
                
            }
            else if(state == SceneState.battle)
            {
                
                while(battle)
                {
                    select = true;
                    Battle();
                }
                
            }
        }

        public override void Exit()
        {

        }

        public void MonsterHpState()
        {
            int hp = (ranMonster.hp / 10) + 1;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < hp; i++)
            {
                Console.Write("■");
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public void MonsterAttack()
        {
            Waits.Wait(1);
            // 몬스터 공격
            Console.WriteLine($"{ranMonster.name}의 공격!");
            if (ranMonster.dmg > game.player.def) // 공격성공
            {
                Waits.Wait(1);
                Console.WriteLine($"{(ranMonster.dmg) - game.player.def}의 데미지를 입었습니다!");
                game.player.curHp -= ranMonster.dmg - game.player.def;
                Waits.Wait(1);
            }
            else if (ranMonster.dmg <= game.player.def) // 공격실패
            {
                Waits.Wait(1);
                Console.WriteLine($"{ranMonster.name}의 공격력이 {game.player.name}의 방어력보다 약해 피해를 받지 않습니다");
                Waits.Wait(1);
            }
        }

        public void Battle()
        {
            if (ranMonster.hp <= 0)
            {
                battle = false;
                select = false;
                Console.WriteLine("몬스터 사냥 성공!");
                Waits.Wait(1);
                game.player.dropInventory.AddDropItem(ranMonster.dropItem);
                return;
            }
            else if (game.player.curHp <= 0)
            {
                battle = false;
                Console.WriteLine("플레이어 사망!");
                Waits.Wait(1);
                return;
            }

            Console.Clear();
            game.player.PrintStat();
            Console.WriteLine("=========================================================");
            Console.WriteLine($"몬스터 이름 : {ranMonster.name}");
            Console.WriteLine($"몬스터 체력 : {ranMonster.hp}");
            MonsterHpState();
            Console.WriteLine($"몬스터 공격력 : {ranMonster.dmg}");
            Console.WriteLine($"몬스터 방어력 : {ranMonster.def}");
            Console.WriteLine("=========================================================");
            Console.WriteLine("어떤 행동을 취할까요?");
            Console.WriteLine("1. 기본공격 // 2. 스킬사용(mp 20 소모) // 3. 도망간다");
            battleInputStr = Console.ReadLine();

            if (int.Parse(battleInputStr) == 1)
            {
                //플레이어 공격
                if(ranMonster.def < game.player.dmg) // 공격성공
                {
                    Console.WriteLine($"{game.player.name}의 공격!");
                    ranMonster.TakeDamage(game.player);
                    Waits.Wait(1);
                    Console.WriteLine($"{game.player.dmg - ranMonster.def}의 데미지를 입혔습니다!");
                    Waits.Wait(1);
                    if (ranMonster.hp <= 0)
                    {
                        battle = false;
                        select = false;
                        Console.WriteLine("몬스터 사냥 성공!");
                        Waits.Wait(1);
                        game.player.dropInventory.AddDropItem(ranMonster.dropItem);
                        return;
                    }
                }
                else if(ranMonster.def >= game.player.dmg)
                {
                    Console.WriteLine($"{game.player.name}의 공격이 통하지 않습니다!");
                    Waits.Wait(1);
                }

                MonsterAttack();
            }
            else if (int.Parse(battleInputStr) == 2) //스킬사용
            {
                if (game.player.curMp >= 20) // 마나가 20보다 많으면 스킬 사용
                {
                    int skillDamage = ((game.player.dmg - ranMonster.def) * 3);
                    game.player.Skill(ranMonster);
                    Waits.Wait(1);
                    if (skillDamage > ranMonster.def)
                    {
                        Console.WriteLine($"{skillDamage}의 데미지를 입혔습니다!");
                        Waits.Wait(1);
                        if (ranMonster.hp <= 0)
                        {
                            battle = false;
                            select = false;
                            Console.WriteLine("몬스터 사냥 성공!");
                            Waits.Wait(1);
                            game.player.dropInventory.AddDropItem(ranMonster.dropItem);
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{game.player.name}의 스킬이 통하지 않습니다!");
                        Waits.Wait(1);
                    }
                }
                else // 마나가 부족할경우
                {
                    Console.WriteLine("마나가 부족합니다");
                    Waits.Wait(1);
                    return;
                }
                MonsterAttack();
            }
            else if (int.Parse(battleInputStr) == 3)
            {
                ranRunAway = random.Next(1, 3);
                if (ranRunAway == 1)
                {
                    Console.WriteLine("도망가는데 성공했습니다!");
                    Waits.Wait(1);
                    battle = false;
                    select = false;
                }
                else 
                {
                    Console.WriteLine("도망가지 못했습니다!");
                    MonsterAttack();
                    return;
                }
            }
        }
    }
}
