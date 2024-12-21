namespace Assigment_05
{
    internal class Program
    {
        // Q1 
        static void IncrementByReference(ref int number)
        {
            number++; 
        }
        /*
         * When a value type is passed by reference, a reference to the original variable is passed to the method.
            Changes made to the parameter inside the method affect the original value outside the method.
         */
        static void ModifyObjectByValue(Student student)
        {
            student.Name = "John"; // Changes the original object
            student = new Student { Name = "Alice" }; // Only changes the local reference
        }
        class Student
        {
            public string Name { get; set; }
        }
        static void Calculate(int num1, int num2, out int summation, out int subtraction)
        {
            summation = num1 + num2; // Calculate summation
            subtraction = num1 - num2; // Calculate subtraction
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;

            // Loop to extract and add each digit
            while (number != 0)
            {
                sum += number % 10; // Get the last digit
                number /= 10;       // Remove the last digit
            }

            return sum;
        }
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            // Initialize min and max with the first element of the array
            min = arr[0];
            max = arr[0];

            // Iterate through the array to find min and max
            foreach (int num in arr)
            {
                if (num < min)
                    min = num; // Update minimum
                if (num > max)
                    max = num; // Update maximum
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            //int originalNumber = 10;
            //IncrementByReference(ref originalNumber);
            //Console.WriteLine("Original number after passing by reference: " + originalNumber);
            #endregion

            #region Q2
            //Student student = new Student { Name = "Tom" };
            //ModifyObjectByValue(student);
            //Console.WriteLine("Student name after passing by value: " + student.Name);
            /*
             * A copy of the reference to the object is passed to the method.
            Changes made to the object itself inside the method will affect the original object because both the original variable and the parameter point to the same object.
            Reassigning the parameter (changing what it points to) will not affect the original reference.
             */
            #endregion

            #region Q3
            //Console.Write("Enter Your First Number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter YOur  Second Number : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int sum, subtract;
            //Calculate(number1, number2, out sum, out subtract);



            //Console.WriteLine("Summation: " );
            //Console.WriteLine(sum);
            //Console.WriteLine("Subtraction: " );
            //Console.WriteLine(subtract);
            #endregion


            #region Q4 
            Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = SumOfDigits(Math.Abs(number)); 

            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            #endregion

            #region Q6
            //int[] numbers = { 104, 3, 100, 2, 55, -10, 8 };
            //int min = 0, max = 0;

            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine("Array: " + string.Join(", ", numbers));
            //Console.WriteLine("Minimum value " );
            //Console.WriteLine(min);
            //Console.WriteLine("Maximum value" );
            //Console.WriteLine(max);
            #endregion


        }
    }
}
