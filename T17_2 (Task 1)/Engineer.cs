using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2__Task_1_
{
    class Engineer : Staff
    {
        /// <summary>
        /// Developed projects
        /// </summary>
        protected int n;
        /// <summary>
        /// Properties
        /// </summary>
        public int N { get => (n > 0)? n : 0; set => n = value; }
        /// <summary>
        /// Consturctors
        /// </summary>
        public Engineer() { }
        public Engineer(string surname, string name, double p, double k, int n) : base(surname, name, p, k)
        {
            this.n = n;
        }
        /// <summary>
        /// Recalculation income
        /// </summary>
        /// <returns>New income</returns>
        public override double Income() 
        {
            if (n > 10) { return base.Income() * (base.Income() / 10); }
            else { return base.Income(); }
        }
        /// <summary>
        /// Output
        /// </summary>
        public override void Output() { base.Output(); WriteLine($"Developed projects: {N}\nIncome: {Income()}"); }
        /// <summary>
        /// Input
        /// </summary>
        /// <returns>Input info</returns>
        public static Engineer Input()
        {
            Write("Enter the surname: ");
            string surname = ReadLine();
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the minimal salary: ");
            double p = Convert.ToDouble(ReadLine());
            Write("Enter the increasing coefficient: ");
            double k = Convert.ToDouble(ReadLine());
            Write("Enter the number of developed projects: ");
            int n = Convert.ToInt32(ReadLine());
            return new Engineer(surname, name, p, k, n);
        }


    }
}
