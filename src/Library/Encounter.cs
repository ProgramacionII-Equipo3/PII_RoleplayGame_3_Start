using System;

namespace RoleplayGame
{
    public class Encounter
    {
        private readonly Hero[] heroes;
        private readonly Enemy[] enemies;

        public Encounter(Hero[] heroes, Enemy[] enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }

        private int turn = 0;
        public bool IsEnemyTurn { get; private set; } = true;

        public void DoEncounter()
        {
            while(NextTurn());
            Console.WriteLine(
                IsEnemyTurn
                ? "The enemies win :("
                : "The heroes win."
            );
        }

        public bool NextTurn() =>
            IsEnemyTurn ? nextEnemyTurn() : nextHeroTurn();

        private bool nextEnemyTurn()
        {
            for(int i = turn; i < turn + heroes.Length; i++)
            {
                if(heroes[i % heroes.Length].IsAlive)
                {
                    enemies[turn].Attack(heroes[i % heroes.Length]);
                    if(++turn >= enemies.Length)
                    {
                        IsEnemyTurn = false;
                        turn = 0;
                    }
                    return true;
                }
            }
            return false;
        }

        private bool nextHeroTurn()
        {
            for(int i = 0; i < enemies.Length; i++)
            {
                if(enemies[i].IsAlive)
                {
                    heroes[turn].Attack(enemies[i]);
                    if(++turn >= heroes.Length)
                    {
                        IsEnemyTurn = true;
                        turn = 0;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}