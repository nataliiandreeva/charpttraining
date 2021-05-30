﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {       
        [Test]
        public void TheBookManyHealthcareAppointmentsTest()
        {
            GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupPage();
        }
    }
}
