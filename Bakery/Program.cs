using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PackerTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();

      app.UseRouting();
      app.UseStaticFiles();
      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}

// using System;
// using Bakery.Models;

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("Welcome to my virtual Bakery!");
//     Console.WriteLine("Bread is $5 per loaf, with a buy 2 get one free deal.");
//     Console.WriteLine("Pastries are $2 per treat, with a buy 3 get one free deal.");
//     Console.WriteLine("Would you like to start an order? enter 'y' for yes and 'n' for no.");

//     string shop = Console.ReadLine();

//     if (shop == "y" || shop == "Y")
//     {
//       Console.WriteLine("Great! Let's get started.");
//       OrderBakeryItems();
//     }
//     else
//     {
//       Console.WriteLine("Thanks for stopping by! See you soon!");
//     }
//   }

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
//      {
//       Console.WriteLine("Invalid bread input. Please enter a number greater than 0.");
//       OrderBakeryItems();
//     }
//   }
// }