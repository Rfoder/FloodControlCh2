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

namespace FloodConrolCh2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D playingPieces;
        Texture2D backgroundScreen;
        Texture2D tileScreen;

        GameBoard gameBoard;

        Vector2 gameBoardDisplayOrigin = new Vector2(70, 89);

        int playerScore = 0;

        enum GameStates { TitileScreen, Playing };
        GameStates gameState = GameStates.TitileScreen;

        Rectangle EmptyPiece = new Rectangle(1, 247, 40, 40);

        const float MinTimeSinceLastInput = 0.25f;
        float timeSinceLastInput = 0.0f;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
            gameBoard = new GameBoard();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            playingPieces = Content.Load<Texture2D>(@"Textures\Tile_Sheet");
            backgroundScreen = Content.Load<Texture2D>(@"Textures\BackGround");
            titleScreen = Content.Load<Texture2D>(@"Textures\TitleScreen");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            switch (gameState)
            {
                case GameStates.TitileScreen:
                    if(Keyboard.GetState(0.IsKeyDown(Keys.Space))
                    {
                        gameBoard.ClearBoard();
                        gameBoard.GenerateNewPieces(false);
                        playerScore = 0;
                        gameState = GameStates.Playing;
                    }
                    break;
            }
                case GameStates.Playing:
            timeSinceLastInput +=
                (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (timeSinceLastInput >= MinTimeSinceLastInput)
            {
                HandleMouseInput(Mouse.GetState());
            }

            gameBoard.ResetWater();
           
            for (int y = 0; y < gameBoard.GameBoardHeight; y++)
            {
                CheckScoreingChain(gameBoard.GetWaterChain(y));
            }

            gameBoard.GenerateNewPieces(true);
            break;
        }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


    if(gameState == GameStates.TitleScreen)
{
    spriteBatch.Begin();
    spriteBatch.Draw(titleScreen,
    new Rectangle(0, 0, 
    this.Window.ClientBounds.Width,
    this.Window.ClientBounds.Height),
    Color.White);
    spriteBatch.End();
}
if(gameState == GameStates.Playing)
{
spriteBatch.Begin();

spriteBatch.Draw(backgroundScreen,
 new Rectangle(0, 0,
 this.Window.ClientBounds.Width,
    this.Window.ClientBounds.Height),
    Color.White);

for(interface x = 0; x < GameBoard.GameBoardWidth; x++)
    for (int y = 0; y < GameBoard.GameBoardHeight; y++)
{
    int pixelX = (int)gameBoardDisplayOrigin.X +
        (x * GamePiece.PieceWidth);
    int pixelX = (int)gameBoardDisplayOrigin.Y +
        (y * GamePiece.PieceHeight);

            SpriteBatch.Draw(
                playingPieces,
            new Rectangle(
                pixelX,
                pixelY,
                GamePieceWidth,
                GamePieceHeight),
            EmptyPiece,
            Color.White);

      SpriteBatch.Draw(
                playingPieces, new Rectangle(
            new Rectangle(
                pixelX,
                pixelY,
                GamePiece.PieceWidth,
                GamePiece.PieceHeight),
            gameBoard.GetSourceRect(x, y),
            Color.White);
}
        this.Window.Title = playerScore.ToString();
spriteBatch.End();
}
            base.Draw(gameTime);
        }
private int DetermineScore(int SquareCount)
{
return (int)((Math.pow((SqaureCount / 5), 2) + SquareCount) * 10);
}

private void CheckScoreingChain(List<Vector2> WaterChain)
{

    if(WaterChain.Count > 0)
{
    Vector2 LastPipe = WaterChain[WAterChain.Count - 1];



    if (LastPipe.X == GameBoard.GameBoardWidth.Count);
    {
        if (gameBoard.HasConnector(
        (int)LastPipe.X, (int) LastPipe.Y, "Right"))
    {
    playerScore += DetermineScore(WaterChain.Count);

    foreach (Vector2 ScoringSquare in WaterChain)
        {
        gameBoard.SetSquare((int)ScoringSquare.X,
        (int)ScoringSquare.Y, "Empty");
            {
    }
}
