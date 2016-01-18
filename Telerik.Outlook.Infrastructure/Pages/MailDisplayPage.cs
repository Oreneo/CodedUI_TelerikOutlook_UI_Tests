using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Telerik.Outlook.Infrastructure.UIMaps.MailDisplayUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class MailDisplayPage
    {
        internal MailDisplayUIMap MailDisplayUIMap { get; set; }

        public MailDisplayPage()
        {
            MailDisplayUIMap = new MailDisplayUIMap();
        }

        public void ClickReplyButton()
        {
            var replyButton = MailDisplayUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonButtonReply;
            Mouse.Click(replyButton);
        }

        public void ClickPopOutButton()
        {
            var popOutButton = MailDisplayUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonButtonPopOut;
            Mouse.Click(popOutButton);
        }
    }
}
