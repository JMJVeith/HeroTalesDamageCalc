namespace HeroTalesDamageCalc
{
    internal class Character
    {
        public int melee { get; set; }
        public int power { get; set; }
        public double base_speed { get; set; }
        public double charge_time { get; set; }

        public Character(int melee = 72, int power = 59)
        {
            this.melee = melee;
            this.power = power;
            base_speed = 1.5;
            charge_time = .03;
        }
    }
}