// See https://aka.ms/new-console-template for more information

namespace GestFormTest
{
    class Program
    {
        static void Main(string[] args){
            
            Console.WriteLine("Hello, World!");

            for(int i=0; i<args.Length; ++i){

                int number;

                //Filtering args and exiting if requirements not fullfilled
                //Args are numbers
                if(!int.TryParse(args[i], out number)){
                    Console.WriteLine("One of your arguments is not a number, please enter only numeric arguments.");
                    Console.WriteLine("Argument recieved: " + args[i]);
                    return;
                }
                //Args are between -1000 and 1000
                if(number > 1000 || number < -1000){
                    Console.WriteLine("One of your arguments is invalid. Please enter a number between -1000 and 1000 included");
                    Console.WriteLine("Argument recieved: " + args[i]);
                    return;
                }
                
                Console.WriteLine(args[i]);
            }
        }


    }
}