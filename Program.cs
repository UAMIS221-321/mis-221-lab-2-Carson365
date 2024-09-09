const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

static double getValue(string item) // Asks for the number of {item}s until a valid number in entered. Will accept non-whole numbers of toppings or tips.
{
	Console.WriteLine($"How many {item}?");
	double x;
	// try to read a line as a double. In the case of an invalid input, notify the user and prompt again until a valid input is given.
	while (!double.TryParse(Console.ReadLine(), out x)) { Console.WriteLine("Invalid input. Try again."); Console.WriteLine($"How many {item}?"); }
	return x;
}

// 1-discount percent gives the amount of the total that was charged. The pre-discount total is calculated by multiplying the number of sandwiches/toppings by their cost.
// Tips are added after the discount, and then the total is financially rounded to two decimal places. 
Console.WriteLine($"Total: ${Math.Round((1 - DISCOUNT_AMOUNT) * ((getValue("sandwiches") * COST_OF_SANDWICH) + (getValue("toppings") * COST_OF_TOPPING)) + getValue("tips"), 2, MidpointRounding.AwayFromZero)}");