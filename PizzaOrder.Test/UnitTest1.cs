using Xunit;
using System;
namespace PizzaTest

{
    public class PizzaTest
    {
        [Fact]
        public void AddIngredient_ReturnList()
        {


            //Ingredient ingredient1 = new Ingredient("Peperoni", 1);
            Pizza pizza = new Pizza(Ingredient.Onion);
            //Ingredient ingredient2 = new Ingredient("Tomato", 2);
            // Ingredient ingredient3 = new Ingredient("Onion", 3);
            // Ingredient ingredient4 = new Ingredient("Cheese", 4);
            // pizza.AddIngredient(ingredient1);
            pizza.AddIngredient( Ingredient.Peperoni);
            pizza.AddIngredient( Ingredient.Cheese);

            var expected = 6;
            Assert.Equal(expected, pizza.PizzaPrice);

        }
    }
}



