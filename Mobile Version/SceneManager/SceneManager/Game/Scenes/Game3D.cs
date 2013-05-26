using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter6.Game.Game3D;
using Chapter6.Engine.Objects;
using Chapter6.Engine.Scenegraph;

namespace Chapter6.Game.Scenes
{
    public class Game3D : GameScene
    {
        private Hero3D _hero;
        private Enemy3D _enemy;
        private GameSprite _background;

        public Game3D() : base("Game3D") { }

        public override void Initialize()
        {
            _background = new GameSprite("Game2D/Background");
            _background.DrawInFrontOf3D = false;
            AddSceneObject(_background);

            _hero = new Hero3D();
            AddSceneObject(_hero);

            _enemy = new Enemy3D();
            AddSceneObject(_enemy);

            // Tick the camera
            AddSceneObject(SceneManager.RenderContext.Camera);

            base.Initialize();
        }
    }
}
