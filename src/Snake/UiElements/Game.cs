using Snake.GameObjects;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public class Game : Panel, IGame
    {
        const int DEFAULT_INTERVAL = 250;

        private Meal _meal;
        private bool _updated;
        private Timer _gameTime;
        private Direction _direction;
        private IContainer _components;
        private GameObjects.Snake _snake;
        private Rectangle _playgroundBounds;

        public event EventHandler Paused;
        public event EventHandler Started;
        public event EventHandler Gameover;
        public event EventHandler Continued;
        public event EventHandler PointsChanged;

        public bool Running => _gameTime.Enabled;
        public int Points => _snake.BodyList.Count;

        public Game()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _components = new Container();
            _gameTime = new Timer(_components)
            {
                Interval = DEFAULT_INTERVAL
            };
            _gameTime.Tick += new EventHandler(GameTime_Tick);
            _playgroundBounds = new Rectangle(0, 0, Width, Height);
        }

        public void HandleInput(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Stop();
                    break;
            }

            if (Running && !_updated)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up: if (!_direction.Equals(Direction.Down)) _direction = Direction.Up; break;
                    case Keys.Down: if (!_direction.Equals(Direction.Up)) _direction = Direction.Down; break;
                    case Keys.Right: if (!_direction.Equals(Direction.Left)) _direction = Direction.Right; break;
                    case Keys.Left: if (!_direction.Equals(Direction.Right)) _direction = Direction.Left; break;
                }
            }

            _updated = true;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            _playgroundBounds = new Rectangle(0, 0, Width, Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Running)
            {
                _meal.Draw(e.Graphics);
                _snake.Draw(e.Graphics);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                if (_meal != null)
                {
                    _meal.Dispose();
                    _meal = null;
                }

                if (_snake != null)
                {
                    _snake.Dispose();
                    _snake = null;
                }
            }
        }

        public void New()
        {
            _snake = new GameObjects.Snake(this.Size);
            CreateMeal();
            _gameTime.Start();
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Continue()
        {
            if (!Running)
            {
                _gameTime.Start();
                Continued?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Stop()
        {
            if (Running)
            {
                _gameTime.Stop();
                Paused?.Invoke(this, EventArgs.Empty);
            }
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            if (_snake.IsColliding(_playgroundBounds))
            {
                _gameTime.Stop();
                Gameover?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (_snake.CanEat(_meal))
            {
                _snake.Eat(_meal);
                CreateMeal();
                SetDifficulty();
                PointsChanged?.Invoke(this, EventArgs.Empty);
            }

            _snake.Move(_direction);
            Refresh();

            _updated = false;
        }

        private void CreateMeal()
        {
            if (_meal != null)
            {
                _meal.Dispose();
            }
            _meal = new Meal(Width, Height);
        }

        private void SetDifficulty()
        {
            if (Points > 0)
            {
                _gameTime.Interval = DEFAULT_INTERVAL - Points;
            }
            else
            {
                _gameTime.Interval = 1;
            }
        }
    }
}
