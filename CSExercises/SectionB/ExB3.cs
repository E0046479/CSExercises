using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the salary!");
            string salary = Console.ReadLine();
            string netSalary = CalculateIncome(salary);
            Console.WriteLine("The total net salary for {0} salary is {1}", salary, netSalary);
        }

        public static string CalculateIncome(string salaryStr)
        {
            double salary = Convert.ToDouble(salaryStr);
            double housingAllowance = salary * 0.1;
            double traspotationAllowance = salary * 0.03;
            double netSalary = salary + housingAllowance + traspotationAllowance;
            string netSalaryString = String.Format("{0:C}", netSalary);
            return netSalaryString;
        }
    }
}
 