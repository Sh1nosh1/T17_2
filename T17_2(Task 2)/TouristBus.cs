using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_Task_2_
{
    class TouristBus : Bus
    {
        /// <summary>
        /// Tour price
        /// </summary>
        private double tour_price;
        /// <summary>
        /// Properties
        /// </summary>
        protected double Tour_price { get => (tour_price > 0)? tour_price : 0; set => tour_price = value; }
        /// <summary>
        /// Constructors
        /// </summary>
        public TouristBus() { }
        public TouristBus(string mark, int seats, double price, double tour_price) : base(mark, seats, price)
        {
            this.Tour_price = tour_price;
        }
        /// <summary>
        /// Recalculating cost
        /// </summary>
        /// <returns>Cost</returns>
        public override double TotalCost()
        {
            if (tour_price > 0) { return base.TotalCost() * tour_price; }
            else { return base.TotalCost(); }
        }
        /// <summary>
        /// Output
        /// </summary>
        public override void Output()
        {
            base.Output();
            WriteLine($"Tour price: {Tour_price}\nCost: {TotalCost()}");
        }
        /// <summary>
        /// Input
        /// </summary>
        /// <returns>Input info</returns>
        public static TouristBus Input()
        {
            Write("Enter the mark: ");
            string mark = ReadLine();
            Write("Enter the number of seats: ");
            int seats = Convert.ToInt32(ReadLine());
            Write("Enter the price for 1 seat: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the tour price: ");
            double tour_price = Convert.ToDouble(ReadLine());
            return new TouristBus(mark, seats, price, tour_price);
        }

    }
}
