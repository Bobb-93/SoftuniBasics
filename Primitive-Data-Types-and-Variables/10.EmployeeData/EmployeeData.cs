﻿using System;

class EmployeeData
{
    static void Main()
    {
        string firstName="Amanda";
        string lastName = "Jonson";
        byte age = 27;
        //enum gender {m,f};
        char gender='f';
        ulong personalIDNumber = 8306112507;
        uint uniqueEmployeeNumber = 27563571;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalIDNumber);
        Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);
    }
}
