using Entity.dbo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WBL;
using Xunit.Sdk;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public IEnumerable<ServicioEntity> ListService { get; set; } = new List<ServicioEntity>();
        public abstract IServicioService GetService();


        [TestMethod]
        public void TestMethod1()
        {

            IServicioService  getService = GetService();

            var lista = getService.GET();




            //ListService = (IEnumerable<ServicioEntity>)servicioService.GET();


            Console.WriteLine(string.Join("\t", lista));

            //Assert.IsNotNull(ListService);

        }
    }
}
