using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q4CsvParser.Web.Core;

namespace Q4CsvParser.Test.Unit
{
    /// <summary>
    /// This class should have content. 
    /// Feel free to use any testing framework you desire. (i.e. NUnit, XUnit, Microsoft built-in testing framework)
    /// You may also use a mocking framework (i.e. Moq, RhinoMock)
    /// 
    /// If you've never done unit testing before, don't worry about this section and look to complete some of the bonus mark tasks
    /// </summary>

    [TestClass]
    public class ParsingServiceTest
    {
        //TODO Unit test the ParsingService here
        [TestMethod, TestCategory("Parsing")]
        public void parsing_empty_should_return_false()
        {
            var p = new ParsingService();
            var s = p.ParseCsv("", false);
            Assert.IsFalse(s == null);
        }
        [TestMethod, TestCategory("Parsing")]
        public void parsing_should_return_true()
        {
            var p = new ParsingService();
            var s = p.ParseCsv("Id,Name\r\n1,Art\r\n2,Language\r\n3,Math\r\n4,Gym\r\n5,Science\r\n", true);
            Assert.IsFalse(s == null);
        }
    }

}
