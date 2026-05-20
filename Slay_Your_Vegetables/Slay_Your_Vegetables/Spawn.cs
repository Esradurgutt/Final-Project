using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

public class SpawnManage
{
    private List<Enemy> enemies;
    private Vector2[] spawnPoints;
    private Random random;
    private float spawnTime;
    public LevelManage lvl;

    private Dictionary<int, Texture2D> textures;

    public SpawnManage(LevelManage level, Dictionary<int, Texture2D> textures)
    {
        this.lvl = level;
        this.textures = textures;
        enemies = new List<Enemy>();
        random = new Random();

        spawnPoints = new Vector2[]
        {
            new Vector2(1920,120),
            new Vector2(1920,330),
            new Vector2(1920,540),
            new Vector2(1920,750)
        };
    }
    // add update and draw like Game1.cs

    public void Update(GameTime gameTime) // look again make it slower the spawn time
    {
        if (lvl.CurrentLevel == null) { return; } // seviye ayarı 

        spawnTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
        if (spawnTime >= lvl.CurrentLevel.spawnPeriod)
        {
            if (enemies.Count < 3)//ekrandaki düşman sayısı için
            {
                Spawn();
                spawnTime = 0;
            }
        }
        for (int i = enemies.Count - 1; i >= 0; i--)
        {
            enemies[i].Update(gameTime);
            if (enemies[i].CurrentHP <= 0)
            {
                enemies.RemoveAt(i);
                continue;
            }
            if (enemies[i].Position.X < -200)
            {
                enemies.RemoveAt(i);
            }
        }


    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (var enemy in enemies)
        {
            enemy.Draw(spriteBatch);
        }
    }

    private void Spawn() //for spawnning the spawnpoints
    {
        List<int> validIDs = new List<int>(); // the enemy list that saves requirements 
        foreach (var goal in lvl.CurrentLevel.Goals)
        {
            int id = goal.Key; //enemy ID
            int required = goal.Value; //requirements
            if (lvl.CurrentLevel.SpawnedCounters[id] < required)
            {
                validIDs.Add(id);
            }
        }

        if (validIDs.Count > 0)
        {
            int selectedID = validIDs[random.Next(0, validIDs.Count)];
            Vector2 position = spawnPoints[random.Next(0, spawnPoints.Length)];

            Enemy n_enemy = Enemy.CreateEnemy(selectedID, position);

            if (n_enemy != null)
            {
                enemies.Add(n_enemy);
                lvl.CurrentLevel.SpawnedCounters[selectedID]++;
            }
        }
    }

}


