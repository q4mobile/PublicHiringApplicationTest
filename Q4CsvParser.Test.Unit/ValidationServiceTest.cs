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
    public class ValidationServiceTest
    {
        //TODO unit test the ValidationService here
        [TestMethod, TestCategory("Validation")]
        public void IsCsvFile_must_return_true_for_csv()
        {
            var v = new ValidationService();
            var result = v.IsCsvFile("myFile.csv");
            Assert.IsTrue(result);
        }
        [TestMethod, TestCategory("Validation")]
        public void IsCsvFile_must_return_false_for_txt()
        {
            var v = new ValidationService();
            var result = v.IsCsvFile("myFile.txt");
            Assert.IsFalse(result);
        }
        [TestMethod, TestCategory("Validation")]
        public void IsCsvFile_must_return_false_for_file()
        {
            var v = new ValidationService();
            var result = v.IsCsvFile("myFile");
            Assert.IsFalse(result);
        }
    }
}
