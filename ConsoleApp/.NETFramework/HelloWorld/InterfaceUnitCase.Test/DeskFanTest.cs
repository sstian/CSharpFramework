using Xunit;
using Moq;

namespace InterfaceUnitCase.Test {
    public class DeskFanTest {
        [Fact]
        public void PowerLowerThanZero_OK() {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(0);

            var deskFan = new DeskFan(mock.Object);
            var expected = "Won't work.";
            var actual = deskFan.Work();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerHigherThan200_Warning() {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(202);

            var deskFan = new DeskFan(mock.Object);
            Assert.Equal("Warning!", deskFan.Work());
        }
    }

}
