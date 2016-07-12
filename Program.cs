using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Variables Section
            String prompt = ">";
            String cheer_prefix = "Give me a";
            String requires_an = "aeiolnfshrmx";

            Console.WriteLine("Whats your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower();//Read from terminal save to a varialble

            for(int i = 0; i < user_name.Length; i++){
                if (requires_an.IndexOf(user_name[i])  > -1){
                   //Then its in the requires_an array  
                   Console.WriteLine(cheer_prefix + "n" + ".." + user_name[i]);
                }else{
                    //Does not require an "an"
                Console.WriteLine(cheer_prefix + ".. " + user_name[i]);
                }
            }

            //user_name.ToUpper() is turning the user's name to uppercase.
            //ToUpper() is functionality specific to Strings.
            //ToUpper() accepts no arguments

            Console.WriteLine(user_name.ToUpper() + " is..GRAND");
        }
    }
}