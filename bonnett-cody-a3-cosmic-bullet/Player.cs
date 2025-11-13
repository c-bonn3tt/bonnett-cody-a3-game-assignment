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
        public void SetUp()
        {
            texture = Graphics.LoadTexture("Textures/ship1.png");
        }

        public void Update()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);
        }

        void DrawShip()
        {
        
        }
    }
}
