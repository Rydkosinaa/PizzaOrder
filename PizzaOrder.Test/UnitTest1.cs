using Xunit;
using System;
namespace PizzaTest

{
    public class PizzaTest
    {
        [Fact]
        public void AddIngredient_ReturnList()
        {

            Pizza pizza = new Pizza(Ingredient.Onion);
            pizza.AddIngredient( Ingredient.Peperoni);
            pizza.AddIngredient( Ingredient.Cheese);
  
           
            List <Ingredient> expected = new List<Ingredient>() { Ingredient.Dough, Ingredient.Onion, Ingredient.Peperoni, Ingredient.Cheese };

            // 

            Assert.Equal(expected, pizza.PizzaIngredients);

        }

        [Fact]
        public void RemoveIngredient_ReturnList()
        {

            Pizza pizza = new Pizza(Ingredient.Onion);
            pizza.AddIngredient(Ingredient.Peperoni);
            pizza.AddIngredient(Ingredient.Cheese);
            pizza.RemoveIngredient(Ingredient.Peperoni);

            List<Ingredient> expected = new List<Ingredient>() { Ingredient.Dough, Ingredient.Onion, Ingredient.Cheese };


            //
         
            Assert.Equal(expected, pizza.PizzaIngredients);

        }

        [Fact]
        public void CheckOrderAdd_ReturnList()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));


            List<Pizza> expected = new List<Pizza>() { Menu.Peperoni };


            Assert.Equal(expected, order.orders);
        }

        [Fact]
        public void CheckOrderDel_ReturnList()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Margarita"));
            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));
            order.PizzaRemoveFromOrder(menu.GetPizza("Peperoni"));
            List<Pizza> expected = new List<Pizza>() { Menu.Margarita};

           
            Assert.Equal(expected, order.orders);
        }

        [Fact]
        public void CheckOrder_ReturnRating()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));
           

            var expected = 2;
            Assert.Equal(expected, menu.GetPizza("Peperoni").rating);
        }

        [Fact]
        public void CheckSort_ReturnPizza()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));

            var expected = "Peperoni";
            Assert.Equal(expected, menu.SortByRating().First().Name);
        }
    }
}



