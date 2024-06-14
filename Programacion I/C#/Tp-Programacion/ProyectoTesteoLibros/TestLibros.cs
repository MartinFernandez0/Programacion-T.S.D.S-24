using Newtonsoft.Json;
using System.Text;
using System;
using TP_PDF.Repositories;
using TP_PDF.Models;

namespace ProyectoTesteo
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libros = await librosRepository.ObtenerLibrosAsync();
            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.AgregarAsync("LibroTest2", "autoTest2", 100, "EditorialTest2", "SinopsisTest2", "PortadaURLTest2","GeneroURL2");
            Assert.That(libro.nombre, Is.EqualTo("LibroTest2"));
        }
        [Test]
        public async Task TestEliminarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var borrado = await librosRepository.EliminarAsync("665a256169e958000003eda7");
            Assert.That(borrado, Is.EqualTo(true));
        }
        [Test]
        public async Task TestObtenerLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.ObtenerPorIdAsync("64e65869a1ce3020000d2446");
            Assert.That(libro.nombre, Is.EqualTo("Harry Potter y la cámara secreta"));
        }
        [Test]
        public async Task TestActualizarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.ActualizarAsync("LibroTest2Actualizado", "autoTest2", 100, "EditorialTest2", "SinopsisTest2", "PortadaURLTest2", "GeneroURL2", "665a258e69e958000003edaa");
            Assert.That(libro.nombre, Is.EqualTo("LibroTest2Actualizado"));
        }
    }
}