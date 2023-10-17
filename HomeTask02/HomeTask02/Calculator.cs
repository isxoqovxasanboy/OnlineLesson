namespace HomeTask02
{
    public class Calculator
    {
        public static int GetAddNumbers(params int[] numbers)
        {
            int sum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }
            return sum;
        }

    }
}
