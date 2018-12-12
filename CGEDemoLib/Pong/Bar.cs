﻿using CGELib.Sprites.Shapes.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Actors
{
    public class Bar : SquareActor
    {
        public override bool Initialize()
        {
            Width = 10;
            Height = 40;
            Color = 5;
            Scale = 1;
            return base.Initialize();
        }

        public override bool Update(long tick)
        {
            Rotation += .1f;
            return true;
        }
    }
}
