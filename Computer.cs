using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Jackson_Lydia
{
    // creates an internal class called computer and implements the IBootUp interface
    internal class Computer : IBootUp
    {
        //creates property for IsOn with a get and set
        public bool IsOn { get; set; }

        //creates property for Brand with a get and set
        public string Brand { get; set; }

        //creates property for Type with a get and set
        public string Type { get; set; }

        //parameters for brand tpe and IsOn
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        

        public void PowerOnOff()
        {
            // prints to console if IsOn is equal to true
            IsOn = !IsOn;
            if (IsOn == true) 
            {
                Console.WriteLine("The Computer is Booting Up.");
            }
            // prints to console if IsOn is equal to false
            else
            {
                Console.WriteLine("The Computer is Shutting down.");
            }
        }

        // returns a description of the computer
        public override string ToString()
        {
            return $"The Computer is Made by {Brand} and is a {Type} Computer.";
        }
    }
}
