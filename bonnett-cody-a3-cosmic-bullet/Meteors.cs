using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Meteors
    {
        public Vector2 position;
        public Vector2 velocity;
        Vector2 collision;
        Texture2D texture;

        public void Setup()
        {
            texture = Graphics.LoadTexture("Textures/asteroids.png");
        }

        public void Update()
        {
            position = position + velocity;
            DrawMeteor();
            
        }

        void ProcessPhysics()
        {

        }

        void ProcessCollision()
        {

        }

        void DrawMeteor()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 1.0f;
            Graphics.Draw(texture, position);
        }
    }
}
