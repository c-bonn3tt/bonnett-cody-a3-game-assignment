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

        Vector2 position;
        Vector2 velocity;
        float speed = 1500.0f;

        Texture2D texture;

        public void Setup()
        {
            texture = Graphics.LoadTexture("Textures/missile.png");
        }

        public void Update()
        {
 
           DrawRocket();
           ProcessPhysics();

           /* Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);*/
        }

       public void ProcessPhysics()
        {
            position += speed * velocity * Time.DeltaTime;
        }

        public void DrawRocket()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.1f;
            Graphics.Draw(texture, position);
        }
    }
}
