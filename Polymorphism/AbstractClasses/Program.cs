namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            // shape artık abstract class=> base class. instance alınamaz. 
            //var shape = new Shape();
        }
    }
}
