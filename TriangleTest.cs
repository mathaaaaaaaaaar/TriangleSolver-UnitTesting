using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class EquilateralTriangleTest
    {
        [Test]
        public void EquilateralTriangleUnitTestCase()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Equilateral triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class IsoscelesTriangleTest
    {
        [Test]
        public void IsoscelesTriangleUnitTestCaseOne()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 50;
            int secondSide = 65;
            int thirdSide = 65;

            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsoscelesTriangleUnitTestCaseTwo()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 50;
            int secondSide = 50;
            int thirdSide = 80;

            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsoscelesTriangleUnitTestCaseThree()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 55;
            int secondSide = 70;
            int thirdSide = 55;

            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class ScaleneTriangleTest
    {
        [Test]
        public void ScaleneTriangleUnitTestCaseOne()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 70;
            int secondSide = 30;
            int thirdSide = 80;

            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ScaleneTriangleUnitTestCaseTwo()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 40;

            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ScaleneTriangleUnitTestCaseThree()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 60;
            int secondSide = 55;
            int thirdSide = 65;

            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ScaleneTriangleUnitTestCaseFour()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 45;
            int secondSide = 80;
            int thirdSide = 55;

            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ScaleneTriangleUnitTestCaseFive()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 65;
            int secondSide = 80;
            int thirdSide = 35;

            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class TriangleWithSideLengthZeroTest
    {
        [Test]
        public void SideEqualsZeroUnitTestCaseOne()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 0;
            int secondSide = 90;
            int thirdSide = 90;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SideEqualsZeroUnitTestCaseTwo()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 90;
            int secondSide = 0;
            int thirdSide = 90;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SideEqualsZeroUnitTestCaseThree()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 90;
            int secondSide = 90;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class InvalidTriangleTest
    {
        [Test]
        public void InvalidTriangleUnitTestCaseOne()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 100;
            int secondSide = 90;
            int thirdSide = 190;

            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InvalidTriangleUnitTestCaseTwo()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 50;
            int secondSide = 10;
            int thirdSide = 150;

            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InvalidTriangleUnitTestCaseThree()
        {
            // The test is in the A-A-A format
            // Arrange
            int firstSide = 90;
            int secondSide = 20;
            int thirdSide = 120;

            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
