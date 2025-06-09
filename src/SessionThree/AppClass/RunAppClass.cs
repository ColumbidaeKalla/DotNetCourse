// Removed unused using directive
namespace DotNetCourse.src.SessionThree.AppClass;

using DotNetCourse.src.SessionThree.AppClass;
using System;

public static class RunAppClass {
    public static void RunAnimal() {
        Animal dog = new Animal (name: "Golden", species: "Nice", age: 5);
        Console.WriteLine($"Dog was {dog.Age} years old");
        dog.Age = 10;
        Console.WriteLine($"Dog is {dog.Age} years old after update\n");
        dog.AnimalDerails();
        dog.MakeSound();
        dog.MakeSound(animalName: "Labrador");
    }
        public static void RunMusic(){
            Music nepali = new Music();
            Music english = new();

            nepali.Artist = "Laure";
            nepali.Genre = "Hiphop";
            nepali.Title = "Mero Solta";

            nepali.ShowInfo();
            // Add spacing between outputs for better readability
            Console.WriteLine();
            english.ShowInfo();
        }

    public static void RunStudentIndexer()
    {
        StudentIndexer kct = new (5);

        kct[0] = "One";
        kct[1] = "Two";
        kct[2] = "Three";
        kct[3] = "Four";
        kct[4] = "Five";

        for (int i = 0; i < kct.NameList.Length; i++) {
            Console.WriteLine(kct[i]);
        }
    }
}