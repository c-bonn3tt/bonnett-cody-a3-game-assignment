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

        Texture2D ship1;

       public Vector2 shipPosition;
        Vector2 velocity;
        Vector2 collision;
        Vector2 size;

        float speed = 10.0f;
        public void Setup()
        {
            shipPosition = new Vector2(100, 300);
            ship1 = Graphics.LoadTexture("Textures/ship1.png");
            size = new Vector2(ship1.Width, ship1.Height);
        }

        public void Update()
        {
           
            Inputs();
            Physics();
            Collision();
            DrawShip();
        }

        void Inputs()
        {
            //move player up
            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                velocity.Y -= speed;
            }
            
            // move player down
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                velocity.Y += speed;
            }
        }

        void Physics()
        {
            shipPosition += velocity * Time.DeltaTime;
        }
      
        void Collision()
        {
        
        }
       
         void DrawShip()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(ship1, shipPosition);
        }
    }
}
