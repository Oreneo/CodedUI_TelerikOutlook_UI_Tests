using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Telerik.Outlook.Infrastructure.Helpers;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Telerik.Outlook.Infrastructure.Pages;
using Telerik.Outlook.Infrastructure.UIMaps.HomeMenuUIMapClasses;

namespace Telerik.Outlook.UITests
{
    [CodedUITest]
    public class OutlookSanityTests
    {
        public Guid Guid { get; private set; }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        internal MailHomeBarPage MailHomeBarPage { get; set; }
        internal ComposeNewMailPage NewMailPage { get; set; }
        internal NavigationBarPage NavigationBarPage { get; set; }
        internal MailsTablePage MailsTablePage { get; set; }
        internal DeletedItemsTablePage DeletedItemsTablePage { get; set; }
        internal MailDisplayPage MailDisplayPage { get; set; }
        internal CalendarPage CalendarPage { get; set; }
        internal CalendarHomeBarPage CalendarHomeBarPage { get; set; }
        internal NewAppointmentPage NewAppointmentPage { get; set; }

        public OutlookSanityTests()
        {
            MailHomeBarPage = new MailHomeBarPage();
            NewMailPage = new ComposeNewMailPage();
            NavigationBarPage = new NavigationBarPage();
            MailsTablePage = new MailsTablePage();
            MailDisplayPage = new MailDisplayPage();
            DeletedItemsTablePage = new DeletedItemsTablePage();
            CalendarPage = new CalendarPage();
            CalendarHomeBarPage = new CalendarHomeBarPage();
            NewAppointmentPage = new NewAppointmentPage();
        }

        // # 1
        [TestMethod]
        public void UserCanSendEmail()
        {
            Guid = Guid.NewGuid();

            MailHomeBarPage.ClickNewEmailButton();
            NewMailPage.EnterRecipientAddress("mark@telerikdomain.com");
            NewMailPage.EnterMailSubject(Guid.ToString());
            NewMailPage.WriteMessageInTextArea("Ma kore ahi");
            NewMailPage.ClickSendButton();

            NavigationBarPage.ClickSentItemsFolder();
            MailsTablePage.EnterMailSubjectInSearchCurrentMailBox(Guid.ToString());
            Assert.IsTrue(MailsTablePage.MailExists(Guid.ToString()));
        }

        // # 2
        [TestMethod]
        public void UserCanReplyToEmail()
        {
            Guid = Guid.NewGuid();
            MailsTablePage.ClickMailFromFolderById(0);

            MailDisplayPage.ClickReplyButton();
            MailDisplayPage.ClickPopOutButton();

            NewMailPage.ClearSubjectTextField();
            NewMailPage.EnterMailSubject(Guid.ToString());

            NewMailPage.ClickSendButton();
            NavigationBarPage.ClickSentItemsFolder();
            MailsTablePage.EnterMailSubjectInSearchCurrentMailBox(Guid.ToString());

            Assert.IsTrue(MailsTablePage.MailExists(Guid.ToString()));
        }

        // # 3
        [TestMethod]
        public void UserCanDeleteEmail()
        {
            Guid = Guid.NewGuid();

            MailHomeBarPage.ClickNewEmailButton();
            NewMailPage.EnterRecipientAddress("mark@telerikdomain.com");
            NewMailPage.EnterMailSubject(Guid.ToString());
            NewMailPage.WriteMessageInTextArea("Ma kore ahi");
            NewMailPage.ClickSendButton();

            NavigationBarPage.ClickSentItemsFolder();

            MailsTablePage.EnterMailSubjectInSearchCurrentMailBox(Guid.ToString());
            MailsTablePage.ClickMailFromFolderById(0);

            MailHomeBarPage.ClickDeleteMail();
            NavigationBarPage.ClickDeletedItemsFolder();
            
            Assert.IsTrue(DeletedItemsTablePage.DeletedMailExists(Guid.ToString()));
        }

