namespace Basics
{
    internal class Program_Basics
    {
        /***
         * 
         * Notes from C# Tutorial For Beginners - Learn C# Basics in 1 Hour by Programming with Mosh
         * 
         */


        /*
         * Entry point to the applicaiton. CLR will execute the code inside Main
         * void means method returns nothing
         */
        static void Main(string[] args)

            /*Class "Console" used to read/write data
             * methods can be accessed with dot notation. methods are a purple cube
             */
        {
            Console.WriteLine("Hello, World!");

            /*DECLARING VARIABLES */
            int numberSample = 2025;


        /*OVERFLOW */
        byte number = 255;
        number = number + 1; //returns 0. Overflow occurs because byte only goes up to 256. use checked'

            //INSTEAD, use 'checked' keyword. exception will be thrown but overflow will not occur
            checked
            {
                byte number = 255;
        number = number + 1;
            }


            /*SCOPE*/

            {//byte a is accessible in this block or any of this children 
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
}
                }
            }

            /*EXAMPLE CONSTANTS AND VAR*/

            byte number = 2;
float totalPrice = 20.95F;
bool isWorking = false;

Console.WriteLine(number);
Console.WriteLine(totalPrice);
Console.WriteLine(isWorking);
//Instead of declaring variable type, prefix using 'var'. C# will automatically detect datatype
var varNumber = 32;
var varStriing = "example";


/*FORMAT STRING*/
Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

/*IMPLICIT TYPE CONVERSION*/
byte b = 1; //takes 1 byte
int i = b; // take 4 bytes so this will work

/*EXPLICIT TYPE CONVERSION*/
int i = 1; ;
byte b = i; //wont compile and will have data type conversion loss

//prefix with the type you wish to convert to- this is call casting. will still have data loss
float f = 1.0f;
int i = (int)f;

/*NON-COMPATIBLE TYPES*/
string s = "1";
int i = Convert.ToInt32(i);
int j = int.Parse(s);

/*CONVERSION TYPE DEMO*/
static void MainOne(string[] args)
{
    //example 1
    byte b = 1; //byte is 1 byte
    int i = b; //int is 4 byte
    Console.WriteLine(i); // returns 1

    //example 2
    int i = 1000;
    byte i = (byte)i; //will compile to 232 due to dataloss

    //example 3
    var number = "1234";
    int numberConverted = Convert.ToInt32(number);
    Console.WriteLine(numberConverted); // returns 1234

    //example 4
    try
    {
        var number = "12334 ";
        byte b = Convert.ToByte(number);
        Console.WriteLine(b);
    }
    catch (Exception)
    {
        Console.WriteLine("The number could not be converted to a byte.");
    }
}



/*OPERATORS*/

//Post increment
int a = 1;
int b = a++; // b = 2; value of a is assigned to b (1), then a is incremented by 1 (a = 2)

//Prefix increment
int a = 1;
int b = ++a; //a is incremented by 1 (a = 2); value of a is incremented  by 1 (a = 2) 

//Bitwise operators
//Used in windows api, sockets, encryption

/*
 * a&b -> AND
 * a|b -> OR
 */

//example 1
int a = 10;
int b = 3;
Console.WriteLine(a / b); //returns 3 because both are an int. 
Console.WriteLine((float)a / (float)b); //returns 3.3333 

//example 2
int a = 2;
int b = 3;
int c = 3;
Console.WriteLine(a + b * c); // returns 7; behaves on mathematical 
        }
}
