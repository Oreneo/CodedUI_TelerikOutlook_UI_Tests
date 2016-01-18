using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Telerik.Outlook.Infrastructure.Helpers
{
    public class SearchTimeout : IDisposable
    {
        public SearchTimeout(int ms)
        {
            Playback.PlaybackSettings.SearchTimeout = ms;
        }

        public void Dispose()
        {
            Playback.PlaybackSettings.SearchTimeout = 120000;
        }
    }
}
