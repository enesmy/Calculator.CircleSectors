using System;
using System.Drawing;

namespace Calculator.CircleSectors
{
    public class CircleSectorCalculator
    {
        public CircleSector GetFromAngleAndRadius(double angle, double radius)
        {
            CircleSector result = new CircleSector
            {
                ArcLength = (Math.PI * radius * 2) * angle / 360,
                Chord = 2 * radius * Math.Sin((angle / (180 / Math.PI)) / 2),
                SurfaceArea = (Math.PI * radius * radius) * angle / 360,
                Angle = angle,
                Radius = radius
            };
            return result;
        }

        public CircleSector GetFromArcLengthAndSurfaceArea(double arcLength, double surfaceArea)
        {
            double radius = surfaceArea * 2 / arcLength;
            double P = 2 * Math.PI * radius;
            double angle = 360 / P * arcLength;
            double chord = 2 * radius * Math.Sin((angle / (180 / Math.PI)) / 2);

            CircleSector result = new CircleSector
            {
                Angle = angle,
                Chord = chord,
                Radius = radius,
                SurfaceArea = surfaceArea,
                ArcLength = arcLength
            };
            return result;
        }
        
    }
}
