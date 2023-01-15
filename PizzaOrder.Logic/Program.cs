using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Pizza
{
    public double PizzaPrice { get; set; } = Ingredient.Dough.Price;
    public int rating=0;

    List<Ingredient> PizzaIngredients = new List<Ingredient>()
    {
        Ingredient.Dough
    };

    public Pizza(List<Ingredient> pizzaIngredients)
    {
        
        foreach (var ingredient in pizzaIngredients )
        {
            PizzaIngredients.Add(ingredient);
            PizzaPrice += ingredient.Price;
        }
    }
    
    public Pizza( Ingredient pizzaIngredient)
    {
       
            PizzaIngredients.Add(pizzaIngredient);
            PizzaPrice += pizzaIngredient.Price;
        
    }

    
    public double AddIngredient( Ingredient ingredient)
    {

        this.PizzaIngredients.Add(ingredient);
        this.PizzaPrice += ingredient.Price;
        return this.PizzaPrice;
    }

    public double RemoveIngredient(Ingredient ingredient)
    {

        this.PizzaIngredients.Remove(ingredient);
        this.PizzaPrice -= ingredient.Price;
        return this.PizzaPrice;
    }

    static void Main()
    {

    }

}


public class Menu
{
  
    public Pizza Margarita = new Pizza( new List<Ingredient>() { Ingredient.Cheese, Ingredient.Tomato });
    public Pizza Peperoni = new Pizza(new List<Ingredient>() { Ingredient.Cheese, Ingredient.Tomato, Ingredient.Peperoni });
    public Pizza Mozarella = new Pizza(new List<Ingredient>() { Ingredient.Mozarella, Ingredient.Tomato, Ingredient.Peperoni });
    public Pizza Vegetarian = new Pizza(new List<Ingredient>() { Ingredient.Tomato, Ingredient.Olives ,Ingredient.Salad});

    public List<Pizza> SortByRating(List<Pizza> pizzas)
    {
        //var pizzas2 = from pizza in pizzas
        //            orderby pizza.rating descending
        //            select pizza;
        //pizzas.Clear(); 
        //foreach(var pizza in pizzas2)
        //{
        //    pizzas.Add(pizza);  
        //}

        pizzas.Sort((p1, p2) => p1.rating.CompareTo(p2.rating));
        pizzas.Reverse();
        return pizzas;
    }
}
public class Order
{
    List<Pizza> orders = new List<Pizza>();
    double price = 0;
    //add
    public void PizzaAddToOrder(Pizza pizza)
    {
        this.orders.Add(pizza);
        this.price+= pizza.PizzaPrice;
        pizza.rating++;
    }

    //remove
    public void PizzaRemoveFromOrder(Pizza pizza)
    {
        this.orders.Remove(pizza);
        this.price -= pizza.PizzaPrice;
        pizza.rating--;
    }

  

}

public class Ingredient
{
    public static readonly Ingredient Dough = new Ingredient("Dough", 10);
    public static readonly Ingredient Peperoni = new Ingredient("Peperoni", 1);
    public static readonly Ingredient Onion = new Ingredient("Onion", 2);
    public static readonly Ingredient Cheese = new Ingredient("Cheese", 3);
    public static readonly Ingredient Tomato = new Ingredient("Tomato",5);
    public static readonly Ingredient Mushrooms = new Ingredient("Mushrooms", 7);
    public static readonly Ingredient Mozarella = new Ingredient("Mozarella", 15);
    public static readonly Ingredient Peper = new Ingredient("Peper", 12);
    public static readonly Ingredient Salad = new Ingredient("Salad", 17);
    public static readonly Ingredient Salmon = new Ingredient("Salmon", 17);
    public static readonly Ingredient Olives = new Ingredient("Olives", 12);
    string Name { get; }
    public double Price { get; }
    public Ingredient(string name, double price)
    {
        Name = name;
        Price = price;
    }
}









