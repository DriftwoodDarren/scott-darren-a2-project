// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.AccessControl;

// The namespace your code is in.
namespace MohawkGame2D
{
    ///     Your game code goes inside this class!
    public class Game
    {
        // Place your variables here:


        ///     Setup runs once before the game loop begins.
        public void Setup()
        {
            //Window Setup
            Window.SetTitle("Skull Cursor Follow");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;

            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            
            //Initial Drawing
            Window.ClearBackground(Color.Magenta);
            DrawSkull(Window.Width / 2, Window.Height / 2);
        }

        ///     Update runs every frame.
        public void Update()
        {

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                Window.ClearBackground(Color.Magenta);
                DrawSkull(Input.GetMouseX(), Input.GetMouseY());

            }

        }

        //Function for Skull Drawing 
        void DrawSkull(float x, float y)
        {
            //Top of Skull
            Draw.Line(x - 20, y - 60, x + 20, y - 60);

            //Right Side
            //Right Angle Upper
            Draw.Line(x + 20, y - 60, x + 40, y - 40);
            //Right Down Upper
            Draw.Line(x + 40, y - 40, x + 40, y - 10);
            //Right Angle Lower
            Draw.Line(x + 40, y - 10, x + 20, y + 10);
            //Right Down Lower
            Draw.Line(x + 20, y + 10, x + 20, y + 30);

            //Left Side
            //Left Angle Upper
            Draw.Line(x - 20, y - 60, x - 40, y - 40);
            //Left Down Upper
            Draw.Line(x - 40, y - 40, x - 40, y - 10);
            //Left Angle Lower
            Draw.Line(x - 40, y - 10, x - 20, y + 10);
            //Left Down Lower
            Draw.Line(x - 20, y + 10, x - 20, y + 30);

            //Teeth
            //Left Line
            Draw.Line(x - 10, y + 20, x - 10, y + 30);
            //Middle Line
            Draw.Line(x, y + 20, x, y + 30);
            //Right Line
            Draw.Line(x + 10, y + 20, x + 10, y + 30);

            //Nose
            //Right Down
            Draw.Line(x + 5, y + 5, x - 5, y - 5);
            //Left Down
            Draw.Line(x - 5, y + 5, x + 5, y - 5);

            //Eyes 
            //Left Eye
            Draw.Circle(x - 20, y - 20, 5);
            //Right Eye
            Draw.Circle(x + 20, y - 20, 5);
        }

    }

}
