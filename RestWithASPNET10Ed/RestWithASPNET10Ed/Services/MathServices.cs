namespace RestWithASPNET10Ed.Services {
    public class MathServices {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;
        public decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;
        public decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;
        public decimal Division(decimal firstNumber, decimal secondNumber) {
            if (secondNumber == 0) throw new DivideByZeroException("Division by zero not allowed");
            return firstNumber / secondNumber;
        }
        public double SquareRoot(decimal number) {
            if (number < 0) throw new ArgumentOutOfRangeException("Cannot calculete a square root of a negative number");
            return Math.Sqrt((double) number);
        }
    }
}
