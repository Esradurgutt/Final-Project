using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Slay_Your_Vegetables;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    public static Microsoft.Xna.Framework.Content.ContentManager ContentManager;
    private SpriteBatch _spriteBatch;
    Texture2D _line1, _line2, _line3, _line4, requirements, weaponUI, UltUI, HealthUI, StaminaUI, ManaUI, texture;
    LevelManage levelManage;
    SpawnManage spawnManage;
    Vector2 position;
    Random random = new Random();
    public Rectangle Rectangle => new((int)position.X, (int)position.Y, texture.Width, texture.Height);


    private Texture2D CreateTexture(int width, int height, Color color)
    {
        var texture = new Texture2D(GraphicsDevice, width, height);
        var data = new Color[width * height];
        for (int i = 0; i < data.Length; i++)
            data[i] = color;
        texture.SetData(data);
        return texture;
    }


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.PreferredBackBufferWidth = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * 0.8f);
        _graphics.PreferredBackBufferHeight = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * 0.8f);
        _graphics.ApplyChanges();
        Window.Position = new Point(
        (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width - _graphics.PreferredBackBufferWidth) / 2,
        (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height - _graphics.PreferredBackBufferHeight) / 2);

    }

    protected override void Initialize()
    {
        levelManage = new LevelManage();
        levelManage.LoadLevel(1);
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        ContentManager = this.Content;


        if (Enemy.textures.Count == 0)
        {
            Enemy.textures.Add(0, Content.Load<Texture2D>("tomatoT"));
            Enemy.textures.Add(1, Content.Load<Texture2D>("lettuceT"));
            Enemy.textures.Add(2, Content.Load<Texture2D>("lemonT"));
            Enemy.textures.Add(3, Content.Load<Texture2D>("breadT"));
        }
        spawnManage = new SpawnManage(levelManage, Enemy.textures);



        requirements = CreateTexture(1, 1, Color.White);
        weaponUI = CreateTexture(1, 1, Color.White);
        UltUI = CreateTexture(1, 1, Color.White);
        HealthUI = CreateTexture(1, 1, Color.White);
        StaminaUI = CreateTexture(1, 1, Color.White);
        ManaUI = CreateTexture(1, 1, Color.White);


        _line1 = Content.Load<Texture2D>("line1");
        _line2 = Content.Load<Texture2D>("line2");
        _line3 = Content.Load<Texture2D>("line3");
        _line4 = Content.Load<Texture2D>("line4");
        // TODO: use this.Content to load your game content here


    }


    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        if (spawnManage != null)
        {
            spawnManage.Update(gameTime);
        }

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        float scaleX = (float)GraphicsDevice.Viewport.Width / 1920f;
        float scaleY = (float)GraphicsDevice.Viewport.Height / 1080f;
        Matrix scalingMatrix = Matrix.CreateScale(scaleX, scaleY, 1.0f);

        _spriteBatch.Begin(transformMatrix: scalingMatrix);

        _spriteBatch.Draw(_line1, new Rectangle(600, 120, 1320, 200), Color.Beige);
        _spriteBatch.Draw(_line2, new Rectangle(600, 330, 1320, 200), Color.Beige);
        _spriteBatch.Draw(_line3, new Rectangle(600, 540, 1320, 200), Color.Beige);
        _spriteBatch.Draw(_line4, new Rectangle(600, 750, 1320, 200), Color.Beige);

        _spriteBatch.Draw(requirements, new Rectangle(710, 0, 500, 100), Color.LightGray);
        _spriteBatch.Draw(weaponUI, new Rectangle(830, 970, 100, 100), Color.LightBlue);
        _spriteBatch.Draw(UltUI, new Rectangle(1000, 970, 100, 100), Color.Orange);
        _spriteBatch.Draw(HealthUI, new Rectangle(10, 415, 150, 20), Color.Green);
        _spriteBatch.Draw(StaminaUI, new Rectangle(10, 435, 150, 20), Color.Yellow);
        _spriteBatch.Draw(ManaUI, new Rectangle(10, 455, 150, 20), Color.Blue);


        //ADD SPRITES 
        if (spawnManage != null)
        {


            spawnManage.Draw(_spriteBatch);
        }
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
