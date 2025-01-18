namespace Pratyaksh_Engine
{
    public abstract class Game
    {
        private List<GameObject> gameObjects;

        public List<GameObject> GameObjects { get => gameObjects; }

        protected Game()
        {
            gameObjects = new List<GameObject>();
        }

        public virtual void Input()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Input();
            }
        }

        public virtual void Update()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
        }

        public virtual void Render()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
