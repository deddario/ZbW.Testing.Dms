using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZbW.Testing.Dms.Client.UnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void CmdLogin_CantLogin_ReturnsTrue()
        {
            // arrange
            var onCmdLogin = new LoginTest();
            //var persistanceService = new PersistanceService(fileAnalyzerStub);

            // act
            var result = new MainView(Benutzername);
            // assert
            Assert.IsFalse(result);
        }
    }
}
