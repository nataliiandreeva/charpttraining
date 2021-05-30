﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        private StringBuilder verificationErrors;

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            verificationErrors = new StringBuilder();

            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }  
    }
}
