using System.Collections.Generic;

namespace Slay_Your_Vegetables
{
    public abstract class Weapons
    {
        public float Damage;
        public List<string> EffectiveFoods;

        public abstract void Attack(List<Enemy> enemies);
        public abstract void Ultimate(List<Enemy> enemies);
    }
}
