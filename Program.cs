// Task check the order history for order IDs containing B as the first string letter
/* These are the order IDs we'd be using for this exercise
B123
C234
A345
C15
B177
G3003
C235
B179 */


string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

string[] fraudulentOrderIDs = new string [orderIDs.Length];

int bin = 0;

foreach (string items in orderIDs)
{
    if (items.Contains("B"))
    {
        fraudulentOrderIDs[bin] = items;
        Console.WriteLine($"Fraudulent OrderID: {items}");
        bin++;
    }
}


// Task: take inventory of company product in inventory, finished and ready to be shipped out


// int[] inventory = { 200, 450, 700, 175, 250 };

// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running Total: {sum})");
// }

// Console.WriteLine($"We have {sum} in the inventory");








// task: reviewing customer purchase to detect fraud


// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs ={ "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent activites to process");









// // improve renewal rate of subscriptions


// //display a renewal message when a user logs in

// // notify the user their subscription will soon end

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired");
// }

// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }

// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription Expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }

// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine($"Your subscription will expire soon {daysUntilExpiration}. Renew now");
//     discountPercentage = 0;
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%!");
// }



// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }