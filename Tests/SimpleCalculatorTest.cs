// using Calculator;
//
// namespace Tests;
//
// public class SimpleCalculatorTest
// {
//     [Test]
//     public void Add()
//     {
//         // Arrange
//         var calc = new SimpleCalculator();
//         var a = 2;
//         var b = 3;
//
//         // Act
//         var result = calc.Add(a, b);
//
//         // Assert
//         Assert.That(result, Is.EqualTo(5));
//     }
//     [Test]
//     public void Subtract()
//     {
//         // Arrange
//         var calc = new SimpleCalculator();
//         var a = 3;
//         var b = 3;
//
//         // Act
//         var result = calc.Subtract(a, b);
//
//         // Assert
//         Assert.That(result, Is.EqualTo(0));
//     }
//     [Test]
//     public void multiply()
//     {
//         // Arrange
//         var calc = new SimpleCalculator();
//         var a = 3;
//         var b = 3;
//
//         // Act
//         var result = calc.Multiply(a, b);
//
//         // Assert
//         Assert.That(result, Is.EqualTo(9));
//     }
//     [Test]
//     public void Divide()
//     {
//         // Arrange
//         var calc = new SimpleCalculator();
//         var a = 3;
//         var b = 3;
//
//         // Act
//         var result = calc.Divide(a, b);
//
//         // Assert
//         Assert.That(result, Is.EqualTo(1));
//     }
//     [Test]
//     public void isPrime()
//     {
//         // Arrange
//         var calc = new SimpleCalculator();
//         var a = 2;
//
//         // Act
//         var result = calc.IsPrime(a);
//
//         // Assert
//         Assert.That(result, Is.EqualTo(true));
//     }
// }