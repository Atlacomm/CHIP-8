using CHIP8.Windows;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    class Display : IDisposable
    {
        IGraphicsContext context;

        public Display()
        {
            context = new GraphicsContext(GraphicsMode.Default, mainWindow.glControl.WindowInfo);
            context.MakeCurrent(mainWindow.glControl.WindowInfo);
        }

        public void RenderBuffer(bool[] frameBuffer)
        {
            context.MakeCurrent(mainWindow.glControl.WindowInfo);

            for (int y = 0; y < SCREENHEIGHT; y++)
            {
                for (int x = 0; x < SCREENWIDTH; x++)
                {
                    bool pixel = frameBuffer[x + y * SCREENWIDTH];

                    GL.Color3(Color.White);
                    if (!pixel) GL.Color3(Color.Black);

                    (float tlX, float tlY) = PixelToGL(x, y);
                    (float trX, float trY) = PixelToGL(x + 1, y);
                    (float brX, float brY) = PixelToGL(x + 1, y + 1);
                    (float blX, float blY) = PixelToGL(x, y + 1);

                    GL.Begin(PrimitiveType.Triangles);

                    GL.Vertex2(tlX, tlY);
                    GL.Vertex2(trX, trY);
                    GL.Vertex2(blX, blY);
                    GL.Vertex2(blX, blY);
                    GL.Vertex2(trX, trY);
                    GL.Vertex2(brX, brY);

                    GL.End();
                }
            }

            mainWindow.glControl.SwapBuffers();
        }

        private (float, float) PixelToGL(int x, int y)
        {
            float X = x;
            X /= SCREENWIDTH / 2.0f;
            X--;

            float Y = y;
            Y /= SCREENHEIGHT / 2.0f;
            Y--;
            Y *= -1;

            return (X, Y);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
