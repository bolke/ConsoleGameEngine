using CGELib.Scenes;
using CGELib.Sprites.Shapes;
using System;

namespace CGEDemoLib.Scenes.Demo
{
    public class Demo1Scene : Scene
    {
        Random rand = new Random(Environment.TickCount);

        public override bool Initialize()
        {
            for(int i = 0; i < 100; i++)
            {
                Circle ball = new Circle();
                ball.Center.X = rand.Next(0, 480);
                ball.Center.Y = rand.Next(0, 254);
                ball.Radius = rand.Next(1, 20);
                ball.Color = rand.Next(1, 16);
                AddSprite(ball);
            }
            return true;
        }

        public override bool Update(long tick)
        {
            foreach(var actor in Actors)
            {
                if(actor is Circle circle)
                {
                    if (circle.Radius > 1 && rand.Next(1, 3) == 1)
                        circle.Radius--;
                    else
                        circle.Radius++;

                    switch (rand.Next(1, 5))
                    {
                        case 1:
                            circle.Center.X--;
                            break;
                        case 2:
                            circle.Center.X++;
                            break;
                        case 3:
                            circle.Center.Y--;
                            break;
                        case 4:
                            circle.Center.Y++;
                            break;
                    }
                }
            }
            return base.Update(tick);
        }
    }
}
