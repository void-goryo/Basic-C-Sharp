using System;

namespace StudentEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Bill" , LastName = "Bill"};

                ctx.students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student was saved");
            }
        }
    }
}
