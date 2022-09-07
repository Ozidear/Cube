using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvarim
{
    class Cube
    {
        public enum Color { Red, Blue, Green, Yellow }

        Color faceUp, faceDown, faceRight, faceLeft, faceFront, faceBack;

        public Cube(Color faceUp, Color faceDown, Color faceRight, Color faceLeft, Color faceFront, Color faceBack)
        {
            this.faceUp = faceUp;
            this.faceDown = faceDown;
            this.faceRight = faceRight;
            this.faceLeft = faceLeft;
            this.faceFront = faceFront;
            this.faceBack = faceBack;
        }

        public void PitchUp()
        {
            Color temp = faceUp;

            faceUp = faceFront;
            faceFront = faceDown;
            faceDown = faceBack;
            faceBack = temp;
        }
        public void PitchDown()
        {
            Color temp = faceUp;

            faceUp = faceBack;
            faceBack = faceDown;
            faceDown = faceFront;
            faceFront = temp;
        }

    }
}
