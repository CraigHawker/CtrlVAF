﻿using CtrlVAF.Commands.Commands;

using MFiles.VAF.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlVAF.Tests.LicensingTests
{
    class TestLicenseCommand: IEventHandlerCommand<Configuration>
    {
        public EventHandlerEnvironment Env { get; set; }
        public Configuration Configuration { get; set; }
        public int Result { get; set; } = 1;

    }
}
