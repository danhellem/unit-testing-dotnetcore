using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

using GettingStarted.Code;

namespace GettingStarted.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ColorCordinatorTest
    {
        private ColorCordinator objColorCordinator;

        [TestInitialize]
        public void TestInitialize()
        {
            //Arrange
            objColorCordinator = new ColorCordinator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            objColorCordinator = null;
        }

        //[TestCategory("Unit Test")]
        //[Owner("Team Blue")]
        //[Priority(0)]
        //[TestProperty("My New Test Name", "Hot")]

        [TestMethod]
        public void SuggestMyShirtColor_Red_Equals_Pink()
        {
            //Arrange           

            //Act
            objColorCordinator.suggestMyShirtColor("red");

            //Assert
            Assert.AreEqual("pink", objColorCordinator.shirtColor);
        }

        [TestMethod]
        public void SuggestMyShirtColor_Blue_Equals_Green()
        {
            //Arrange           

            //Act
            objColorCordinator.suggestMyShirtColor("blue");

            //Assert
            Assert.AreEqual("green", objColorCordinator.shirtColor);
        }

        [TestMethod]
        public void SuggestMyShirtColor_Green_Equals_Blue()
        {
            //Arrange          

            //Act
            objColorCordinator.suggestMyShirtColor("green");

            //Assert
            Assert.AreEqual("blue", objColorCordinator.shirtColor);
        }

        [TestMethod]
        //[Ignore]
        public void SuggestMyShirtColor_Pink_Equals_Yellow()
        {
            //Arrange            

            //Act
            objColorCordinator.suggestMyShirtColor("pink");

            //Assert
            Assert.AreEqual("yellow", objColorCordinator.shirtColor);
        }

        [TestMethod]
        public void SuggestMyShirtColor_Gray_Equals_Black()
        {
            //Arrange           

            //Act
            objColorCordinator.suggestMyShirtColor("gray");

            //Assert
            Assert.AreEqual("error", objColorCordinator.shirtColor);
        }
    }
}
