using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PDF.Repositories;

namespace ProyectoTesteo
{
    public class TestFotoMonster
    {
        private FotosMonsterRepository fotosMonsterRepository;

        [SetUp]
        public void Setup()
        {
            // Configuracion Repositorio
            fotosMonsterRepository = new FotosMonsterRepository();
        }
        [Test]
        public async Task TestObtenerFotos()
        {
            var fotos = await fotosMonsterRepository.ObtenerFotosMonsterAsync();
            Assert.That(fotos.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestAgregarFotoMonster()
        {
            var foto = await fotosMonsterRepository.AgregarFotosMonsterAsync("Martinddd", "22/04/2003", "https://ruta/a/imagen/de/prueba.jpg", "Viajesssssss");
            Assert.That(foto.nombre, Is.EqualTo("Martinddd"));
        }
        [Test]
        public async Task TestEliminarFotoMonster()
        {
            var borrado = await fotosMonsterRepository.EliminarFotosMonsterAsync("66611f4ecdf88b1400001eb6");
            Assert.That(borrado, Is.EqualTo(true));
        }
        [Test]
        public async Task TestObtenerPorIdFotosMonster()
        {
            var foto = await fotosMonsterRepository.ObtenerPorIdFotosMonsterAsync("666102accdf88b1400001cb4");
            Assert.That(foto.nombre, Is.EqualTo("Viaje a Brazil"));
        }
        [Test]
        public async Task TestActualizarFotoMonster()
        {
            var foto = await fotosMonsterRepository.ActualizarFotosMonsterAsync("Martinnn Act","22/03/2000","https://ruta/a/imagen/de/prueba.jpg", "Viajesssssss", "66612145cdf88b1400001ed9");
            Assert.That(foto.nombre, Is.EqualTo("Martinnn Act"));
        }
    }
}
