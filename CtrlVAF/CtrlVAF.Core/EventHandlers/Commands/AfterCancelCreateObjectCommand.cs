﻿using MFiles.VAF.Common;
using MFilesAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlVAF.Commands.Commands
{
    public class AfterCancelCreateObjectCommand<T> : IEventCommand<T>
    {
        public EventHandlerEnvironment Env { get; set; }
        public T Configuration { get; set; }
    }
}
