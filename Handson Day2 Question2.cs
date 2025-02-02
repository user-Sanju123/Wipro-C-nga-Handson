//You are given a class of students where each student has appeared in a different number of subjects. You need to store and display their marks using a jagged array in C#.

//using static System.Formats.Asn1.AsnWriter;

//Tasks:
//Take input for the number of students.
//For each student, take input for the number of subjects they have studied.
//Store the marks for each subject in a jagged array.
//Display the marks of each student in a structured format.


using System;

class Program
{
    static void Main()
    {
        // Step 1: Get the number of students
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        // Step 2: Declare a jagged array
        int[][] marks = new int[students][];

        // Step 3: Input marks for each student
        for (int i = 0; i < students; i++)
        {
            Console.Write($"Enter number of subjects for student {i + 1}: ");
            int subjects = int.Parse(Console.ReadLine());

            marks[i] = new int[subjects]; // Allocate array for subjects

            Console.Write($"Enter marks for student {i + 1} (separate by spaces): ");
            string[] inputMarks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputMarks.Length != subjects)
            {
                Console.WriteLine("Error: The number of marks entered does not match the number of subjects.");
                return;
            }

            for (int j = 0; j < subjects; j++)
            {
                if (int.TryParse(inputMarks[j], out int mark))
                {
                    marks[i][j] = mark; // Store marks if parsing is successful
                }
                else
                {
                    Console.WriteLine($"Error: Invalid mark '{inputMarks[j]}' for student {i + 1}. Please enter valid integers.");
                    return;
                }
            }
        }

        // Step 4: Display the stored marks
        Console.WriteLine("\nStudent Marks:");
        for (int i = 0; i < students; i++)
        {
            Console.Write($"Marks of Student {i + 1}: ");
            foreach (var mark in marks[i])
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
