using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Slay_Your_Vegetables;



//Yogurt,cream
//normal hp (300), normal speed
public class Yogurt:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Yogurt(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Yogurt";
        MaxHP= 300;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "YogurtWalk/yogurtW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}
public class Cream:Enemy
{
    Game1 game1;
    public List<Texture2D> walkFrames;
    public List<Texture2D> attackFrames;
    public Cream(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Cream";
        MaxHP= 300;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;


        List<Texture2D> walkFrames = new List<Texture2D>();
        for (int i=0; i<24; i++)
        {
            string asset= "CreamWalk/creamW_" + i.ToString("D5"); // d5 oluşturacağı sayının basamağını belirtiyormuş
            Texture2D frame = Game1.ContentManager.Load<Texture2D>(asset);
            walkFrames.Add(frame);
        }
        
        this.walkAnimation = new WalkAnimation(walkFrames, 0.04f); // YOU CAN CHANGE THE ANIMATION SPEED IN HERE!!!
        this.animation = walkAnimation;
}
}