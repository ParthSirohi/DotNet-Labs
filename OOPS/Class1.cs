namespace OOPS
{
    public class Rectangle
    {
        public string Name { get; set; }
        public Rectangle()
        {
            this.Name = "Rectangle";
        }
        public Rectangle(float pLength, float pBreadth)     //ctor shorcut for constructor
        {
            this.Length = pLength;
            this.Breadth = pBreadth;

        }
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float CalculateArea()
        {
            return Length * Breadth;
        }
    }
}