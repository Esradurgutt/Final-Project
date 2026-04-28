using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface IEnemy
{
    string Name { get; set; }
    int MaxHP { get; set; }
    int CurrentHP { get; set; }
    int AttackPower { get; set; }
    int Speed { get; set; }
    void Attack();
    void DealDamage();
}
public class Enemy : Sprite, IEnemy
{
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public int AttackPower { get; set; }
    public int Speed { get; set; }

    public Enemy(Texture2D texture, Vector2 position) : base(texture, position)
    {
    
    }

    //I added it so that no error would appear.
    public void TakeDamage(float amount) { }
    public void PushBack(float force) { }

    public void Attack() { }
    public void DealDamage() { }
}


