using System;
using Bakery.Models;

class Program
{
  // -------------------------------- Start App Items ---------------------------------
  static void Main()
  {
    Console.WriteLine("Welcome to my virtual Bakery!");
    Console.WriteLine("Bread is $5 per loaf, with a buy 2 get one free deal.");
    Console.WriteLine("Pastries are $2 each, with a buy 3 get one free deal.");
    Console.WriteLine("Would you like to start an order? enter 'y' for yes and 'n' for no.");

    string shop = Console.ReadLine();

    if (shop == "y" || shop == "Y")
    {
      Console.WriteLine("Great! Let's get started.");
      CreateOrder();
    }
    else
    {
      Console.WriteLine("Thanks for stopping by! See you soon!");
    }
  }

  // ---------------------------------  Create Entire Order  ---------------------------------

  static void CreateOrder()
  {
    int breadOrder = OrderItems("bread");
    int pastryOrder = OrderItems("pastry");

    Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastry, is that right? Enter 'y' for yes and 'n' to enter new values.");

    string order = Console.ReadLine();

    if (order == "y" || order == "Y")
    {
      Bread newBread = new Bread(breadOrder);
      Pastry newPastry = new Pastry(pastryOrder);
      Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
      Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");
      Console.WriteLine("Thank you for shopping at the Virtual Bakery!");
    }
    else if (order == "n" || order == "N")
    {
      Console.WriteLine("No problem, let's try again!");
      Console.WriteLine("Which item would you like to adjust? Enter 'b' for bread and 'p' for pastry.");
      string itemToAdjust = Console.ReadLine();

      if (itemToAdjust == "b" || itemToAdjust == "B")
      {
        breadOrder = AdjustItemOrder("bread", breadOrder);
      }
      else if (itemToAdjust == "p" || itemToAdjust == "P")
      {
        pastryOrder = AdjustItemOrder("pastry", pastryOrder);
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter 'b' for bread or 'p' for pastry.");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter 'y' to confirm or 'n' to try again.");

      string confirmChange = Console.ReadLine();

      if (confirmChange == "y" || confirmChange == "Y")
      {
        Console.WriteLine("Great! Let's build your order.");
        CreateOrder();
      }
      else
      {
        Console.WriteLine("Hmm. Let's try again.");
        Console.WriteLine("Which item would you like to adjust? Enter 'b' for bread and 'p' for pastry.");
        string itemToAdjust = Console.ReadLine();

        if (itemToAdjust == "b" || itemToAdjust == "B")
        {
          breadOrder = AdjustItemOrder("bread", breadOrder);
        }
        else if (itemToAdjust == "p" || itemToAdjust == "P")
        {
          pastryOrder = AdjustItemOrder("pastry", pastryOrder);
        }
        else
        {
          Console.WriteLine("Invalid input. Please enter 'b' for bread or 'p' for pastry.");
        }
      }
    }
  }

  // -------------------------------- Order Individual Items ---------------------------------

  static int OrderItems(string itemName)
  {
    Console.WriteLine($"How many orders of {itemName} would you like?");
    if (int.TryParse(Console.ReadLine(), out int orderQuantity) && orderQuantity > 0)
    {
      Console.WriteLine($"So you want to order {orderQuantity} {itemName}. Write 'y' to confirm or 'n' to try again.");
      string confirmation = Console.ReadLine();

      if (confirmation == "y" || confirmation == "Y")
      {
        Console.WriteLine($"Got it!");
        return orderQuantity;
      }
      else if (confirmation == "n" || confirmation == "N")
      {
        Console.WriteLine("Let's try again!");
        return OrderItems(itemName);
      }
      else
      {
        Console.WriteLine("Invaild input. Please enter 'y' to confirm or 'n' to try again.");
        return OrderItems(itemName);
      }
    }
    else
    {
      Console.WriteLine($"Invalid {itemName} input. Please enter a number above 0.");
      return OrderItems(itemName);
    }
  }


