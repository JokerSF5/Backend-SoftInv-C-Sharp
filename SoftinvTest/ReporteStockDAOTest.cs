using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftInvPersistance.DAO;
using SoftInvPersistance.DAOImpl;

namespace SoftinvTest
{
    [TestClass]
    public class ReporteStockDAOTest
    {


        private ReporteStockDAO reporteStockDAO;

        public ReporteStockDAOTest()
        {
            this.reporteStockDAO = new ReporteStockDAOImpl();
        }

        [TestMethod]
        public void testListarPorPeriodo()
        {

            System.Console.WriteLine("Listar por periodo");
            this.reporteStockDAO.insertarDatosDePrueba();
            this.reporteStockDAO.generarReporteStock(2025, 1);
            this.reporteStockDAO.generarReporteStock(2025, 2);
            this.reporteStockDAO.generarReporteStock(2025, 3);

            this.reporteStockDAO.eliminarDatosDePrueba();
        }

    }
}
