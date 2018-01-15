using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Interfaces
{
    public interface IDownloadApp
    {
        void DownloadApplication(string uri, string fileName);
    }
}
