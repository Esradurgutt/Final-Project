using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;


public interface ILevel
{
    Dictionary<int,int> Goals{get;}
    Dictionary<int, int> SpawnedCounters { get; }
    List<int> SpawnPool {get;}
    float spawnPeriod{get;}
}
public class LevelManage
{
    public ILevel CurrentLevel{get;private set;}
    public void LoadLevel(int lvlNumber)
    {
        switch (lvlNumber) //Add levels in here 
        {
            case 1: CurrentLevel= new Level1(); break;

            default: CurrentLevel=null; break;
            
        }
    }
    
}

public class Level1: ILevel //Salad tomato(0),lettuce(1),lemon(2),tuna(3)
{
     public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {0,4},{1,3},{2,2},{3,2} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int> // Enemy ID, Beginning count
    {
        {0,0},{1,0},{2,0},{3,0}
    };
    public List<int> SpawnPool => new List<int> {0,1,2,3}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }

}
public class Level2 // Hamburger tomato(0),lettuce(1),bread(4),gbeef(5)
{
public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {0,3},{1,2},{4,2},{5,4} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int> // Enemy ID, Beginning count
    {
        {0,0},{1,0},{4,0},{5,0}
    };
    public List<int> SpawnPool => new List<int> {0,1,4,5}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }
}
public class Level3 // Ali Nazik tomato(0), gbeef(5),eggplant(6),yogurt(7)
{
   public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {0,2},{5,3},{6,4},{7,2} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int> // Enemy ID, Beginning count
    {
        {0,0},{5,0},{6,0},{7,0}
    };
    public List<int> SpawnPool => new List<int> {0,5,6,7}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }
}
public class Level4 // Soup cream(8),butter(9),chicken(10),mushroom(11)
{
    public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {8,3},{9,2},{10,4},{11,3} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int> // Enemy ID, Beginning count
    {
        {8,0},{9,0},{10,0},{11,0}
    };
    public List<int> SpawnPool => new List<int> {8,9,10,11}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }
}
public class Level5 // Dessert cream(8),chocolate(12),banana(13), biscuit(14)
{
    public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {8,3},{12,3},{13,2},{14,4} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int> // Enemy ID, Beginning count
    {
        {8,0},{12,0},{13,0},{14,0}
    };
    public List<int> SpawnPool => new List<int> {8,12,13,14}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }
}


