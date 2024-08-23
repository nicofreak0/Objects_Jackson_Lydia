namespace Objects_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer;

            // compares myComputer with myBootUp
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));


            string myString = myComputer.ToString();
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());
        }
    }
}