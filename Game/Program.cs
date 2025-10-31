using System;
using OpenTK.Windowing;
using OpenTK.Windowing.Desktop;

namespace Windows_Engine
{
    internal class Program
    {
        static void Main()
        {
            using var game = new Game(GameWindowSettings.Default, new NativeWindowSettings()
            {
                Title = "OpenTK Phong Scene",
                ClientSize = new OpenTK.Mathematics.Vector2i(1280, 720),
                Vsync = OpenTK.Windowing.Common.VSyncMode.On
            });
            game.Run();
        }
    }
}
