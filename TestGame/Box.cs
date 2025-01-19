using Raylib_cs;

namespace Pratyaksh_Engine
{
    public class Box : GORect
    {
        private float velocityY = 0.0f;
        private float mass = 1.0f;

        private GORect collider;
        private Player player;

        private int textYLocation = 10;

        private float time = 6.75f;
        private float timer = 0.0f;

        private Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Orange, Color.Magenta };
        private int color = 0;

        private int bounces = 0;

        public Box(float x, float y, float sizeX, float sizeY, int textYLocation, Color color, float mass, GORect collider, Player player)
        {
            Transform = new Transform(x, y);
            SizeX = sizeX;
            SizeY = sizeY;
            Color = color;

            this.collider = collider;
            this.player = player;
            this.mass = mass;

            this.textYLocation = textYLocation;
        }

        public override void Input()
        {
        }

        public override void Update()
        {
            base.Update();

            velocityY += 9.8f * mass * Engine.DeltaTime;

            if (Physics.CheckRectCollision(collider, this) && velocityY > 0)
                velocityY = -velocityY * 0.75f;

            if (Physics.CheckRectCollision(player, this))
            {
                player.AddDestroyedBox();
                Game.DestroyGameObject(this);
            }

            Transform.Y += velocityY * Engine.DeltaTime;

            timer += Engine.DeltaTime;

            if (timer >= time)
            {
                timer = 0.0f;
                time = Raylib.GetRandomValue(4, 10);
                velocityY = Raylib.GetRandomValue(5, 10) * mass;

                color++;
                if (color >= colors.Length)
                    color = 0;

                Color = colors[color];
                bounces++;
            }    
        }
    }
}
