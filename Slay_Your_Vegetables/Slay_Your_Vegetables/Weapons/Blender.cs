using System.Collections.Generic;

namespace Slay_Your_Vegetables
{
    public class Blender : Weapons
    {
        public Blender()
        {
            Damage = 8;
            EffectiveFoods = new List<string>() { "Yogurt", "Cream" };
        }

        public override void Attack(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.TakeDamage(Damage * 2f);//Blender will go to the end of the queue and then come back
            }
        }

        public override void Ultimate(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.TakeDamage(Damage * 0.5f);
                enemy.PushBack(2.0f);
            }
        }
    }
}
           