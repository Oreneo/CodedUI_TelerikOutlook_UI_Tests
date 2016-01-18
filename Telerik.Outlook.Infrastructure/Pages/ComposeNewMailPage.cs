using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Outlook.Infrastructure.UIMaps.ComposeNewMailUIMapClasses;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using ModifierKeys = System.Windows.Input.ModifierKeys;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class ComposeNewMailPage
    {
        internal ComposeNewMailUIMap NewMailUIMap { get; set; }

        public ComposeNewMailPage()
        {
            NewMailUIMap = new ComposeNewMailUIMap();
        }

        public void EnterRecipientAddress(string emailAddress)
        {
            WpfEdit recipientTextBox = NewMailUIMap.UINewMessageHTMLWindow.UIRecipientTextBox;
            Mouse.Click(recipientTextBox);
            Keyboard.SendKeys(recipientTextBox, emailAddress);
        }

        public void EnterMailSubject(string subject)
        {
            WpfEdit emailSubjectBox = NewMailUIMap.UINewMessageHTMLWindow.UISubjectTextBox;
            Mouse.Click(emailSubjectBox);
            Keyboard.SendKeys(emailSubjectBox, subject);
        }

        public void ClickSendButton()
        {
            WpfButton sendButton = NewMailUIMap.UINewMessageHTMLWindow.UISendButton;
            Mouse.Click(sendButton);
        }

        public void WriteMessageInTextArea(string message)
        {
            WpfControl messageTextArea = NewMailUIMap.UINewMessageHTMLWindow.UIMessageRadRichTextBoxDocument;
            Keyboard.SendKeys(messageTextArea, message);
        }

        public void ClearSubjectTextField()
        {
            WpfEdit subjectTextBox = NewMailUIMap.UINewMessageHTMLWindow.UISubjectTextBox;

            Keyboard.SendKeys(subjectTextBox, "{HOME}", ModifierKeys.None);
            Keyboard.SendKeys(subjectTextBox, "{END}", ModifierKeys.Shift);
            Keyboard.SendKeys(subjectTextBox, "{BACK}", ModifierKeys.None);
        }
    }
}
