using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            double suma;
            double mediaEsperada; ;


            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);


            for (int i = 0; i < notas.Count; i++)
            {
                suma = suma + notas[i];
            }

            mediaEsperada = mediaEsperada / notas.Count;




            
            int susE = 3;
            int aprE = 1;
            int notE = 2;
            int sbrE = 1;
        }
    }
}
