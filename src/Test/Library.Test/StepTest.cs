using NUnit.Framework;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class StepTests
    {
        private Product producto;
        private double cantidad;
        private Equipment equipamiento;
        private int tiempo;
        private Step step;

        [SetUp]
        public void Setup()
        {
            this.producto = new Product("Mezcla", 20);
            this.cantidad = 2;
            this.equipamiento = new Equipment("batidora",5);
            this.tiempo = 15;
            this.step = new Step( producto ,cantidad ,equipamiento ,tiempo);

        }

        [Test]
        public void GetStepCost_Works() // Prueba que GetStepCost calcula bien el valor de step.
        {
            double finalStepCost = (producto.UnitCost * this.cantidad) + (equipamiento.HourlyCost * this.tiempo);

            Assert.AreEqual(step.GetStepCost(), finalStepCost);
        }

         

         



    }
}