using NUnit.Framework;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class RecipeTests
    {
        private Product finalProduct;
        private Product granosCafé;
        private Equipment equipment;
        private double quantity;
        private int time;
        private Step step;
        private Recipe recipe;
        

        [SetUp]
        public void Setup()
        {
            this.finalProduct = new Product("Café", 100);
            this.granosCafé = new Product("GranosCafé", 100);
            this.equipment = new Equipment("Cafetera", 1000);
            this.quantity = 100;
            this.time = 120;


            this.step = new Step(granosCafé, quantity, equipment, time);

            this.recipe = new Recipe();
        }

        [Test]
        public void GetProductionCostReturnsRightCalculation() //Prueba que GetProductionCost devuelve el calculo correcto
        {
            double expectedValue = step.GetStepCost() *2;
            recipe.AddStep(step);
            recipe.AddStep(step);
            recipe.FinalProduct = finalProduct;

            Assert.AreEqual(expectedValue, recipe.GetProductionCost());
        }

        [Test]
        public void GetTextToPrintReturnsString() //Prueba si GetTextToPrint devuelve una variable de tipo string
        {
            recipe.AddStep(step);
            recipe.FinalProduct = finalProduct;

            Assert.IsInstanceOf(typeof(string), recipe.GetTextToPrint());
        }

        [Test]
        public void GetTextToPrintIsNotNull() // Prueba que si agrega un paso a una lista con un paso, la nueva cantidad de pasos es dos.
        {
           recipe.AddStep(step);
           recipe.FinalProduct = finalProduct;

           Assert.IsNotNull(recipe.GetTextToPrint());
        }

         

         



    }
}