        // # 4
        [TestMethod]
        public void UserCanMarkEmailWithFollowUpTag()
        {
            Guid = Guid.NewGuid();

            MailHomeBarPage.ClickNewEmailButton();
            NewMailPage.EnterRecipientAddress("mark@telerikdomain.com");
            NewMailPage.EnterMailSubject(Guid.ToString());
            NewMailPage.WriteMessageInTextArea("This mail is important. mark with 'Today' flag.");
            NewMailPage.ClickSendButton();

            NavigationBarPage.ClickSentItemsFolder();
            MailsTablePage.EnterMailSubjectInSearchCurrentMailBox(Guid.ToString());

            MailHomeBarPage.ClickFollowUpDropdown();
            MailHomeBarPage.ClickFollowUpTag("Today");

            using (new SearchTimeout(10000))
            {
                Assert.IsTrue(MailsTablePage.FlagExists(0));
            }
        }

        // # 5
        [TestMethod]
        public void UserCanCreateNewAppointment()
        {
            Guid = Guid.NewGuid();
            NavigationBarPage.ClickCalendarTab();
            CalendarPage.ClickCalendarBody();
            CalendarHomeBarPage.ClickNewAppointmentButton();
            NewAppointmentPage.EnterAppointmentSubject(Guid.ToString());
            NewAppointmentPage.EnterAppointmentDescription("Staff meeting regarding some serious stuff");
            NewAppointmentPage.ClickOkButton();

            Assert.IsTrue(CalendarPage.FindNewAppointment(Guid.ToString()));
        }

        // # 6.a
        [TestMethod]
        public void UserCanViewAppointmentInDayViewAndWeekView()
        {
            Guid = Guid.NewGuid();
            NavigationBarPage.ClickCalendarTab();
            CalendarHomeBarPage.ClickDayViewButton();
            CalendarPage.ClickCalendarBody();

            CalendarHomeBarPage.ClickNewAppointmentButton();
            NewAppointmentPage.EnterAppointmentSubject(Guid.ToString());
            NewAppointmentPage.EnterAppointmentDescription("Staff meeting regarding some serious stuff");
            NewAppointmentPage.ClickOkButton();

            Assert.IsTrue(CalendarPage.FindNewAppointment(Guid.ToString()));

            CalendarHomeBarPage.ClickWeekViewButton();
            Assert.IsTrue(CalendarPage.FindNewAppointment(Guid.ToString()));
        }

        // # 6.b
        [TestMethod]
        public void UserCanViewAppointmentInWorkView()
        {
            Guid = Guid.NewGuid();
            NavigationBarPage.ClickCalendarTab();
            CalendarHomeBarPage.ClickWorkViewButton();
            CalendarPage.ClickCalendarBody();

            CalendarHomeBarPage.ClickNewAppointmentButton();
            NewAppointmentPage.EnterAppointmentSubject(Guid.ToString());
            NewAppointmentPage.EnterAppointmentDescription("Staff meeting regarding some serious stuff");
            NewAppointmentPage.ClickOkButton();

            Assert.IsTrue(CalendarPage.FindNewAppointment(Guid.ToString()));
        }

        // # 7
        [TestMethod]
        public void UserCanDeleteAppointment()
        {
            Guid = Guid.NewGuid();
            NavigationBarPage.ClickCalendarTab();
            CalendarPage.ClickCalendarBody();
            CalendarHomeBarPage.ClickNewAppointmentButton();
            NewAppointmentPage.EnterAppointmentSubject(Guid.ToString());
            NewAppointmentPage.EnterAppointmentDescription("Staff meeting regarding some serious stuff");
            NewAppointmentPage.ClickOkButton();

            Assert.IsTrue(CalendarPage.FindNewAppointment(Guid.ToString()));  // make sure its there before i delete it.

            CalendarPage.ClickAppointment(Guid.ToString());
            CalendarHomeBarPage.ClickDeleteAppointmentButton();
            CalendarPage.ClickDeleteOkButton();

            Assert.IsFalse(CalendarPage.FindNewAppointment(Guid.ToString()));  // appointment is deleted.
        }

        #region Additional test attributes

        [TestInitialize]
        public void MyTestInitialize()
        {
            Process.Start(@"C:\Users\Oren\Desktop\Telerik OutlookInspiredApp for WPF.appref-ms");
            MailHomeBarPage.WaitForDeleteButtonToExist();
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            foreach (Process process in Process.GetProcessesByName("TelerikOutlookInspiredApp"))
            {
                process.Kill();
            }
        }

        #endregion   
    }
}
