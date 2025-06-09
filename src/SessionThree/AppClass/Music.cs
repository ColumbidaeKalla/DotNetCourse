namespace DotNetCourse.src.SessionThree.AppClass;

using System;

public class Music {
    // Properties
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public string? Artist { get; set; }

    // Constructor
    public Music() {
        Console.WriteLine("Inside 'Music' default constructor\n");
    }

    // Method to show info
    public void ShowInfo() {
        Console.WriteLine("Music Info");
        Console.WriteLine(
            $"Title: {Title?.Trim() ?? "N/A"} | Type: {Title?.GetType().Name ?? "Unknown"}\n" +
            $"Genre: {Genre?.Trim() ?? "N/A"} | Type: {Genre?.GetType().Name ?? "Unknown"}\n" +
            $"Artist: {Artist?.Trim() ?? "N/A"} | Type: {Artist?.GetType().Name ?? "Unknown"}"
        );
    }
}

// namespace InnerSpace
// {
//     public class Movie{}
//     public class School{}
// }
