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


            var expected = 16;
            Assert.Equal(expected, pizza.PizzaPrice);

        }

        [Fact]
        public void RemoveIngredient_ReturnList()
        {

            Pizza pizza = new Pizza(Ingredient.Onion);
            pizza.AddIngredient(Ingredient.Peperoni);
            pizza.AddIngredient(Ingredient.Cheese);
            pizza.RemoveIngredient(Ingredient.Peperoni);
    


            var expected = 15;
            Assert.Equal(expected, pizza.PizzaPrice);

        }

        [Fact]
        public void CheckOrderAdd_ReturnPrice()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Margarita"));


            var expected = 18;
            Assert.Equal(expected, order.price);
        }

        [Fact]
        public void CheckOrderDel_ReturnPrice()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Margarita"));
            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));
            order.PizzaRemoveFromOrder(menu.GetPizza("Peperoni"));

            var expected = 18;
            Assert.Equal(expected, order.price);
        }

        [Fact]
        public void CheckOrder_ReturnRating()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));
           

            var expected = 1;
            Assert.Equal(expected, menu.GetPizza("Peperoni").rating);
        }

        [Fact]
        public void CheckSort_ReturnPizza()
        {
            Menu menu = new Menu();
            Order order = new Order();

            order.PizzaAddToOrder(menu.GetPizza("Peperoni"));

            var expected = "Peperoni";
            Assert.Equal(expected, menu.SortByRating(menu).First().Name);
        }
    }
}



