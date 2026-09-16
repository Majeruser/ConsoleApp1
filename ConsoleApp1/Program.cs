namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            DogClass bodri = new DogClass("Bodri","Labrador",5);
            bodri.ToString();
            DogClass morzsi = new DogClass("Morzsi","Beagel",3);
            morzsi.ToString();

            Phone ph1 = new Phone("Samsung", "Galaxy S24");
            ph1.ToString();
            Phone ph2 = new Phone("Apple", "iPhone 16", 350000);
            ph2.ToString();

            Player p1 = new Player("Steve");
            p1.ToString();
            Player p2 = new Player("Alex", 5, 1200);
            p2.ToString();

            Car c1 = new Car("toyota","corall",2025);
            c1.ToString();
            Car c2 = new Car("bmw", "3212i", 2021);


        }
    }
}
