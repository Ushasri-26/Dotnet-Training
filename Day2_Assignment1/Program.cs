using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2_Assignment1
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        public override string ToString() => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }

    internal class Program
    {
        static readonly Dictionary<int, Student> students = new Dictionary<int, Student>
        {
            [1] = new Student { Name = "Usha sri", Class = "10A", TotalMarks = 555, Gender = 'F' },
            [2] = new Student { Name = "Uday Kiran", Class = "9B", TotalMarks = 400, Gender = 'M' },
            [3] = new Student { Name = "Bhavya", Class = "8C", TotalMarks = 523, Gender = 'F' },
            [4] = new Student { Name = "Satwik", Class = "10B", TotalMarks = 358, Gender = 'M' },
            [5] = new Student { Name = "Anurag", Class = "10A", TotalMarks = 576, Gender = 'M' },
        };

        static void Print(string text) => Console.WriteLine(text);

        static async Task Main(string[] args)
        {
            try
            {
                Print("Show All Students");
                await ShowAllStudents();

                Print("\n Get Student by id = 2");
                var s1 = await GetStudentAsync(2);
                Print($"Result: {s1}");

                Print("\n Get student by id = 3 (total marks < 300 triggers exception/when filter)");
                var s2 = await GetStudentAsync(3);
                Print($"Result: {s2}");

                Print("\n Get student with no id passed (default details)");
                var sDefault = await GetStudentAsync();
                Print($"Result: {sDefault}");
            }
            catch (Exception ex)
            {
                await Task.Delay(50);
                Print($"Unhandled exception in Main: {ex.Message}");
            }
        }

        public static async Task ShowAllStudents()
        {
            try
            {
                foreach (var kvp in students)
                {
                    Print($"Id: {kvp.Key} => {kvp.Value}");
                }
            }
            catch (Exception ex)
            {
                await Task.Delay(50);
                Print($"Error while showing students: {ex.Message}");
            }
        }

        public static async Task<Student> GetStudentAsync(int id)
        {
            try
            {
                await Task.Delay(50);

                if (students.TryGetValue(id, out var student))
                {
                    if (student.TotalMarks < 300)
                    {
                        throw new Exception("Total marks less than 500");
                    }

                    return student;
                }
                else
                {
                    Print($"Student with id {id} not found. Returning default student.");
                    return GetDefaultStudent();
                }
            }
            catch (Exception ex) when (ex.Message.Contains("less than 500"))
            {
                await Task.Delay(50);
                Print($"Caught a low-marks exception for id={id}: {ex.Message}");
                return students.TryGetValue(id, out var st) ? st : GetDefaultStudent();
            }
            catch (Exception ex)
            {
                await Task.Delay(50);
                Print($"General error in GetStudentAsync({id}): {ex.Message}");
                return GetDefaultStudent();
            }
        }

        public static async Task<Student> GetStudentAsync()
        {
            try
            {
                await Task.Delay(30);
                Print("No id passed — returning default student details.");
                return GetDefaultStudent();
            }
            catch (Exception ex)
            {
                await Task.Delay(50);
                Print($"Error in GetStudentAsync(): {ex.Message}");
                return GetDefaultStudent();
            }
        }

        static Student GetDefaultStudent() =>
            new Student
            {
                Name = "Default Student",
                Class = "N/A",
                TotalMarks = 0,
                Gender = 'U'
            };
    }
}