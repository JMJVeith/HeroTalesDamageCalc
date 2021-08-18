using System;

namespace HeroTalesDamageCalc
{
    internal class AttackSpeed
    {
        private Character player { get; set; }

        public AttackSpeed(Character player)
        {
            this.player = player;
        }

        public double get_rate()
        {
            return 1 / (player.charge_time + (player.base_speed * Math.Pow(.99, player.melee)));
        }
    }
}