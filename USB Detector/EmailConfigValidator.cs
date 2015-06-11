using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USB_Detector
{
    class EmailConfigValidator
    {
        public bool IsValid_TextLength(string text)
        {
            return true;
        }

        public bool IsValid_NotEmpty(string text)
        {
            return true;
        }

        public bool IsValid_Port(string text)
        {
            return true;
        }
    }
}

// TODO: Implement validator functionality