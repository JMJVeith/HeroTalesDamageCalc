namespace HeroTalesDamageCalc
{
    internal class DPSCalc
    {
        private Character player { get; set; }
        private AttackSpeed speed { get; set; }
        private DamageFormula damage { get; set; }

        public DPSCalc(Character player)
        {
            this.player = player;
            speed = new(player);
            damage = new(player);
        }

        public double get_dps()
        {
            return speed.get_rate() * damage.damage();
        }
    }
}