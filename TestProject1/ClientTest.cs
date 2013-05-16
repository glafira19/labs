using SampleProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Это класс теста для ClientTest, в котором должны
    ///находиться все модульные тесты ClientTest
    ///</summary>
    [TestClass()]
    public class ClientTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


       
        /// <summary>
        ///Тест для ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string name = "name"; // TODO: инициализация подходящего значения
            int initialCash = 1; // TODO: инициализация подходящего значения
            Client target = new Client(name, initialCash); // TODO: инициализация подходящего значения
            string expected = "name (1)"; // TODO: инициализация подходящего значения
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Тест для Конструктор Client
        ///</summary>
        [TestMethod()]
        public void ClientConstructorTest()
        {
            string name = "imya"; // TODO: инициализация подходящего значения
            int initialCash = 10; // TODO: инициализация подходящего значения
            Client target = new Client(name, initialCash);
            Assert.AreEqual("imya", target.Name);
            int actual = target.Account.Balance;
            Assert.AreEqual(initialCash, actual);
        }
    }
}
