using Raylib_cs;

namespace Pratyaksh_Engine
{
    internal class BoxSpawner : GameObject
    {
        private float timer = 0.0f;
        private float time = 0.0f;

        private GORect floorRef;
        private Player playerRef;

        public BoxSpawner(float spawnTime, GORect floorRef, Player playerRef)
        {
            time = spawnTime;

            this.floorRef = floorRef;
            this.playerRef = playerRef;
        }

        public override void Input() { }

        public override void Render() { }

        public override void Update()
        {
            timer += Engine.DeltaTime;

            if (timer >= time)
            {
                timer = 0.0f;
                Spawn();
            }
        }

        private void Spawn()
        {
            Game.AddGameObject(new Box(Raylib.GetRandomValue(50, 500), 50, 50, 50, 10, Color.Red, 100.0f, floorRef, playerRef));
            Game.AddGameObject(new Box(Raylib.GetRandomValue(50, 500), 50, 50, 50, 35, Color.Red, 50.0f, floorRef, playerRef));
        }
    }
}
