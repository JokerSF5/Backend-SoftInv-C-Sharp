﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftInvBusiness;


namespace SoftinvTest
{
    [TestClass]
    public class SoftInvBOTest
    {
        private AlmacenBO almacenBO;

        public SoftInvBOTest()
        {
            this.almacenBO = new AlmacenBO();
        }

        [TestMethod]
        public void TestInsertar()
        {
            /*
            Console.WriteLine("Insertar");
            int resultado = this.almacenBO.Insertar("Mi almacen central", true);
            Assert.IsTrue(resultado > 0);

            resultado = this.almacenBO.Insertar("Mi segundo almacén", false);
            Assert.IsTrue(resultado > 0);

            resultado = this.almacenBO.Insertar("Mi tercer almacén", false);
            Assert.IsTrue(resultado > 0);
            */
        }
    }
}
