using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class ClientDTO
    {
        public string ClientIP { get; set; }
        public string ClientPort { get; set; }
        public string RequestFileName { get; set; }
        public string ProcessResult { get; set; }
    }
}
