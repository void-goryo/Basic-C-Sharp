using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //arrays
        int[] numArray = new int[5]; //makes an array    [length]    also creates an object

        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };    //does the same thing as the first array.

        int[] numArray2 = { 5, 2, 10, 200, 5000 };              //same thing as the first and second array.

        numArray2[4] = 650;                                     //you can change the numbers of the array, but not the size.

        //byte[] byteArray = new byte[5000];                      Used to store images


        Console.WriteLine(numArray2[1]);
        Console.WriteLine(numArray1[2]);
        Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray2[4]);
        Console.ReadLine();

        //lists
        List<int> intList = new List<int>();                    //you will use this more often. you can change size and adjust variables easier
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Gabe");
        stringList.Add("Tyler");

        Console.WriteLine(stringList[0]);
        Console.ReadLine();

        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}