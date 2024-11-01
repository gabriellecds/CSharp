using Students.Entities;
using System.IO;

HashSet<StudentRecord> set = new HashSet<StudentRecord>(); 

Console.Write("How many students for course A? ");
int a = int.Parse(Console.ReadLine());

for(int i = 0; i < a; i++)
{
    int code = int.Parse(Console.ReadLine());
    set.Add(new StudentRecord { Code = code });
}

Console.Write("How many students for course B? ");
int b = int.Parse(Console.ReadLine());

for (int i = 0; i < b; i++)
{
    int code = int.Parse(Console.ReadLine());
    set.Add(new StudentRecord { Code = code });
}

Console.Write("How many students for course C? ");
int c = int.Parse(Console.ReadLine());

for (int i = 0; i < c; i++)
{
    int code = int.Parse(Console.ReadLine());
    set.Add(new StudentRecord { Code = code });
}

Console.WriteLine("Total Students: " + set.Count);


