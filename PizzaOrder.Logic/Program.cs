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
    public string Name = "Custom pizza";

  public  List<Ingredient> PizzaIngredients = new List<Ingredient>()
    {
        Ingredient.Dough
    };

    public Pizza(List<Ingredient> pizzaIngredients, string name)
    {
        Name = name;
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

    public void AddIngredient( Ingredient ingredient)
    {

        this.PizzaIngredients.Add(ingredient);
        this.PizzaPrice += ingredient.Price;
       
        
    }
   
    public bool RemoveIngredient(Ingredient ingredient)
    {
        this.PizzaPrice -= ingredient.Price;
        return this.PizzaIngredients.Remove(ingredient);
       //this.PizzaIngredients.Remove(ingredient);
        //this.PizzaPrice -= ingredient.Price;
        //return this.PizzaPrice;
    }

    static void Main()
    {

    }

}


public class Menu
{
  
    static public Pizza Margarita = new Pizza( new List<Ingredient>() { Ingredient.Cheese, Ingredient.Tomato }, "Margarita");
    static public Pizza Peperoni = new Pizza(new List<Ingredient>() { Ingredient.Cheese, Ingredient.Tomato, Ingredient.Peperoni }, "Peperoni");
    static public Pizza Mozarella = new Pizza(new List<Ingredient>() { Ingredient.Mozarella, Ingredient.Tomato, Ingredient.Peperoni }, "Mozarella");
    static public Pizza Vegetarian = new Pizza(new List<Ingredient>() { Ingredient.Tomato, Ingredient.Olives ,Ingredient.Salad}, "Vegetarian");

    public List<Pizza> PizzaMenu = new List<Pizza>() { Margarita, Peperoni, Mozarella, Vegetarian };

    public Pizza GetPizza(string name)
    {
        foreach(var p in PizzaMenu)
        {
            if(p.Name == name)
                return p;
        }
        return null;
    }


    public List<Pizza> SortByRating()
    {
        PizzaMenu.Sort((p1, p2) => p2.rating.CompareTo(p1.rating));
        return PizzaMenu;
    }
}
public class Order
{
    public List<Pizza> orders = new List<Pizza>();
    public double price = 0;
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









