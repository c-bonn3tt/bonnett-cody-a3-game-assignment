using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Player
    {
        Vector2 position;
        Texture2D texture;
        Vector2 size;
        public void Setup()
        {
            float playerY = Window.Height / 2.0f - 30;
            float playerX = Window.Width / 8.0f;

            position.X = playerX;
            position.Y = playerY;
            texture = Graphics.LoadTexture("Textures/ship1.png");
            size = new Vector2(texture.Width, texture.Height);
        }

        public void Update()
        {
        
        }

         public void DrawShip()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);
        }
    }
}
