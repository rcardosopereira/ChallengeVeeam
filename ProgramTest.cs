using NUnit.Framework;
using System;
using System.IO;

namespace YourNamespace.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void LogToFile_ShouldCreateLogFile()
        {
            // Arrange
            string logFilePath = "testLog.txt";
            string message = "Test message";

            // Act
            //Program.LogToFile(logFilePath, message);

            // Assert
            Assert.Equals(File.Exists(logFilePath), "Log file should have been created.");
            Assert.Equals(File.ReadAllText(logFilePath).Contains(message), "Log file should contain the test message.");
        }

    }
}
