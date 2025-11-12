using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Player
    {

        public void SetUp()
        {

        }

        public void Update()
        {
            Draw.FillColor = Color.White;
            Draw.Rectangle(200, 300, 30, 20);
        }
    }
}
