using NUnit.Framework;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class Tests
    {
        private Product product;
        private Equipment equipment;
        private Step step;
        private IList<Step> steps;
        

        [SetUp]
        public void Setup()
        {
            this.product = new Product("Café", 100);
            this.equipment = new Equipment("Cafetera", 1000);
            this.step = new Step(product, 100, equipment, 120);
            this.steps = new List<Step>();
            steps.Add(step);


        }

        [Test]
        public void StepIsAdded() // Prueba que si agrega un paso a una lista con un paso, la nueva cantidad de pasos es dos.
        {
           //Act
            steps.Add(step);
           //Assert
            int length = steps.Count;
            Assert.AreEqual(length,2);

        }

         

         



    }
}