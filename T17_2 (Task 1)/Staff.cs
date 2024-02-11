using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2__Task_1_
{
    class Staff
    {
        /// <summary>
        /// Name and surname
        /// </summary>
        protected string surname;
        protected string name;
        /// <summary>
        /// Minimal salary
        /// </summary>
        protected double p;
        /// <summary>
        /// Increasing coefficient
        /// </summary>
        protected double k;
        /// <summary>
        /// Properties
        /// </summary>
        public string Surname { get => (surname != "" && surname != " ")? surname : "None"; set => surname = value; }
        public string Name { get => (name != "" && name != " ")? name : "None"; set => name = value; }
        public double P { get => (p > 0)? p : 0; set => p = value; }
        public double K { get => (k > 0) ? k : 0; set => k = value; }
        /// <summary>
        /// Constr. without parameters
        /// </summary>
        public Staff() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="surname">Initializing surname</param>
        /// <param name="name">Initializing name</param>
        /// <param name="p">Initializing minimal salary</param>
        /// <param name="k">Initializing increasing coefficient</param>
        public Staff(string surname, string name, double p, double k)
        {
            this.Surname = surname; this.Name = name; this.P = p; this.K = k;
        }
        /// <summary>
        /// Calculating income
        /// </summary>
        /// <returns>Income</returns>
        public virtual double Income() { return k * p; }
        /// <summary>
        /// Output
        /// </summary>
        public virtual void Output() { WriteLine($"Surname: {Surname}\nName: {Name}\nMinimal salary: {P}\nIncreasing coefficient: {K}"); }
    }
}
