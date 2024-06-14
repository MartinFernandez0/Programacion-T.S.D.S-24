using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PDF.Repositories;

namespace ProyectoTesteo
{
    public class TestTriangulos
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquilatero()
        {
            string resultado = ProgramEjercicios.Triangulos(1, 1, 1);
            Assert.That(resultado, Is.EqualTo("Equilatero"));
        }
        [Test]
        public void TestIsóseles()
        {
            string resultado = ProgramEjercicios.Triangulos(1, 1, 3);
            Assert.That(resultado, Is.EqualTo("Isoseles"));
        }
        [Test]
        public void TestEscaleno()
        {
            string resultado = ProgramEjercicios.Triangulos(1, 2, 3);
            Assert.That(resultado, Is.EqualTo("Escaleno"));
        }
    }
}
