using System;
using System.Collections.Generic;
using System.Text;

namespace EX18SimpleClasses
{
    internal class Box
    {
        public int Width {  get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        private int Volume {  get; set; }
        private int Surface { get; set; }
        public void CalculateVolume()
        {
            Volume = Length * Width * Height;
        }
        public void CalculateSurface()
        {
            Surface = 2 * (Length * Width + Length * Height + Width * Height);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"The box has the following dimensions\nHeight: {Height} cm\nLenght: {Length} cm\nWidht: {Width} cm\nVolume: {Volume} m3\nSurface: {Surface} cm2");
        }
    }
}
