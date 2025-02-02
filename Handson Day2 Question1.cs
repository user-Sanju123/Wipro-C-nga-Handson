using System;

class Marks
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

            Console.Write($"Enter marks for student {i + 1}: ");
            string[] inputMarks = Console.ReadLine().Split();

            for (int j = 0; j < subjects; j++)
            {
                marks[i][j] = int.Parse(inputMarks[j]); // Store marks
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
