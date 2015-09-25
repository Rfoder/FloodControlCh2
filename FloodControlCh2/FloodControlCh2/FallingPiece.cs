using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace FloodControl
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    class FallingPiece : GamePiece
    {
        public int VerticalOffset;
        public static int fallRate = 5;

        public FallingPiece(string pieceType, int verticalOffset)
            : base(pieceType)
        {
            VerticalOffset = verticalOffset;
        }
        public void UpdatePiece()
        {
            VerticalOffset = (int)MathHelper.Max(
            0,
            VerticalOffset - fallRate);
        }
    }
}
