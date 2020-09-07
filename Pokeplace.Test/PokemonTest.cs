using NUnit.Framework;
using Pokeplace.Core;
using System.Linq;

namespace Pokeplace.Test
{
    public class PokemonTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var model = Pokemon.FetchById(2);
            Assert.Pass();
        }
    }
}