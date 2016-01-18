using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Telerik.Outlook.Infrastructure.UIMaps.MailsTableUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class MailsTablePage
    {
        internal MailsTableUIMap MailsTableUIMap { get; set; }

        public MailsTablePage()
        {
            MailsTableUIMap = new MailsTableUIMap();
        }

        public void EnterMailSubjectInSearchCurrentMailBox(string subject)
        {
            WpfText uISearchCurrentMailboxText = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UISearchWatermarkTextBEdit.UISearchCurrentMailboxText;
            WpfEdit uISearchWatermarkTextBEdit = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UISearchWatermarkTextBEdit;

            uISearchCurrentMailboxText.WaitForControlExist();

            // Click 'Search Current Mailbox' label
            Mouse.Click(uISearchCurrentMailboxText, new Point(113, 5));

            Keyboard.SendKeys(uISearchWatermarkTextBEdit, subject, ModifierKeys.None);
        }

        public bool MailExists(string subject)
        {
            var mailsTable = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UILoadingProgressBar.UIGridViewTable;

            var virtualizingPanel = mailsTable.GetChildren().Single(item => (item as WpfControl).AutomationId == "PART_GridViewVirtualizingPanel");

            WpfRow row = new WpfRow(virtualizingPanel);
            row.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Row_0";
            row.Find();

            return subject == (row.Cells[1] as WpfCell).Value;
        }

        public void ClickMailFromFolderById(int index)
        {
            var mailsTable = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UILoadingProgressBar.UIGridViewTable;

            var virtualizingPanel = mailsTable.GetChildren().Single(item => (item as WpfControl).AutomationId == "PART_GridViewVirtualizingPanel");

            WpfRow row = new WpfRow(virtualizingPanel);
            row.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Row_" + index;
            row.Find();

            Mouse.Click(row, new Point(10, 10));
        }

        public bool FlagExists(int index)
        {
            var mailsTable = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UILoadingProgressBar.UIGridViewTable;

            var virtualizingPanel = mailsTable.GetChildren().Single(item => (item as WpfControl).AutomationId == "PART_GridViewVirtualizingPanel");

            WpfRow row = new WpfRow(virtualizingPanel);
            row.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Row_" + index;
            row.Find();

            WpfCell cell = new WpfCell(row);
            cell.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Cell_" + index + "_3";
            cell.Find();

            WpfCustom cellElement = new WpfCustom(cell);
            cellElement.SearchProperties[WpfControl.PropertyNames.AutomationId] = "CellElement_" + index + "_3";
            return cellElement.TryFind();
        }
    }
}
