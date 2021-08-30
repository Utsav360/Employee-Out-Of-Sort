// @ Author Utsavkumar M Patel, Student Number -000820474 ,
// This program was created on the 27th September 2020.
// The primary goal of this program is to display the Employee data as per menus and that involves many methods.

// (Statement of the authorships)
// I, Utsavkumar M Patel , Student Number 000820474 , certify that this material is my original work.
// And No other person's work has been used without due acknowledgement.'





using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    ///  Employee Class
    /// </summary>
    /// 
    public class Employee
    {

        private int number;
        private string name;
        private double hours;
        private decimal gross;
        private decimal rate;


        /// <summary>
        /// Constructor Employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="rate"></param>
        /// <param name="hours"></param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }





        //Getters
        /// <summary>
        /// return name
        /// </summary>
        /// <returns></returns>
        public string GetName() { return name; }

        /// <summary>
        /// return number 
        /// </summary>
        /// <returns></returns>
        
        public int GetNumber() { return number; }

        /// <summary>
        /// return hours
        /// </summary>
        /// <returns></returns>

        public double GetHours() { return hours; }


        /// <summary>
        /// return rate
        /// </summary>
        /// <returns></returns>
        public decimal GetRate() { return rate; }

        //Other Methods
        /// <summary>
        /// return gross as per calculations
        /// </summary>
        /// <returns></returns>
        public decimal GetGross()
        {
            if (GetHours() <= 40)
            {
                
                gross=(decimal)GetHours() * GetRate();
                return gross;
            }

            gross =((decimal)GetHours() * GetRate()) + (((decimal)GetHours() - 40) * GetRate() * (decimal)1.5);
            return gross;
                
        }




        //Setters
        /// <summary>
        /// return name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// return number
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        {
            this.number = number;
        }
        /// <summary>
        /// return hours
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(double hours)
        {
            this.hours = hours;
        }
        /// <summary>
        /// return rate
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(decimal rate)
        {
            this.rate = rate;
        }
        /// <summary>
        /// Method tostring to display the message 
        /// return string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"EmpName:{name} \t Number:{number} \t PayRate:{rate} \t Hours:{hours} \t GrossPay{gross}";
        }

    }
 
}
