using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Slay_Your_Vegetables;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    Texture2D _line1,_line2,_line3,_line4,requirements,tomatoT,weaponUI,UltUI,HealthUI,StaminaUI,ManaUI;
    Player player;
    Color color;
    Sprite tomato;

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
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        
        
        requirements= CreateTexture(1, 1, Color.White);
        
        tomatoT= Content.Load<Texture2D>("tomatoT");
        tomato= new Sprite(tomatoT,Vector2.Zero);
        weaponUI= CreateTexture(1, 1, Color.White);
        UltUI= CreateTexture(1, 1, Color.White);
        HealthUI= CreateTexture(1, 1, Color.White);
        StaminaUI= CreateTexture(1, 1, Color.White);
        ManaUI= CreateTexture(1, 1, Color.White);

        
        _line1= Content.Load<Texture2D>("line1");
        _line2= Content.Load<Texture2D>("line2");
        _line3= Content.Load<Texture2D>("line3");
        _line4= Content.Load<Texture2D>("line4");
        // TODO: use this.Content to load your game content here
        

    }

    
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
           Exit();
        
        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
            // Window default size is 800x600
        _spriteBatch.Begin();
        
        _spriteBatch.Draw(tomato.texture,tomato.position,Color.Red);

        _spriteBatch.Draw(_line1, new Rectangle(200,45,600,90), Color.Beige);
        _spriteBatch.Draw(_line2, new Rectangle(200,138,600,90), Color.Beige);
        _spriteBatch.Draw(_line3, new Rectangle(200,231,600,90), Color.Beige);
        _spriteBatch.Draw(_line4, new Rectangle(200,324,600,90), Color.Beige);

        _spriteBatch.Draw(requirements, new Rectangle(350, 0, 150, 35), Color.LightGray);
        _spriteBatch.Draw(weaponUI, new Rectangle(350, 425, 50, 50), Color.LightBlue);
        _spriteBatch.Draw(UltUI, new Rectangle(450, 425, 50, 50), Color.Orange);
        _spriteBatch.Draw(HealthUI, new Rectangle(10, 415, 150, 20), Color.Green);
        _spriteBatch.Draw(StaminaUI, new Rectangle(10, 435, 150, 20), Color.Yellow);
        _spriteBatch.Draw(ManaUI, new Rectangle(10, 455, 150, 20), Color.Blue);
       //ADD SPRITES 
        
        _spriteBatch.End();    

        base.Draw(gameTime);
    }
}
