using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Sprite
{
    public Texture2D Texture;
    public Vector2 Position;

    public Sprite(Texture2D texture, Vector2 position)
    {
        this.Texture = texture;
        this.Position = position;
    }
    //I added it so the player can move.
    public virtual void Update() { }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(Texture, Position, Color.White);
    }
}