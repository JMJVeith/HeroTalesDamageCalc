using System;

namespace HeroTalesDamageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new(72, 59);
            Character power_player = new(72, 60);
            Character skill_player = new(73, 59);
            DPSCalc dps = new(player);
            DPSCalc power_dps = new(power_player);
            DPSCalc skill_dps = new(skill_player);
            Console.WriteLine(dps.get_dps());
            Console.WriteLine($"Power: {power_dps.get_dps()}, Skill: {skill_dps.get_dps()}, Difference: {power_dps.get_dps() - skill_dps.get_dps()}");
        }
    }
}
