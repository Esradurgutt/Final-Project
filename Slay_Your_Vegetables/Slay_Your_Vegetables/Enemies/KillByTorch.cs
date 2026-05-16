using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Slay_Your_Vegetables;


//Tuna, GroundBeef, Eggplant, Butter, Chicken, Chocolate
//low hp(100-300), high speed

public class Tuna:Enemy
{
    public Tuna(Texture2D texture, Vector2 position): base(texture, position)
    {
        Name="Tuna";
        MaxHP= 150;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "TunaWalk/tunaW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class GBeef:Enemy
{
    public GBeef(Texture2D texture, Vector2 position): base(texture,position)
    {
         Name="Ground Beef";
        MaxHP= 150;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "GBeefWalk/gbeefW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class Eggplant:Enemy
{
    public Eggplant(Texture2D texture, Vector2 position): base(texture,position)
    {
         Name="Eggplant";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "EggplantWalk/eggplantW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class Butter:Enemy
{
    public Butter(Texture2D texture, Vector2 position): base(texture,position)
    {
         Name="Butter";
        MaxHP= 200;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "ButterWalk/butterW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class Chicken:Enemy
{
    public Chicken(Texture2D texture, Vector2 position): base(texture,position)
    {
         Name="Chicken";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "ChickenWalk/chickenW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}
public class Chocolate:Enemy
{
    public Chocolate(Texture2D texture, Vector2 position): base(texture,position)
    {
         Name="Chocolate";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.5f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "ChocolateWalk/chocolateW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
    }
}