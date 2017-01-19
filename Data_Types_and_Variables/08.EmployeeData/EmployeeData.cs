using System;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName =Console.ReadLine();
            string lastName = Console.ReadLine();
            byte аgе = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong IDnumber = ulong.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\r\n"+
                $"Last name: {lastName}\r\n"+
                $"Age: {аgе}\r\n" +
                $"Gender: {gender}\r\n" +
                $"Personal ID: {IDnumber}\r\n" +
                $"Unique Employee number: {employeeNumber}");
        }
    }
}
