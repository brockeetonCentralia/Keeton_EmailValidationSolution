using Keeton_EmailValidation;
namespace EmailValidatorTest
{
    [TestClass]
    public class EmailTests : TestBase
    {
        [TestMethod]
        public void Empty_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("emptyEmail", " ");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void Username_Over_Char_Limit_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("userNameOverLimit", "thisusernameaboutwillywonkawillbeoverthelimitoverthisusernameaboutwillywonkawillbeoverthelimitoverthelimitoverthelimitoverthelimitover@hotmail.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]

        public void Domain_Over_Char_Limit_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("domainOverLimit", "willywonka@thisdomainnameaboutwillywonkawillbeoverthelimitthisdomainnameaboutwillywonkawillbeoverthelimitthelimitthelimitthelimitthelimitthelimitthelimit.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void Space_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("spaceEmail", "willy wonka@hotmail.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void No_Username_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("noUserName", "@hotmail.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void No_Domain_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("noDomain", "willywonka@com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void No_Dot_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("noDotEmail", "willywonka@hotmailcom");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void No_At_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("noAtEmail", "willywonkahotmail.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void Dot_Before_At_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("DotBeforeAtEmail", "willywonka.hotmail@com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void Invalid_Char_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("invalidCharEmail", "willy*wonka@hotmail.com");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(invalid);
        }

        [TestMethod]
        public void Invalid_Char_At_End_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("invalidCharAtEndEmail", "willywonka@hotmail.com*");
            bool invalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(invalid);
        }

        [TestMethod]
        public void Valid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail1", "willywonka@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Emai_1l()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail2", "willy%wonka2@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void Symbols_Numbers_Valid_Email_2()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail3", "charlie$$bucket99@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_3()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail4", "iwant@go1d3ng00se@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_4()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail5", "augustus+gloop-1@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_5()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail6", "ivegotagoldenticketyesido@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_6()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail7", "a!b&amp;c^23@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_7()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail8", "gpajoe.90@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_8()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail9", "mama~buCKet@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Symbols_Numbers_Valid_Email_9()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSettings<string>("validEmail10", "s=y}m{b?o'l$s@hotmail.com");
            bool valid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(valid);
        }
    }
}