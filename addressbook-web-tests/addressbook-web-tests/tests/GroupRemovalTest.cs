using System;
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
            app.Navigator.GoToGroupPage();
            app.Groups
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupPage();
        }
    }
}
