using SampleProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Это класс теста для AccountTest, в котором должны
    ///находиться все модульные тесты AccountTest
    ///</summary>
    [TestClass()]
    public class AccountTest
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
        ///Тест для AddMoney
        ///</summary>
        [TestMethod()]
        public void AddMoneyTest()
        {
            int initialCash = 100; // TODO: инициализация подходящего значения
            Account target = new Account(initialCash); // TODO: инициализация подходящего значения
            int amount = 100; // TODO: инициализация подходящего значения
            int transactionID = 1; // TODO: инициализация подходящего значения
            target.AddMoney(amount, transactionID);
            Assert.AreEqual(200, target.Balance);
        }

        /// <summary>
        ///Тест для AddMoney
        ///</summary>
        [TestMethod()]
        public void AddMoneyTest1()
        {
            int initialCash = 100; // TODO: инициализация подходящего значения
            Account target = new Account(initialCash); // TODO: инициализация подходящего значения
            int amount = 100; // TODO: инициализация подходящего значения
            int transactionID = 0; // TODO: инициализация подходящего значения
           
            try
            {
                target.AddMoney(amount, transactionID);
                Assert.Fail("Wrong transaction ID");
            }

            catch
            {
                
            }         
        }

        /// <summary>
        ///Тест для Конструктор Account
        ///</summary>
        [TestMethod()]
        public void AccountConstructorTest()
        {
            int initialCash = 10; // TODO: инициализация подходящего значения
            Account target = new Account(initialCash);
            Assert.AreEqual(10, target.Balance);
          
        }
    } 
}
