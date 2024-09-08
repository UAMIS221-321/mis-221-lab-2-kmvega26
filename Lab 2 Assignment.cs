// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

Console.Write("How many sandwiches would you like to order: ");
int numberOfSandwiches = Convert.ToInt32(Console.ReadLine());

Console.Write("How many toppings would you like: ");
int numberOfToppings = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your desired tip amount in decimal form: ");
double tipAmount = Convert.ToDouble(Console.ReadLine());


double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

double totalToppingCost = COST_OF_TOPPING * numberOfToppings;

double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tipAmount + baseCost * (1 - DISCOUNT_AMOUNT);

double roundedOrderCost = Math.Round(orderCost, 2);

Console.WriteLine("Your total is $" + roundedOrderCost);









