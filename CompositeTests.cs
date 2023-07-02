using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WindowsFormsApp1.UnitTests
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void SetText_validInput_returnExpectedString()
        {
            string ExpectedString = "TestComposite";
            Composite composite = new Composite("TestComposite");


            string actualString = composite.ReturnText();
            Assert.AreEqual(ExpectedString, actualString);


        }
    }
}




