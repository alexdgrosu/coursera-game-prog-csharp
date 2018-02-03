namespace ProgrammingAssignment04
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// A teddy bear
    /// </summary>
    public class TeddyBear
    {
        #region Fields

        // collecting support
        private bool collecting = false;
        private bool targetSet = false;

        // drawing support
        private Texture2D sprite;

        private Rectangle drawRectangle = new Rectangle();
        private int halfDrawRectangleWidth;
        private int halfDrawRectangleHeight;

        // moving support
        private const float BaseSpeed = 0.3f;
        private Vector2 location;
        private Vector2 velocity = Vector2.Zero;

        // click processing
        private bool leftClickStarted = false;
        private bool leftButtonReleased = true;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sprite">sprite for the teddy</param>
        /// <param name="location">location of the center of the teddy</param>
        public TeddyBear(Texture2D sprite, Vector2 location)
        {
            this.sprite = sprite;
            this.location = location;

            // STUDENTS: set halfDrawRectangleWidth and halfDrawRectangleHeight for efficiency
            halfDrawRectangleWidth = sprite.Width / 2;
            halfDrawRectangleHeight = sprite.Height / 2;

            // STUDENTS: set draw rectangle so teddy is centered on location
            drawRectangle.X = (int)(location.X - halfDrawRectangleWidth);
            drawRectangle.Y = (int)(location.Y - halfDrawRectangleHeight);
            drawRectangle.Width = sprite.Width;
            drawRectangle.Height = sprite.Height;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets and sets whether or not the teddy is collecting
        /// </summary>
        public bool Collecting
        {
            get { return collecting; }
            set { collecting = value; }
        }

        /// <summary>
        /// Gets the collision rectangle for the teddy
        /// </summary>
        public Rectangle CollisionRectangle
        {
            get { return drawRectangle; }
        }

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Updates the teddy
        /// </summary>
        /// <param name="gameTime">game time</param>
        /// <param name="mouse">current mouse state</param>
        public void Update(GameTime gameTime, MouseState mouse)
        {
            // STUDENTS: update location based on velocity if teddy is collecting Be sure to update
            // the location field first, then center the draw rectangle on the location
            if (collecting)
            {
                // update current location
                location.X += velocity.X * gameTime.ElapsedGameTime.Milliseconds;
                location.Y += velocity.Y * gameTime.ElapsedGameTime.Milliseconds;

                // center draw rectangle on updated location
                drawRectangle.X = (int)(location.X - halfDrawRectangleWidth);
                drawRectangle.Y = (int)(location.Y - halfDrawRectangleHeight);
            }

            // check for mouse over teddy
            if (drawRectangle.Contains(mouse.X, mouse.Y))
            {
                // check for left click started on teddy
                if (mouse.LeftButton == ButtonState.Pressed &&
                    leftButtonReleased)
                {
                    leftClickStarted = true;
                    leftButtonReleased = false;
                }
                else if (mouse.LeftButton == ButtonState.Released)
                {
                    leftButtonReleased = true;

                    // if click finished on teddy, start collecting if target set
                    if (leftClickStarted)
                    {
                        if (targetSet)
                        {
                            collecting = true;
                        }

                        leftClickStarted = false;
                    }
                }
            }
            else
            {
                // no clicking on teddy
                leftClickStarted = false;
                leftButtonReleased = false;
            }
        }

        /// <summary>
        /// Draws the teddy
        /// </summary>
        /// <param name="spriteBatch">sprite batch</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            // STUDENTS: use the sprite batch to draw the teddy
            spriteBatch.Draw(sprite, drawRectangle, Color.White);
        }

        /// <summary>
        /// Sets a target for the teddy to move toward
        /// </summary>
        /// <param name="target">target</param>
        public void SetTarget(Vector2 target)
        {
            targetSet = true;

            // STUDENTS: set teddy velocity based on teddy center location and target
            velocity.X = target.X - location.X;
            velocity.Y = target.Y - location.Y;

            // reduce to a unit vector with same direction
            velocity.Normalize();

            velocity.X = velocity.X * BaseSpeed;
            velocity.Y = velocity.Y * BaseSpeed;
        }

        /// <summary>
        /// Clears the target for the teddy (it no longer has a target)
        /// </summary>
        public void ClearTarget()
        {
            targetSet = false;
        }

        #endregion Public methods
    }
}