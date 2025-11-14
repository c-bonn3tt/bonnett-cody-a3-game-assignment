// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2[] meteorPositions = [new Vector2(800, 200), new Vector2(800, 500), new Vector2(900, 300), new Vector2(900, 600), new Vector2(1000, 200), new Vector2(1000, 300)];
        
        MeteorManager manager;
        Player ship;
        Background movingBackground;
        Rocket[] rockets = new Rocket[4];
        int rocketIndex = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Cosmic Bullet");
            Window.SetSize(800, 600);

            movingBackground = new Background();
            movingBackground.Setup();

            /*for (int i = 0; i < meteor.Length; i++)
            {
                meteor[i] = new Meteors();
                meteor[i].Setup();
            }

            for (int i = 0; i < rockets.Length; i++)
            {
                rockets[i] = new Rocket();
                rockets[i].Setup();
            }*/
            ship = new Player();
            ship.Setup();
            manager = new MeteorManager();
            manager.Setup();
        }
        
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            movingBackground.Update();
            ship.Update();
            manager.Update();
            //int ammo = 0;

            /* if (Input.IsKeyboardKeyPressed(KeyboardInput.Space)) SpawnRocket();
             for (int i = 0; i < rockets.Length; i++)
             {
                 //skip the rocket if not spawned yet
                 if (rockets[i] == null)
                 {
                     ammo++;
                     continue;
                 }
                 rockets[i].Update();

                 if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
                 {
                     rockets = new Rocket[4];
                 }

             }*/



        }

        /* void SpawnRocket()
         {

             if (rockets[rocketIndex] != null) return;

             Rocket rocket = new Rocket();

             //position for rockets to come from player
             rocket.rocketPosition = ship.shipPosition;
    }*/

    }

}
