using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Jackson_Lydia
{
    internal class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        

        public void PowerOnOff()
        {
            IsOn = !IsOn;
            if (IsOn == true) 
            {
                Console.WriteLine("The Computer is Booting Up.");
            }
            else
            {
                Console.WriteLine("The Computer is Shutting down.");
            }
        }

        public override string ToString()
        {
            return $"The Computer is Made by {Brand} and is a {Type} Computer.";
        }
    }
}
