namespace BlazorCalculator.Services
{
    public class CalculatorState
    {
        public string CurrentInput { get; set; } = "0";
        public double PreviousValue { get; set; } = 0;
        public string? Operator { get; set; } = null;
        public double Result { get; set; } = 0;
        public string? ProcessCalc { get; set; } = null;
    }
}
