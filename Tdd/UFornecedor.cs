using NUnit.Framework;
using TddConsole.Models;

namespace Tdd
{
    public class UFornecedor
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ValidaMetodoStaticDeUmList()
        {
            Assert.IsNotNull(Fornecedor.Todos());

        }

    }

}
