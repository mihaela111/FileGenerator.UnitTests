using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WindowsFormsApp1.UnitTests
{
    [TestClass]
    public class LeafTests
    {
    [TestMethod]
    public void SetText_validInput_returnExpectedString()
        {
            string ExpectedString = "TesSetTextLeaf";
            Leaf leaf = new Leaf("TestLeaf");
            leaf.SetText("TesSetTextLeaf");

            string actualString = leaf.ReturnText();
            Assert.AreEqual(ExpectedString, actualString);


        }



        [TestMethod]
        public void ReturnText_validInput_returnExpectedString()
        {
            string ExpectedString = "TestLeaf";
            Leaf leaf = new Leaf("TestLeaf");
;

            string actualString = leaf.ReturnText();
            Assert.AreEqual(ExpectedString, actualString);


        }
    }
}
