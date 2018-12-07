using System;

namespace ClassBox {
    class Program {
        static void Main(string[] args) {
            try {
                Box box = InitializeBox();
                System.Console.WriteLine(box);
            } catch (System.Exception ex) {

                System.Console.WriteLine(ex.Message);
            }
        }
        static Box InitializeBox() {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return new Box(length, width, height);
        }
    }
}