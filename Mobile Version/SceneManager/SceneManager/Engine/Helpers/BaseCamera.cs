using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Chapter6.Engine.Scenegraph;

namespace Chapter6.Engine.Helpers
{
    public class BaseCamera : GameObject3D
    {
        public Matrix View { get; protected set; }
        public Matrix Projection { get; protected set; }

        public BaseCamera()
        {
            Projection = Matrix.CreateOrthographic(800, 480, 0.1f, 300);
        }

        public override void Update(RenderContext renderContext)
        {
            base.Update(renderContext);

            var lookAt = Vector3.Transform(Vector3.Forward, WorldRotation);
            lookAt.Normalize();

            View = Matrix.CreateLookAt(WorldPosition, (WorldPosition + lookAt), Vector3.Up);
        }
    }
}
