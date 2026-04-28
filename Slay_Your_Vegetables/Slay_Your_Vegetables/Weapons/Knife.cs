
    using System.Collections.Generic;

namespace Slay_Your_Vegetables
{
    public class Knife : Weapons
    {
        public Knife()
        {
            Damage = 10;
            EffectiveFoods = new List<string> { "Tomato", "Lettuce", "Lemon", "Bread", "Mushroom", "Banana", "Biscuit" };
        }

        public override void Attack(List<Enemy> enemies)
        {
            if (enemies.Count > 0)
            {
                enemies[0].TakeDamage(Damage);
            }
        }
        
// Damage decreases by 30% towards the back
        public override void Ultimate(List<Enemy> enemies)
        {
            float currentDamage = Damage * 2.5f;
            foreach (var enemy in enemies)
            {
                enemy.TakeDamage(currentDamage);
                currentDamage *= 0.7f;
            }
        }
    }
}
