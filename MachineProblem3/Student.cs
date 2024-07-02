/*
    Luis Andrei E. Maala
    TX22
    Machine Problem 3
 */
using System;

namespace MachineProblem3
{
    internal class Student // Class Declaration
    {
        string name;       // Class Properties
        int yearLevel;
        string course;

        public Student(string name, int yearLevel, string course) // Student Constructors
        {
            this.name = name;
            this.yearLevel = yearLevel;
            this.course = course;
        }

        // Setters and Getters for the Stud Properties
        public string Name 
        {
            set
            {
                foreach (char x in value)
                {
                    if (!((x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z') || x == ' '))
                    {
                        throw new ArgumentException();
                    }
                }
                name = value;
            }
            get 
            { 
                return name;
            }
        }

        public int YearLevel
        {
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException();
                }
                yearLevel = value;
            }
            get 
            {
                return yearLevel; 
            }
        }

        public string Course
        {
            set
            {
                if (value != "BSIT" && value != "BSCS" && value != "BSCpE" && value != "BSEE" && value != "BSME")
                {
                    throw new ArgumentException();
                }
                course = value;
            }
            get 
            { 
                return course; 
            }
        }
    }
}