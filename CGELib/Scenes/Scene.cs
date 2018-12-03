using CGELib.Interfaces;
using System.Collections.Generic;

namespace CGELib.Scenes
{
    public abstract class Scene: IScene
    {
        public List<IActor> Actors { get; set; } = new List<IActor>();
        public List<ISprite> Sprites { get; set; } = new List<ISprite>();
        public ConsoleOutput Screen { get; set; }

        public abstract bool Initialize();

        public virtual bool Update(long tick)
        {
            foreach (var actor in Actors)
                actor.Update(tick);
            return true;
        }

        public virtual bool Render(long tick)
        {
            foreach (var sprite in Sprites)
                sprite.Render(Screen);
            return true;
        }

        public virtual void AddSprite(ISprite sprite)
        {
            if (sprite is IActor actor)
                Actors.Add(actor);
            Sprites.Add(sprite);            
        }

        public virtual void AddActor(IActor actor)
        {
            if (actor is ISprite sprite)
                Sprites.Add(sprite);
            Actors.Add(actor);
        }
    }
}
