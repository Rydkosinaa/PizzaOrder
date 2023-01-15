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
    }
}



