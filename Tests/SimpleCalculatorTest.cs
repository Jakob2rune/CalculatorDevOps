using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 3;
        var b = 3;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    [Test]
    public void multiply()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 3;
        var b = 3;

        // Act
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(9));
    }
    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 3;
        var b = 3;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void isPrime1()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 1;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(false));
    }
    
    [Test]
    public void isPrime2()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }
    [Test]
    public void Factorial_WithZero_ReturnsOne()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 0;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial_WithOne_ReturnsOne()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 1;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial_WithFive_ReturnsOneHundredTwenty()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 5;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Factorial_WithNegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = -3;

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => calc.Factorial(n));
        Assert.That(ex.Message, Is.EqualTo("Factorial is not defined for negative numbers"));
    }

    [Test]
    public void IsPrime_WithOne_ReturnsFalse()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 1;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void IsPrime_WithTwo_ReturnsTrue()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsPrime_WithThree_ReturnsTrue()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 3;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsPrime_WithFour_ReturnsFalse()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 4;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void IsPrime_WithSeventeen_ReturnsTrue()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 17;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsPrime_WithNegativeNumber_ReturnsFalse()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = -5;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.EqualTo(false));
        //test
    }
}