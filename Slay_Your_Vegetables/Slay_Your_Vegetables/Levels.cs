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

public class Level1: ILevel
{
     public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs 
     {
         {0,4},{1,3},{2,2} //first - enemy ID second - enemy count
     };
    
    public Dictionary<int, int> SpawnedCounters { get; } = new Dictionary<int, int>
    {
        {0, 0}, {1, 0}, {2, 0}
    };
    public List<int> SpawnPool => new List<int> {0,1,2}; // The requirement (enemy ID's)
     public float spawnPeriod=> 3.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }

}
public class Level2
{

}
public class Level3
{
   
}
public class Level4
{
    
}
public class Level5
{
    
}


