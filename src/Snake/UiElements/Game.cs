using Snake.GameObjects;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public class Game : Panel, IGame
    {
        Meal essen;
        bool updated;
        Timer GameTime;
        Direction direction;
        IContainer components;
        GameObjects.Snake schlange;

        const int DEFAULT_INTERVAL = 250;

        public event EventHandler Over;
        public event EventHandler Paused;
        public event EventHandler Started;
        public event EventHandler Continued;

        public Boolean Running => GameTime.Enabled;
        public int Points => schlange.Koerper.Capacity;

        public Game() => InitializeComponent();

        private void InitializeComponent()
        {
            components = new Container();
            GameTime = new Timer(components)
            {
                Interval = DEFAULT_INTERVAL
            };
            GameTime.Tick += new EventHandler(GameTime_Tick);
        }

        public void Update(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Pause();
                    break;
            }

            if (Running && !updated)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up: if(!direction.Equals(Direction.Down)) direction = Direction.Up; break;
                    case Keys.Down: if (!direction.Equals(Direction.Up)) direction = Direction.Down; break;
                    case Keys.Right: if (!direction.Equals(Direction.Left)) direction = Direction.Right; break;
                    case Keys.Left: if (!direction.Equals(Direction.Right)) direction = Direction.Left; break;
                }
            }

            updated = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Running)
            {
                essen.Draw(e.Graphics);
                schlange.Draw(e.Graphics);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                if (essen != null)
                    essen = null;

                if (schlange != null)
                    schlange.Dispose();
            }
        }

        public void New()
        {
            schlange = new GameObjects.Snake(this.Bounds);
            essen = new Meal(this.Width, this.Height);
            GameTime.Start();
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Continue()
        {
            if (!Running)
            {
                GameTime.Start();
                Continued?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Pause()
        {
            if (Running)
                Stop();
        }

        public void Stop()
        {
            if (Running)
            {
                GameTime.Stop();
                Paused?.Invoke(this, EventArgs.Empty);
            }
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            if (schlange.IsColliding())
            {
                GameTime.Stop();
                Over?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (schlange.Ate(essen))
            {
                essen = new Meal(Width, Height);
                GameTime.Interval = Points > 0 ? DEFAULT_INTERVAL - Points : 1;
            }

            schlange.Bewegen(direction);
            Refresh();

            updated = false;
        }
    }
}
