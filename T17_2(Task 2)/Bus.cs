using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_Task_2_
{
    class Bus
    {
        /// <summary>
        /// Mark of bus
        /// </summary>
        private string mark;
        /// <summary>
        /// Number of bus seats
        /// </summary>
        private int seats;
        /// <summary>
        /// Price dor 1 seat
        /// </summary>
        private double price;
        /// <summary>
        /// Properties
        /// </summary>
        protected string Mark { get => (mark != "" && mark != " ")? mark : "None"; set => mark = value; }
        protected int Seats { get => (seats > 0)? seats : 0; set => seats = value; }
        protected double Price { get => (price > 0)? price : 0; set => price = value; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Bus() { }
        public Bus(string mark, int seats, double price)
        {
            this.Mark = mark; this.Seats = seats; this.Price = price;
        }
        /// <summary>
        /// Calculating cost
        /// </summary>
        /// <returns>Cost</returns>
        public virtual double TotalCost() { return price * seats; }
        /// <summary>
        /// Output
        /// </summary>
        public virtual void Output()
        {
            WriteLine($"Mark: {Mark}\nNumber of seats: {Seats}\nPrice for 1 seat: {Price}");
        }
    }
}
