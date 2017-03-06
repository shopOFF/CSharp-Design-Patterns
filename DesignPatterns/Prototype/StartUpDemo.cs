using Prototype.Models;
using System;

namespace Prototype
{
    /// <summary>
    /// Prototype Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            Developer dev = new Developer();
            dev.Name = "Johnny";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Asparuh";
            devCopy.Role = "Software Architect";

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monty";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sancho";
            typistCopy.Role = "Junior Typist";
            typistCopy.WordsPerMinute = 95;

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }
    }
}
