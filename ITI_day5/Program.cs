using System;
namespace ITI_day5
{


    class Student
    {
        string name;
        int age;
        int ssn;
        string phone;
        public Student(string n,int a,int s,string p) 
        {
            
            name = n;
            age = a;
            ssn = s;
            phone = p;
        }
        public void print()
        {
            Console.WriteLine
                ($@"
                    Student Data
                    Name: {name}
                    Age: {age}
                    SSN: {ssn}
                    phone: {phone}
                    "
                );
        }
    }
    internal class Program
    {

       
        static void Main(string[] args)
        {


            #region task_1

            //Console.Write("Enter number...");
            //int num = int.Parse(Console.ReadLine());



            //Console.WriteLine($"===[{num}] Multiplication table===\n\n");
            //for (int i =0; i <= num; ++i) 
            //{
            //    Console.WriteLine($"{i+1}==>{i} * {num} = {i*num}");
            //    Console.WriteLine("------------------");

            //}
            //Console.WriteLine("=======================");


            #endregion


            #region task_2

            //Console.WriteLine("Hi Employee:)");



            //Console.Write("Enter Your name...");
            //string name = Console.ReadLine();

            //Console.Write("Enter Your ID...");
            //int id = int.Parse(Console.ReadLine());

            //Console.Write("Enter Your age...");
            //int age;
            //do
            //{
            //    age = int.Parse(Console.ReadLine());
            //    if (age < 1)
            //        Console.Write("age must be greater then 0...");

            //} while (age < 1);

            //Console.Write("Enter Your salary...");
            //int salary;
            //do
            //{
            //    salary = int.Parse(Console.ReadLine());
            //    if (age < 1)
            //        Console.Write("salary must be greater then 0...");

            //} while (salary < 1);


            //Console.WriteLine
            //    ($@"
            //        ==================
            //        Employee Name: {name}
            //        Employee ID: {id}
            //        Employee age: {age}   
            //        Employee salary: {salary}
            //        ====================

            //     "
            //    );

            #endregion

            #region oop
            //Student s1 = new Student("sami", 10, 51564,"01062899011");
            //Student s2 = new Student("abdo", 15, 55451564,"01140073200");


            //s1.print();
            //s2.print();

            #endregion







        }
    }
}






