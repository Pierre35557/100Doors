using NUnit.Framework;
using System.Collections.Generic;

namespace _100Doors
{
    [TestFixture]
    public class _100DoorsTest
    {
        [Test]
        public void Given100Doors_And1stPass_100DoorsShouldBeOpen()
        {
            //Arrange
            var round = 1;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_And2ndPass_50DoorsShouldBeOpen()
        {
            //Arrange
            var round = 2;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#@#";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_AndThirdPass_49DoorsShouldBeOpen()
        {
            //Arrange
            var round = 3;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###@@@###";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_AndFourthPass_58DoorsShouldBeOpen()
        {
            //Arrange
            var round = 4;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@@@@@##@#@##@";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_AndFifthPass_52DoorsShouldBeOpen()
        {
            //Arrange
            var round = 5;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@##@#@@@#@@#@#@@@@@###@####@@#@@####@###@@@@@#@#@@#@@@#@##@@@##@#@@@#@@#@#@@@@@###@####@@#@@####@###";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_AndSixthPass_54DoorsShouldBeOpen()
        {
            //Arrange
            var round = 6;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@##@##@@#@@@@#@@@#@###@@###@@@@@###@@###@#@@@#@@@@#@@##@##@#@##@##@@#@@@@#@@@#@###@@###@@@@@###@@###";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given100Doors_AndHundredthPass_ShouldOpen10Doors()
        {
            //Arrange
            var round = 100;

            var sut = new Doors();

            //Act
            var actual = sut.Open(round);
            var expected = "@##@####@######@########@##########@############@##############@################@##################@";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Doors
    {
        public string Open(int round)
        {
            var doors = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                doors.Add("@");
            }

            //Start looping at second round. First round will always return all open doors.
            for (int i = 2; i <= round; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    if (j % i == 0)
                    {
                        doors[j - 1] = doors[j - 1] == "@" ? "#" : "@";
                    }
                }
            }

            return string.Join("", doors);
        }
    }
}
