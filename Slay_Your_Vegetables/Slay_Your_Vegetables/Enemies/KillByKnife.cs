using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Slay_Your_Vegetables;

//Tomato, Lettuce, Lemon, Bread, Mushroom, Banana, Biscuit
//high hp (300-500), low speed


public class Tomato: Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Tomato(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Tomato";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;
       
        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "tomatoWalk/tomatoW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }

    public new void DealDamage(){}
    public new void TakeDamage(){}
    public new void PushBack(){}
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

}
public class Lettuce:Enemy
{
    public Lettuce(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Lettuce";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;
    }
}
public class Lemon:Enemy
{
    public Lemon(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Lemon";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;
    }
}
public class Bread:Enemy
{
    public Bread(Texture2D texture, Vector2 position): base(texture,position){}
}
public class Mushroom:Enemy
{
    public Mushroom(Texture2D texture, Vector2 position): base(texture,position){}
}