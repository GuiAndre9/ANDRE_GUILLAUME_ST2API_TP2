using static System.ComponentModel.DateTimeConverter;
using System;
using System.Collections.Generic;
using System.Net.Http;
using ClassLibrary1;
using Newtonsoft.Json;


namespace ClassLibrary1

public class QuestionsTest
{
    static void Main(string[] args)
    {
        using ClassLibrary1;
        
        // Question 1
        Api Weather = new Api();

        Console.WriteLine("What's the weather like in Morocco ? \n");
        City q1 = new City("morocco");
        Root quest1 = Weather.Request(q1);
        Console.WriteLine(quest1[0]);

        // Question 2
        Console.WriteLine("When will the sun rise and set today in Oslo* (in readable, UTC time)?");
        City q2 = new City("oslo");
        Root quest2 = Weather.Request(q2);
        Console.WriteLine(quest2);

        // Question 3
        Console.WriteLine("What’s the temperature in Jakarta* (in Celsius)?");
        City q3 = new City("jakarta");
        Root quest3 = Weather.Request(q3);
        Console.WriteLine(quest3);

        // Question 4
        Console.WriteLine("Where is it more windy, New-York*, Tokyo* or Paris*?");

        // Question 5
        Console.WriteLine("What is the humidity and pressure like in Kiev*, Moscow* and Berlin*?");
}

}