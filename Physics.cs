using System.Drawing;

namespace Pratyaksh_Engine
{
    public static class Physics
    {
        public static bool CheckRectCollision(GORect g1, GORect g2)
        {
            Rectangle a = new Rectangle((int)g1.Transform.X, (int)g1.Transform.Y, (int)g1.SizeX, (int)g1.SizeY);
            Rectangle b = new Rectangle((int)g2.Transform.X, (int)g2.Transform.Y, (int)g2.SizeX, (int)g2.SizeY);

            return a.IntersectsWith(b);
        }
    }
}
