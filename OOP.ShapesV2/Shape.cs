namespace OOP.Shapes.Ex05.Home
{
    abstract class Shape
    {
        // field
        protected int width;

        protected int height;

        // ctor
        protected Shape(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public abstract double CalculateSurface();

        //// auto property
        //private int WidthProp { get; set; }
    }
}