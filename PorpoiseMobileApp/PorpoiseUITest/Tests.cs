using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PorpoiseUITest
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }


      

        [Test]
        public void Login()
        {
            app.Screenshot("App Lauched");

            app.ClearText("Email");

            app.EnterText("Email", "luis@getporpoise.com");

            app.Screenshot("Email Entered");

            app.ClearText("Password");

            app.EnterText("Password", "LMNC1989");

            app.Screenshot("Password Entered");

            app.Tap("Login");



        }
    }
}
