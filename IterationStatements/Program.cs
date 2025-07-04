using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Follow the instructions provided in each comment below to complete the exercise.
            // Use the example given to guide your implementation.

            //Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  //DO NOT ERASE THIS! You will use this in the exercise.
            
            //-----START HERE------------------------------------------

            // Create a variable of type int and name it "num" DONE!
            // Initialize the variable with a value of 0 - DONE!

	    int num = 0;



            //TODO - Create a do-while loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1 - DONE!
            // b) Then add "num" to the collection "numbers" - DONE!
            //    Hint: Use "numbers.Add(num);" to add the current value of "num" to the list.
	    do
            {
                num++; // Increment num by 1
                numbers.Add(num); //uncomment out `num` to add it to the collection "numbers"
            } while (num > 100);
	    // - Continue the loop while "num" is less than 100 - DONE!
	    //
            

            //TODO - Create a while loop using the existing brackets as a template.
            //TODO - Continue the loop while "num" is less than 200
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: You can copy how this was done in the do-while loop
	    while (num > 200)
            {
		    numbers.Add(num); // Adding num to the collection of numbers from part b above
		    num++; // Increment num by 1 from part a above
            }
            


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers". DONE!
            foreach (var numb in numbers)
	    {
                Console.WriteLine($"{numb}"); // This line should print each number in the numbers list
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1.

            // a) In your initializer, set the value of "i" to 199. DONE!
            // b) In your conditional, ensure that the loop continues as long as "i" is:
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count"). DONE!
            //    - Greater than or equal to 0. DONE!
            // c) Decrement "i" by 1 in each iteration. DONE!
	    for(int i = 199; i <= numbers.Count || i >= 0; i--)
            {
                // Inside the loop, place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
		
            }

            //------------End of exercise

        }
    }
}
