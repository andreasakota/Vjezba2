namespace Comparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Ivo", 4.1),
                new Student("Ana", 4.9),
                new Student("Iva", 4.3),
                new Student("Bob", 4.5),
                new Student("Joe", 4.7)
            };

            Console.WriteLine("Before:");
            DisplayArray(students);

            Bubble.Sort(students, Student.CompareName);
            Console.WriteLine("\nArray sorted by name:");
            DisplayArray(students);

            Bubble.Sort(students, Student.CompareGrade);
            Console.WriteLine("\nArray sorted by grade:");
            DisplayArray(students);

        }

        static void DisplayArray(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
