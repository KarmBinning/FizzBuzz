using FizzBuzzCalculator;
using NUnit.Framework;
using System;

namespace FizzBuzzTests
{
    [TestFixture]
	public class Tests {
		private FizzBuzzCalc m_calc;

		[SetUp]
		public void SetUpCalculator() {
			m_calc = new FizzBuzzCalc();
		}

		[TestCase]
		public void FizzBuzzCalc_WhenInputIs1_Returns1() {
			Assert.AreEqual( "1", m_calc.ToString( 1 ) );
		}

		[Test]
		public void FizzBuzzCalc_WhenInputIs2_Returns2() {
			Assert.AreEqual( "2", m_calc.ToString( 2 ) );
		}
		[Test]
		public void FizzBuzzCalc_WhenInputIs3_ReturnFizz() {
		Assert.AreEqual("Fizz", m_calc.ToString(3));
		}
		[Test]
		public void FizzBuzzCalc_WhenInputIs5_ReturnBuzz() {
			Assert.AreEqual( "Buzz", m_calc.ToString( 5 ) );
		}
		[Test]
		public void FizzBuzzCalc_WhenInputIs5Times3_ReturnFizzBuzz() {
			Assert.AreEqual( "Fizz Buzz", m_calc.ToString( 15 ) );
		}

		[Test]
		public void FizzBuzzCalc_WhenInputIsZero_ThrowsArgumentException() {
			Assert.Throws<ArgumentException>( () => m_calc.ToString( 0 ) );
		}
	}
}
