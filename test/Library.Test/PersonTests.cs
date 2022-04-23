using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person Nicolas;
        [SetUp]
        public void Setup()
        {
            Nicolas = new Person("Nicolás Lozano","5.554.976-8");
        }
        /*
        Test que verifica que no se cambie la cedula si esta es invalida
        */
        [Test]
        public void Test_cedulaInvalida() 
        {
            string Expected_ID = Nicolas.ID;
            Nicolas.ID = "5.554.456-1";
            Assert.AreEqual(Nicolas.ID,Expected_ID);
        }
        /*
        Test que verifica que cambie la cedula si es valida
        */
        [Test]
        public void Test_cedulaValida() 
        {
            string Expected_ID = "5.554.975-2";
            Nicolas.ID = Expected_ID;
            Assert.AreEqual(Nicolas.ID,Expected_ID);
        }   
        /*
        Test que verifica que cambie el nombre si es valido
        */
        [Test]
        public void Test_nombreValido() 
        {
            string Expected_Name = "Frodo Bolsón";
            Nicolas.Name = Expected_Name;
            Assert.AreEqual(Nicolas.Name,Expected_Name);
        }
        /*
        Test que verifica que no se cambie el nombre si es vacío
        */
        [Test]
        public void Test_nombreVacio() 
        {
            string Expected_Name = Nicolas.Name;
            Nicolas.Name = "";
            Assert.AreEqual(Nicolas.Name,Expected_Name);
        }
    }
}
