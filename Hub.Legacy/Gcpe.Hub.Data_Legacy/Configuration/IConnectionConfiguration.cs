﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcpe.Hub.Data.Configuration
{
    public interface IConnectionConfiguration
    {
        String DbServer { get; }
        String DbName { get; }

    }
}