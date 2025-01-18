
namespace Pratyaksh_Engine
{
    public class Transform
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Transform()
        {
            X = 0.0f;
            Y = 0.0f;
        }

        public Transform(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
