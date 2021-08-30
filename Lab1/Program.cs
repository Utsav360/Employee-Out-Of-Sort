// @ Author Utsavkumar M Patel, Student Number -000820474 ,
// This program was created on the 27th September 2020.
// The primary goal of this program is to display the Employee data as per menus and that involves many methods.

// (Statement of the authorships)
// I, Utsavkumar M Patel , Student Number 000820474 , certify that this material is my original work.
// And No other person's work has been used without due acknowledgement.'



using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Class Program  (View of the Program)
    ///
    /// </summary>
    class Program
    {
        
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" THIS PROGRAM WAS CREARED BY UTSAVKUMAR M PATEL (000820474).\n\n");
            Console.WriteLine("L I S T  O F  E M P L O Y E E S\n" +
                              "===================================================================================================\n");

            Employee[] employees = new Employee[100];
            employees = Read("employee.csv");
            

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
               
                if ( emp == null)
                {
                    Console.WriteLine("This is null value , Please enter the proper value.");
                    Console.ReadLine();
                    
                }
                
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Hit Enter or Something to Continue ...  ");
            Console.ReadLine();
                    

            Boolean running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine(" PLEASE SELECT FROM THE FOLLOWING SIX OPTIONS...\n" +
                                  "1 - SORT BY EMPLOYEE NAME      (ASCENDING ORDER)\n" +
                                  "2 - SORT BY EMPLOYEE NUMBER    (ASCENING ORDER)\n" +
                                  "3 - SORT BY EMPLOYEE PAY RATE  (DESCENDING ORDER)\n" +
                                  "4 - SORT BY EMPLOYEE HOURS     (DESCENDING ORDER)\n" +
                                  "5 - SORT BY EMPLOYEE GROSS PAY (DESCENDING ORD)\n" +
                                  "6 - EXIT !\n\n" +
                                  "Enter Option: ");
                int option = int.Parse(Console.ReadLine());

                //Switch Case Options with call the methods as per the choice of options 
                switch (option)
                {
                    case 1:

                        SelectionSort(employees ,option);
                        
                        break;
                    case 2:

                        SelectionSort(employees, option);
                        break;
                        
                    case 3:
                        SelectionSort(employees, option);
                        break;
                    case 4:
                        SelectionSort(employees, option);
                        break;
                    case 5:
                        SelectionSort(employees, option);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine(" This is the Invalid!! Choose Valid options.");
                        break;
                       

                }

            }

        }


      

        /// <summary>
        /// Selection Sort method to sort the array of Employee.
        /// Show the output with the choice of 
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="option"></param>
        public static void SelectionSort(Employee[] employees ,int option)
        {
            int x, y, min_x;

            if (option == 1)
            {

                for (x = 0; x < (employees.Length) - 1; x++)
                {

                    min_x = x;
                    for (y = x + 1; y < employees.Length; y++)
                        if (employees[y].GetName().CompareTo(employees[min_x].GetName()) < 0)
                            min_x = y;

                    
                    Employee temp = employees[min_x];
                    employees[min_x] = employees[x];
                    employees[x] = temp;
                }
                foreach (var i in employees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("Please Hit Something to Goto Main Menu Or Enter 6 to Exit..");
                Console.ReadLine();
                
            }

            // Option 2 Selection 
            else if(option ==2 ){

                for (x = 0; x < (employees.Length) - 1; x++)
                {
                    min_x = x;
                    for (y = x + 1; y < employees.Length; y++)
                        if (employees[y].GetNumber().CompareTo(employees[min_x].GetNumber()) < 0)
                            min_x = y;

                 
                    Employee temp = employees[min_x];
                    employees[min_x] = employees[x];
                    employees[x] = temp;
                }
                foreach (var i in employees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("Please Hit Something to Goto Main Menu ...");
                Console.ReadLine();
                

            }
            //Option 3 Selection 
            else if (option == 3)
            {

                for (x = 0; x < (employees.Length) - 1; x++)
                {
                    min_x = x;
                    for (y = x + 1; y < employees.Length; y++)
                        if (employees[y].GetRate().CompareTo(employees[min_x].GetRate()) > 0)
                            min_x = y;

                    Employee temp = employees[min_x];
                    employees[min_x] = employees[x];
                    employees[x] = temp;
                }
                foreach (var i in employees)
                
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("Please Hit Something to Goto Main Menu ...");
                Console.ReadLine();
                
            }
            //Option 4 Selection 
            else if (option == 4)
            {

                for (x = 0; x < (employees.Length) - 1; x++)
                {
                    min_x = x;
                    for (y = x + 1; y < employees.Length; y++)
                        if (employees[y].GetHours().CompareTo(employees[min_x].GetHours()) > 0)
                            min_x = y;


                    Employee temp = employees[min_x];
                    employees[min_x] = employees[x];
                    employees[x] = temp;
                }
                foreach (var i in employees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("Please Hit Something to Goto Main Menu ...");
                Console.ReadLine();
                
            }
            //Option 5 Selection 
            else if (option == 5)
            {

                for (x = 0; x < (employees.Length) - 1; x++)
                {
                    min_x = x;
                    for (y = x + 1; y < employees.Length; y++)
                        if (employees[y].GetGross().CompareTo(employees[min_x].GetGross()) > 0)
                            min_x = y;

                    //swap(&Array[min_x], &Array[x]);
                    Employee temp = employees[min_x];
                    employees[min_x] = employees[x];
                    employees[x] = temp;
                }
                foreach (var i in employees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("Please Hit Something to Goto Main Menu ...");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU ENTERED THE INCORRECT COMMAND!!..PLEASE TRY ONE MORE TIME ...");
                Console.ReadLine();
                

            }

        }

       
        /// <summary>
        /// Read method to read the array and store it  in the array Employee.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Employee[] Read(string fileName)
        {
            Employee[] employees = new Employee[100];
            int count = 0;

            try
            {
                StreamReader reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {

                    // 2. Split line into fields using the String.Split method
                    string[] items = reader.ReadLine().Split(',');
                    // Need to specify the delimeter

                    // 3. Create a Car object with the 4 properties. You will need to convert
                    // the last three properties to Double using the Parse method.
                    employees[count] = new Employee(items[0].Trim(), int.Parse(items[1].Trim()), decimal.Parse(items[2].Trim()), double.Parse(items[3].Trim()));
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                // Will return the employee Array to Main
                Array.Resize(ref employees, count);
                return employees;
           
        }


    }
}