  // -------------------------------- Adjust Individual Items ---------------------------------

  static int AdjustItemOrder(string itemName, int currentQuantity)
  {
    Console.WriteLine($"Current quantity of {itemName}: {currentQuantity}");
    Console.WriteLine($"Enter the new quantity of {itemName} or '0' to keep it unchanged:");

    if (int.TryParse(Console.ReadLine(), out int newQuantity) && newQuantity >= 0)
    {
      Console.WriteLine($"Adjusted {itemName} quantity to: {newQuantity}");
      return newQuantity;
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a non-negative number.");
      return AdjustItemOrder(itemName, currentQuantity);
    }
  }
}
}




//     Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastries, is that right? Enter 'y' for yes and 'n' to enter new values.");

//     string order = Console.ReadLine();

//     if (order == "y" || order == "Y")
//     {

//       Pastry newPastry = new Pastry(pastryOrder);
//       Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
//       Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");
//       Console.WriteLine("Thank you for shopping at the Virtual Bakery!");
//     }
//     else
//     {
//       Console.WriteLine("No problem, let's try again!");
//       Console.WriteLine("Which order would you like to change? Enter B for bread and 'P' for pastry.");
//       string change = Console.ReadLine();
//       if (change == "B" || change == "b")
//       {
//         breadOrder = OrderBread();
//       }
//       else if (change == "P" || change == "p")
//       {
//         pastryOrder = OrderPastry();
//       }
//       else
//       {
//         Console.WriteLine("Please enter a vaild response.");
//         Console.WriteLine("Which order would you like to change? Enter B for bread and 'P' for pastry.");
//       }
//     }
//   }
// }

// static int OrderBread()
// {
//   Console.WriteLine("How many loaves of bread would you like to order?");
//   if (int.TryParse(Console.ReadLine(), out int breadOrder) && breadOrder > 0)
//   {
//     Console.WriteLine($"You ordered {breadOrder} loaves of bread.");
//     return breadOrder;
//   }
//   else
//   {
//     Console.WriteLine("Invalid bread input. Please enter a number above 0.");
//     return OrderBread();
//   }
// }
// static int OrderPastry()
// {
//   Console.WriteLine("How many pastries would you like to order?");
//   if (int.TryParse(Console.ReadLine(), out int pastryOrder) && pastryOrder > 0)
//   {
//     Console.WriteLine($"You ordered {pastryOrder} pastries.");
//     return pastryOrder;
//   }
//   else
//   {
//     Console.WriteLine("Invalid pastry input. Please enter a number above 0.");
//     return OrderPastry();
//   }
// }
// }


// ----------------------------------------------------

//   static void OrderBakeryItems()
//   {
//     Console.WriteLine("How many loaves of bread would you like to order?");
//     if (int.TryParse(Console.ReadLine(), out int breadOrder) && breadOrder > 0)
//     {
//       Bread newBread = new Bread(breadOrder);

//       Console.WriteLine("How many pastries would you like to order?");
//       if (int.TryParse(Console.ReadLine(), out int pastryOrder) && pastryOrder > 0)
//       {
//         Pastry newPastry = new Pastry(pastryOrder);

//         Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastries, is that right? Enter 'y' for yes and 'n' to enter new values.");

//         string order = Console.ReadLine();

//         if (order == "y" || order == "Y")
//         {
//           Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
//           Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");
//           Console.WriteLine("Thank you for shopping at the Virtual Bakery!");
//         }
//         else
//         {
//           Console.WriteLine("No worries! Let's try again.");
//           OrderBakeryItems();
//         }
//       }
//       else
//       {
//         Console.WriteLine("Invalid pastry input. Please enter a number greater than 0.");
//         OrderBakeryItems();
//       }
//     }
//     else
//     {
//       Console.WriteLine("Invalid bread input. Please enter a number greater than 0.");
//       OrderBakeryItems();
//     }
//   }
// }