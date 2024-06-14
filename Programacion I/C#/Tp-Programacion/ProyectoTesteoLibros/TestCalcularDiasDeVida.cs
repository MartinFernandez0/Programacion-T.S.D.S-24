using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PDF.Repositories;

namespace ProyectoTesteo
{
    public class TestCalcularDiasDeVida
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testeo1año1mes1dia()
        {
            int diasDeVida = ProgramEjercicios.CalcularDiasDeVida(10, 10, 1);
            Assert.That(diasDeVida, Is.EqualTo(3951));
        }
    }
}
