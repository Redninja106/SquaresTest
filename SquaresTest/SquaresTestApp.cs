using SimulationFramework;
using SimulationFramework.Drawing.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SquaresTest;

internal class SquaresTestApp : Simulation
{
    List<Vector2> positions;

    public override void OnInitialize(AppConfig config)
    {
        positions = new List<Vector2>();
    }

    public override void OnRender(ICanvas canvas)
    {
        if (Mouse.IsButtonPressed(MouseButton.Left))
        {
            positions.Add(Mouse.Position);
        }

        for (int i = 0; i < positions.Count; i++)
        {
            canvas.DrawRect(positions[i], new Vector2(50, 50));
        }
    }
}
