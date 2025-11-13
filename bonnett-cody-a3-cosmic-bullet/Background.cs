using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Background
    {
        Vector2 position;
        Vector2 velocity;
        Texture2D texture;
        public void SetUp()
        {
            texture = Graphics.LoadTexture("Textures/background.png");
        }

        public void Update()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);
        }
    }
}
