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
        MaxHP= 300;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;
       
        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "TomatoWalk/tomatoW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }

   public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    } 
    public new void DealDamage(){}
    public new void TakeDamage(){}
    public new void PushBack(){}
    

}
public class Lettuce:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Lettuce(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Lettuce";
        MaxHP= 400;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "LettuceWalk/lettuceW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class Lemon:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Lemon(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Lemon";
        MaxHP= 300;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "LemonWalk/lemonW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}
public class Bread:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Bread(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Bread";
        MaxHP= 350;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "BreadWalk/breadW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}
public class Mushroom:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Mushroom(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Mushroom";
        MaxHP= 350;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "MushroomWalk/mushroomW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}
public class Banana:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Banana(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Banana";
        MaxHP= 350;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 1.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "BananaWalk/bananaW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}
public class Biscuit:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Biscuit(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Biscuit";
        MaxHP= 350;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "BiscuitWalk/biscuitW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}