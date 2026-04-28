using System.Collections.Generic;

namespace Slay_Your_Vegetables
{
    public class Torch : Weapons
    {
        public Torch()
        {
            Damage = 9;
            EffectiveFoods = new List<string>() { "Tuna", "Ground beef", "Eggplant", "Butter", "Chicken", "Chocolate" };
        }

        public override void Attack(List<Enemy> enemies)
        {
            int half = enemies.Count / 2;
            for (int i = 0; i < half; i++)
            {
                enemies[i].TakeDamage(Damage);
            }
        }
        //It deals minor burn damage to all of them.
        public override void Ultimate(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.TakeDamage(Damage * 0.3f);
            }
        }
    }
}
   