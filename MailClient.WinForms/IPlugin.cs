﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.WinForms
{
    public interface IPlugin : IDisposable
    {
        void ProcessMessage(MailMessageWrapper msg);
    }
}
