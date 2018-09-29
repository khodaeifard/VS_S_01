using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VS_S_01
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Welcome to the hash generator");
            Console.WriteLine("Please enter the string to hash!");
            string input = Console.ReadLine();
            // converting to hash
            SHA1Managed sha = new SHA1Managed();
            byte[] hashed = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            // convert hash to string
            string hashedpassasstring = Convert.ToBase64String(hashed);
            Console.WriteLine(String.Format("The hash of {0} is: \n {1}", input, hashedpassasstring));
            // output
            Console.WriteLine("Press enter to copy the hash value to clipboard and to termminate the application!");
            Clipboard.SetText(hashedpassasstring);

            Console.ReadLine();
        }
    }
}
