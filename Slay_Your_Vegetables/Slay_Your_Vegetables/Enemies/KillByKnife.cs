using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


internal class Tomato:Enemy
{
    public Tomato(Texture2D texture, Vector2 position) : base(texture, position)
    {
        Name="Tomato";
        texture=this.texture;
        position= this.position;
    }
}