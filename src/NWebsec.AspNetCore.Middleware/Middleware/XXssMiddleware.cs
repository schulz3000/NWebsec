﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using NWebsec.AspNetCore.Core.Extensions;
using NWebsec.AspNetCore.Core.HttpHeaders;
using NWebsec.AspNetCore.Core.HttpHeaders.Configuration;

namespace NWebsec.AspNetCore.Middleware.Middleware
{
    public class XXssMiddleware : MiddlewareBase
    {
        private readonly IXXssProtectionConfiguration _config;
        private readonly HeaderResult _headerResult;

        public XXssMiddleware(RequestDelegate next, XXssProtectionOptions options)
            : base(next)
        {
            _config = options;
            var headerGenerator = new HeaderGenerator();
            _headerResult = headerGenerator.CreateXXssProtectionResult(_config);
        }

        internal override void PreInvokeNext(HttpContext owinEnvironment)
        {
            owinEnvironment.GetNWebsecContext().XXssProtection = _config;

            if (_headerResult.Action == HeaderResult.ResponseAction.Set)
            {
                owinEnvironment.Response.Headers[_headerResult.Name] = _headerResult.Value;
            }
        }
    }
}