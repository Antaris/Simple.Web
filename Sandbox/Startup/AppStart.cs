﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Startup
{
    using Simple.Web;
    using Simple.Web.Authentication;

    public class AppStart : IStartupTask
    {
        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            SimpleWeb.Configuration.AuthenticationProvider = new DefaultAuthenticationProvider();
        }
    }
}