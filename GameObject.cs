namespace Pratyaksh_Engine
{
    public abstract class GameObject
    {
        public Transform  Transform { get; set; }

        public GameObject()
        {
            Transform = new Transform();
        }

        public GameObject(float x, float y)
        {
            Transform = new Transform(x, y);
        }

        public abstract void Input();
        public abstract void Update();
        public abstract void Render();
    }
}
