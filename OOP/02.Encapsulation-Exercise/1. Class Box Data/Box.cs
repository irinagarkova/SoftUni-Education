using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Class_Box_Data
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            if (length <= 0) throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");

            if (length <= 0) throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");

            if (length <= 0) throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");

            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public double SurfaceArea() 
            => this.LateralSurfaceArea() + 2 * this.Length * this.Width;

        public double LateralSurfaceArea()
            => 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        
        public double Volume()
            => this.Length* this.Width* this.Height;
      
        
    }
}
