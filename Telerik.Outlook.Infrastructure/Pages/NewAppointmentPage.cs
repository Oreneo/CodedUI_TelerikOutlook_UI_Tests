using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Telerik.Outlook.Infrastructure.UIMaps.NewAppointmentUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class NewAppointmentPage
    {
        internal NewAppointmentUIMap NewAppointmentUIMap { get; set; }

        public NewAppointmentPage()
        {
            NewAppointmentUIMap = new NewAppointmentUIMap();
        }

        public void EnterAppointmentSubject(string subject)
        {
            WpfEdit appointmentSubjectBox = NewAppointmentUIMap.UIMarktelerikdomaincomWindow.UISubjectTextBoxEdit;
            Mouse.Click(appointmentSubjectBox);
            Keyboard.SendKeys(appointmentSubjectBox, subject);
        }

        public void EnterAppointmentDescription(string description)
        {
            WpfEdit appointmentDescriptionBox = NewAppointmentUIMap.UIMarktelerikdomaincomWindow.UIDescriptionTextBoxEdit;
            Mouse.Click(appointmentDescriptionBox);
            Keyboard.SendKeys(appointmentDescriptionBox, description);
        }

        public void ClickOkButton()
        {
            NewAppointmentUIMap.ClickOk();
        }
    }
}
