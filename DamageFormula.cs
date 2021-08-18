using System;

namespace HeroTalesDamageCalc
{
    internal class DamageFormula
    {
        private Character player { get; set; }

        public DamageFormula(Character player)
        {
            this.player = player;
        }

        public int damage()
        {
            return player.power + ((int)Math.Pow(player.power + player.melee, 2.1) / 100);
        }
    }
}