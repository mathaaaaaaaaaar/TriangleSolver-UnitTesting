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
}
