using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Slay_Your_Vegetables
{
    public class Enemy : Sprite, Icharacter
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int AttackPower { get; set; }

        public Enemy(Texture2D texture, Vector2 position) : base(texture, position)
        {
            Name = "Enemy";
            MaxHP = 50;
            CurrentHP = MaxHP;
            AttackPower = 10;
        }

        //I added it so that no error would appear.
        public void TakeDamage(float amount) { }
        public void PushBack(float force) { }

        public void Attack() { }
        public void DealDamage() { }
    }
}

