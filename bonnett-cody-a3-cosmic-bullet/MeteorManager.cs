using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    
    public class MeteorManager
    {
        Meteors[] meteors = new Meteors[25];
        int counter = 0;
        int spawnValue = 10;
        
        public void Setup()
        {
            
        }

        public void Update()
        {
            counter++;
            if (counter >= spawnValue)
            {
                counter = 0;
                SpawnMeteor();
            }
            for (int i = 0; i < meteors.Length; i++)
            {
                if (meteors[i] == null) continue;
                meteors[i].Update();
                if (meteors[i].position.X < -100)
                {
                    //let garbage disposal take care of it
                    meteors[i] = null;
                } 
            }
        }

        public void SpawnMeteor()
        {
            int yPos = Random.Integer(50, 550);
            int xPos = 850;
            Meteors meteor = new Meteors();
            meteor.position = new Vector2(xPos, yPos);
            meteor.velocity = new Vector2(-10, 0);
            for (int i = 0; i < meteors.Length; i++)
            {
                if (meteors[i] == null)
                {
                    meteors[i] = meteor;
                    break;
                }
            }
        }
    }
}
