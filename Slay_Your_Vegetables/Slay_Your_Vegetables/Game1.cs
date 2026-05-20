using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Slay_Your_Vegetables;
public enum GameState { MainMenu, Playing, Options }
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
    private GameState _currentState = GameState.MainMenu; 

    //Map UI
    private Texture2D _line1, _line2, _line3, _line4;
    private Texture2D tomatoT; // any enemy
    private Texture2D chefTex;

    // GAME OBJECTS
    private Player player;
    private Sprite tomato;

    // UI 
    private SpriteFont gameFont;
    private Texture2D pixel; 
    private Rectangle playButton;
    private Rectangle optionsButton;
    private Rectangle exitButton;
    
    private MouseState currentMouse;
    private MouseState previousMouse;

    private Random rnd = new Random();

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
        int centerX = GraphicsDevice.Viewport.Width / 2 - 125;
        playButton = new Rectangle(centerX, 220, 250, 60);
        optionsButton = new Rectangle(centerX, 290, 250, 60);
        exitButton = new Rectangle(centerX, 360, 250, 60);

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


        gameFont = Content.Load<SpriteFont>("MainMenu");
        pixel = CreateTexture(1, 1, Color.White);
        tomatoT = Content.Load<Texture2D>("tomatoT");
        chefTex = Content.Load<Texture2D>("chef");

        _line1 = Content.Load<Texture2D>("line1");
        _line2 = Content.Load<Texture2D>("line2");
        _line3 = Content.Load<Texture2D>("line3");
        _line4 = Content.Load<Texture2D>("line4");

        player = new Player(chefTex, new Vector2(100, 200));
        tomato = new Sprite(tomatoT, new Vector2(700, 231));
    }

    private Texture2D CreateTexture(int width, int height, Color color)
    {
        var texture = new Texture2D(GraphicsDevice, width, height);
        Color[] data = new Color[width * height];
        Array.Fill(data, color);
        texture.SetData(data);
        return texture;
    }
    // Spawns enemy (tomato) at random lane positions
    private void SpawnTomato()
    {
        int[] lanesY = { 45, 138, 231, 324 };
        int lane = rnd.Next(lanesY.Length);

        tomato = new Sprite(tomatoT, new Vector2(700, lanesY[lane]));
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
    protected override void Update(GameTime gameTime)
    {
        currentMouse = Mouse.GetState();
        KeyboardState keyState = Keyboard.GetState();

        if (keyState.IsKeyDown(Keys.Escape)) Exit();

        switch (_currentState)
        {
            case GameState.MainMenu:
                UpdateMenu();
                break;

            case GameState.Options:
                if (keyState.IsKeyDown(Keys.Back))
                    _currentState = GameState.MainMenu;
                break;

            case GameState.Playing:
                player.Update(gameTime);

                if (tomato != null)
                {
                    tomato.Position.X -= 4f;

                    if (tomato.Position.X < -100)
                    {
                        SpawnTomato();
                    }
                }

                break;
        }

        previousMouse = currentMouse;
        base.Update(gameTime);
    }

    private void UpdateMenu()
    {
        if (currentMouse.LeftButton == ButtonState.Pressed &&
            previousMouse.LeftButton == ButtonState.Released)
        {
            Point mousePos = currentMouse.Position;

            if (playButton.Contains(mousePos))
            {
                _currentState = GameState.Playing;
                SpawnTomato();
            }
            else if (optionsButton.Contains(mousePos))
                _currentState = GameState.Options;
            else if (exitButton.Contains(mousePos))
                Exit();
        }
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

        switch (_currentState)
        {
            case GameState.MainMenu: DrawMenu(); break;
            case GameState.Playing: DrawGame(); break;
            case GameState.Options: DrawOptions(); break;
        }

        _spriteBatch.End();
        base.Draw(gameTime);
    }

    private void DrawMenu()
    {
        string title = "SLAY YOUR VEGETABLES";
        Vector2 size = gameFont.MeasureString(title) * 2f;
        Vector2 pos = new Vector2((GraphicsDevice.Viewport.Width / 2) - (size.X / 2), 80);

        _spriteBatch.DrawString(gameFont, title, pos, Color.Orange, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0f);

        DrawButton(playButton, "PLAY", Color.Green);
        DrawButton(optionsButton, "OPTIONS", Color.Yellow);
        DrawButton(exitButton, "EXIT", Color.Red);
    }

    private void DrawGame()
    {
        _spriteBatch.Draw(_line1, new Rectangle(200, 45, 600, 90), Color.Beige);
        _spriteBatch.Draw(_line2, new Rectangle(200, 138, 600, 90), Color.Beige);
        _spriteBatch.Draw(_line3, new Rectangle(200, 231, 600, 90), Color.Beige);
        _spriteBatch.Draw(_line4, new Rectangle(200, 324, 600, 90), Color.Beige);

        _spriteBatch.Draw(pixel, new Rectangle(350, 0, 150, 35), Color.LightGray);
        _spriteBatch.Draw(pixel, new Rectangle(350, 425, 50, 50), Color.LightBlue);
        _spriteBatch.Draw(pixel, new Rectangle(450, 425, 50, 50), Color.Orange);

        _spriteBatch.Draw(pixel, new Rectangle(10, 415, 150, 20), Color.Green);
        _spriteBatch.Draw(pixel, new Rectangle(10, 435, 150, 20), Color.Yellow);
        _spriteBatch.Draw(pixel, new Rectangle(10, 455, 150, 20), Color.Blue);

        player.Draw(_spriteBatch);

        if (tomato != null)
            tomato.Draw(_spriteBatch);
    }

    private void DrawOptions()
    {
        string text = "OPTIONS";
        Vector2 size = gameFont.MeasureString(text);
        Vector2 pos = new Vector2(GraphicsDevice.Viewport.Width / 2 - size.X / 2, 200);

        _spriteBatch.DrawString(gameFont, text, pos, Color.Black);
        _spriteBatch.DrawString(gameFont, "Press BACKSPACE to Return", new Vector2(250, 400), Color.White);
    }

    private void DrawButton(Rectangle rect, string text, Color color)
    {
        bool isHovered = rect.Contains(currentMouse.Position);
        Color renderColor = isHovered ? Color.Lerp(color, Color.White, 0.3f) : color;

        _spriteBatch.Draw(pixel, rect, renderColor);

        Vector2 textSize = gameFont.MeasureString(text);
        Vector2 textPos = new Vector2(
            rect.X + (rect.Width - textSize.X) / 2,
            rect.Y + (rect.Height - textSize.Y) / 2
        );

        _spriteBatch.DrawString(gameFont, text, textPos, Color.Black);
    }
} 