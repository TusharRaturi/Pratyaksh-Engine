using Raylib_cs;
using System.Diagnostics;

namespace Pratyaksh_Engine
{
    internal class Engine
    {
        public static int Width { get; private set; }
        public static int Height { get; private set; }

        private Game gameRef;

        private Stopwatch stopwatch;

        private float deltaTime = 0.0f;

        private static Engine engineRef;

        public static float DeltaTime { get => engineRef.deltaTime; }

        public Engine(int width, int height, string title, Game game)
        {
            Width = width;
            Height = height;

            gameRef = game;

            engineRef = this;

            stopwatch = new Stopwatch();

            Raylib.InitWindow(width, height, title);
        }

        public void Run()
        {
            stopwatch.Start();
            
            double previousTime = stopwatch.Elapsed.TotalSeconds;

            while (!Raylib.WindowShouldClose())
            {
                Input();

                double currentTime = stopwatch.Elapsed.TotalSeconds;
                deltaTime = (float)(currentTime - previousTime);
                previousTime = currentTime;

                Update();
                Render();
            }

            Cleanup();
        }

        private void Input()
        {
            gameRef.Input();
        }

        private void Update()
        {
            gameRef.Update();
        }

        private void Render()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkGray);

            gameRef.Render();

            Raylib.EndDrawing();
        }

        private void Cleanup()
        {
            Raylib.CloseWindow();
        }
    }
}
