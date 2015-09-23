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
    public class FadingPiece : GamePiece
    {
        public float alphaLevel = 1.0f;
        public static float alphaChangeRate = 0.2f;

    
    public FadingPiece(string pieceType, string suffix)
        : base (pieceType, suffix)
{

}
    public void UpdatePiece()
{
    alphaLevel = MathHelper.Max(
        0,
        alphaLevel - alphaChangeRate);
}
}

}

