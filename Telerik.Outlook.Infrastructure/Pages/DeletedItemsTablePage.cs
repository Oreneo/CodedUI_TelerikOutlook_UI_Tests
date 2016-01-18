using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class DeletedItemsTablePage : MailsTablePage
    {
        public bool DeletedMailExists(string subject)
        {
            var sentMailsTable = MailsTableUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UILoadingProgressBar.UIGridViewTable;

            var virtualizingPanel = sentMailsTable.GetChildren().Single(item => (item as WpfControl).AutomationId == "PART_GridViewVirtualizingPanel");

            WpfRow row = new WpfRow(virtualizingPanel);
            row.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Row_0";
            row.Find();

            return subject == (row.Cells[1] as WpfCell).Value;
        }
    }
}
