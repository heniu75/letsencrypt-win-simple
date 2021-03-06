﻿using LetsEncrypt.ACME.Simple.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.ACME.Simple.Configuration
{
    public class WebDavOptions : NetworkCredentialOptions
    {
        public WebDavOptions(): base() { }
        public WebDavOptions(OptionsService options) : base(options) { }
        public WebDavOptions(OptionsService options, InputService input) : base(options, input) { }
    }
}
