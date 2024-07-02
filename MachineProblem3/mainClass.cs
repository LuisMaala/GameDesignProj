/*
    Luis Andrei E. Maala
    TX22
    Machine Problem 3
 */
using System;

namespace MachineProblem3
{
    internal class MainClass
    {
        static void Main()
        {
            Student student = new Student("", 0, ""); // Instantiation

            while (true)
            {
                try
                {
                    GetStudentInfo(student);

                    Console.WriteLine("\nStudent Information:");
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Year Level: {student.YearLevel}");
                    Console.WriteLine($"Course: {student.Course}");

                    if (!PromptForAnotherEntry())
                        break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void GetStudentInfo(Student student)
        {
            student.Name = GetValidName();
            student.YearLevel = GetValidYearLevel();
            student.Course = GetValidCourse();
        }

        static string GetValidName() // Checks if the name input is correct
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    foreach (char x in name)
                    {
                        if (!((x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z') || x == ' '))
                        {
                            throw new ArgumentException("Incorrect Name!!!");
                        }
                    }
                    return name;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static int GetValidYearLevel() // Checks if the year level input is correct
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Year Level: ");
                    int yearLevel = int.Parse(Console.ReadLine());
                    if (yearLevel < 1 || yearLevel > 5)
                    {
                        throw new ArgumentException("Incorrect Year Level!!!");
                    }
                    return yearLevel;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static string GetValidCourse() // Checks if the course is correct
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Course: ");
                    string course = Console.ReadLine();
                    if (course != "BSIT" && course != "BSCS" && course != "BSCpE" && course != "BSEE" && course != "BSME")
                    {
                        throw new ArgumentException("Incorrect Course!!!");
                    }
                    return course;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static bool PromptForAnotherEntry() // Checks if the user want to input another Student Info
        {
            while (true)
            {
                try
                {
                    Console.Write("\nDo you want to enter another Student info? Y/N: ");
                    char input = char.Parse(Console.ReadLine());

                    if (input == 'N' || input == 'n')
                    {
                        return false;
                    }
                    else if (input == 'Y' || input == 'y')
                    {
                        Console.WriteLine("\n");
                        return true;
                    }
                    else
                    {
                        throw new Exception("Invalid Input only do Y/N!!!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}