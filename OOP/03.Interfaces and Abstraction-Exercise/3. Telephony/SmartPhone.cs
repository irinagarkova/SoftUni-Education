using _3._Telephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Telephony
{
    public class SmartPhone : ICaller, IBrowser
    {
        public string Browse(string site) => $"Browsing: {site}!";

        public string Call(string phoneNumber) => $"Calling... {phoneNumber}";
    }
}
