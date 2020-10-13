using NUnit.Framework;
using TddConsole.Models;

namespace Tdd
{
    public class UCliente
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarPropriedadesDeUmCliente()
        {
            var cliente = new Cliente();

            Assert.IsNull(cliente.Id);
            Assert.IsNull(cliente.Nome);
            Assert.IsNull(cliente.Sobrenome);
        }
    }
}