﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.AspNetCore.Core.Fluent;

namespace NWebsec.AspNetCore.Middleware
{
    /// <summary>
    /// Fluent interface to configure report URIs.
    /// </summary>
    public interface IFluentCspReportUriDirective : IFluentInterface
    {
        /// <summary>
        /// Sets report URIs for the CSP directive.
        /// </summary>
        /// <param name="reportUris">One or more report URIs.</param>
        void Uris(params string[] reportUris);
    }
}