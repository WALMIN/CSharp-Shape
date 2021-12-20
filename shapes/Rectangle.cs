namespace Shape.shapes
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height) : this(width)
        {
            this.height = height;
        }

        public Rectangle(double width)
        {
            this.width = width;
        }

        public override double GetArea()
        {
            double area = 0;

            if (height == 0)
            {
                area = width * width;

            }
            else
            {
                area = width * height;

            }
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = 0;

            if (height == 0)
            {
                perimeter = width * 4;

            }
            else
            {
                perimeter = (width * 2) + (height * 2);

            }

            return perimeter;
        }

        public override string ToString()
        {
            return $"This is a {this.GetType().Name.ToLower()} with width {width} and height {(height == 0 ? width : height)}. The area is {GetArea()} and the perimeter is {GetPerimeter()}.";
        }

    }
}