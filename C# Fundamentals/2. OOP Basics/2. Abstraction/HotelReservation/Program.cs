using System;

namespace HotelReservation {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine(PriceCalculator.Calculate(10, 5, Season.Summer, Discount.SecondVisit));
        }
    }
}