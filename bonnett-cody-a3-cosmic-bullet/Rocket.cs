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

       public Vector2 position;
       public Vector2 velocity;
        float speed = 1500.0f;

        Texture2D texture;

        public void SetUp()
        {
            texture = Graphics.LoadTexture("Textures/missile.png");
        }

        public void Update()
        {
            ProcessPhysics();
            DrawRocket();
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture, position);
        }

        void ProcessPhysics()
        {
            position += speed * velocity * Time.DeltaTime;
        }

        void DrawRocket()
        {
            Draw.LineSize = 2;
            Draw.FillColor = Color.Red;
            Draw.LineColor = new Color("#FFA500");
            Draw.Circle(position, 7.0f);
        }
    }
}
