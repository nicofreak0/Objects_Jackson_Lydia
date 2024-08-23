namespace Objects_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new instance of computer class with parameters
            Computer myComputer = new Computer("Apple", "All-in-One", true);

            // assigns myComputer to an IBootUp variable
            IBootUp myBootUp = myComputer;

            // compares myComputer with myBootUp
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);

            // compares myComputer with myOtherComputer
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            //Compares myString with the result of myComputer and myOtherComputer
            string myString = myComputer.ToString();
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            //prints to console the type of myComputer and myBootUp instances
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            //calls PowerOnOff method on myOtherComputer
            myOtherComputer.PowerOnOff();

            //compares myString with the result of ToString
            Console.WriteLine(myString == myOtherComputer.ToString());

            //prints to console the value of myString
            Console.WriteLine(myString);

            // prints to console the string representation of myOtherComputer
            Console.WriteLine(myOtherComputer.ToString());

            // looks to see if myString contains the letter i 
            Console.WriteLine(myString.Contains('i'));

            // makes myString all uppercase
            Console.WriteLine(myString.ToUpper());
            
        }
    }
}