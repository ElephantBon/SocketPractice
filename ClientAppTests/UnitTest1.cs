using ClientApp;
using ClientApp.NetTools;
using NSubstitute;

namespace ClientAppTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("127.0.0.1", "8000", "test.txt", @"D:\Downloads\", true)]
        [InlineData("127.0.0.1", "8001", "test.txt", @"D:\Downloads\", false)]
        [InlineData("127.0.0.1", "abcd", "test.txt", @"D:\Downloads\", false)]
        [InlineData("127.0.0.1", "8000", "test.txt", @"H:\Downloads\", false)]
        public void DownloadFileTest_ReturnBool(string serverIP, string serverPort, string requestFileName, string saveFilePath, bool expected)
        {
            // arrange
            var nsubSocketHelperMock = Substitute.For<SocketHelperMock>();
            var sut = new FormClientViewModel(nsubSocketHelperMock);

            // act
            var actual = sut.DownloadFile(serverIP, serverPort, requestFileName, saveFilePath);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("127.0.0.1", 8000, true)]
        [InlineData("127.0.0.1", 8001, false)]
        public void SocketHelperConnectTest_ReturnBool(string serverIP, int serverPort, bool expected)
        {
            // arrange
            var sut = new SocketHelperMock();

            // act
            var actual = sut.Connect(serverIP, serverPort);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}