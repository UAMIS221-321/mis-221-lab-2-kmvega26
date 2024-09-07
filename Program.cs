// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

double costOfSandwich = 4.75;
double costOfTopping = 0.55;
double discountAmount = 0.10;

Console.Write("How many sandwiches would you like to order: ");
int numberOfSandwiches = Convert.ToInt32(Console.ReadLine());

Console.Write("How many toppings would you like: ");
int numberOfToppings = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your desired tip amount in decimal form: ");
double tipAmount = Convert.ToDouble(Console.ReadLine());


double totalSandwichCost = costOfSandwich * numberOfSandwiches;

double totalToppingCost = costOfTopping * numberOfToppings;

double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tipAmount + baseCost * (1 - discountAmount);

double roundedOrderCost = Math.Round(orderCost, 2);

Console.WriteLine("Your total is $" + roundedOrderCost);









