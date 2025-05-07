using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftInvdbmanager1;
using SoftInvdbmanager1.Db;
using SoftInvdbmanager1.Db.Util;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace SoftinvTest
{
    [TestClass]
    public class DBManagerTest
    {

        [TestMethod]
        public void verPasswordConfig()
        {
            string clave = ConfigurationManager.AppSettings["password"];
            
            System.Console.WriteLine("Clave cifrada: >" + clave + "<");
            string claveDescifrada = DBManager.Descifrar(clave);
            System.Console.WriteLine("Clave desifrada: >" + claveDescifrada + "<");
            string claveCifrada = DBManager.Cifrar(claveDescifrada);
            System.Console.WriteLine("Clave cifrada: >" + claveDescifrada + "<");

            
        }

        [TestMethod]
        public void verPasswordHardcode()
        {
            string clave = "01102003Safp";

            System.Console.WriteLine("Clave no cifrada: >" + clave + "<");
            string claveCifrada = DBManager.Cifrar(clave);
            System.Console.WriteLine("Clave cifrada: >" + claveCifrada + "<");
            string claveDecifrada = DBManager.Cifrar(claveCifrada);
            System.Console.WriteLine("Clave decifrada: >" + claveDecifrada + "<");

            
        }

        [TestMethod]
        public void TestGetInstance()
        {
            Console.WriteLine("GetInstance");
            DBManager dBManager1 = DBManager.Instance;
            DBManager dBManager2 = DBManager.Instance;
            Assert.IsNotNull(dBManager1);
            Assert.IsNotNull(dBManager2);
            Assert.AreEqual(dBManager1, dBManager2);
        }

        [TestMethod]
        public void TestGetConnection()
        {
            Console.WriteLine("GetConnection");
            DbConnection conexion = DBManager.Instance.Connection;
            Assert.IsNotNull(conexion);
            conexion.Open();
        }
    }
}
