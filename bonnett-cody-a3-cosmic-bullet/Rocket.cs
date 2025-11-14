using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Rocket
    {

        public Vector2 rocketPosition;
        public Vector2 velocity;
        Vector2 size = new Vector2();
        float speed = 1500.0f;

        Texture2D texture;

        public void Setup()
        {
            texture = Graphics.LoadTexture("Textures/missile.png");
        }

        public void Update()
        {
 
           
           Physics();

           /* Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);*/
        }

       void Physics()
        {
            rocketPosition += speed * velocity * Time.DeltaTime;

            if (rocketPosition.X > Window.Width)
            {

            }
        }

        void Collision()
        {

        }
        void DrawRocket()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 1.0f;
            Graphics.Draw(texture, rocketPosition);
        }
    }
}
