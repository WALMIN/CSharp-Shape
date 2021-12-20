namespace Shape
{

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract override string ToString();

        public virtual void SayHello(string greeting = "hello")
        {
            Console.WriteLine($"{this.GetType().Name} says {greeting}!");
        }

        public virtual void ScreamHello(string greeting = "hello")
        {
            Console.WriteLine($"{this.GetType().Name.ToUpper()} SCREAMS {greeting.ToUpper()}!");
        }
    }

}