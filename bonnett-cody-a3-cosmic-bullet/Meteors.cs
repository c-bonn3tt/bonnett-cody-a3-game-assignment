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
        Vector2 position;
        Vector2 collision;
        Texture2D texture;

        public void Setup()
        {
            texture = Graphics.LoadTexture("Textures/ship1.png");
        }

        public void Update()
        {

        }

        void ProcessPhysics()
        {

        }

        void ProcessCollision()
        {

        }
    }
}
