// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.Collections.Generic;
using NWebsec.AspNetCore.Core.HttpHeaders.Configuration;

namespace NWebsec.AspNetCore.Mvc.Tests.TestHelpers
{
    public class CspSandboxDirectiveConfigurationEqualityComparer : IEqualityComparer<ICspSandboxDirectiveConfiguration>
    {
        public bool Equals(ICspSandboxDirectiveConfiguration x, ICspSandboxDirectiveConfiguration y)
        {
            return x.Enabled.Equals(y.Enabled) &&
                x.AllowForms.Equals(y.AllowForms) &&
                x.AllowModals.Equals(y.AllowModals) &&
                x.AllowOrientationLock.Equals(y.AllowOrientationLock) &&
                x.AllowPointerLock.Equals(y.AllowPointerLock) &&
                x.AllowPopups.Equals(y.AllowPopups) &&
                x.AllowPopupsToEscapeSandbox.Equals(y.AllowPopupsToEscapeSandbox) &&
                x.AllowPresentation.Equals(y.AllowPresentation) &&
                x.AllowSameOrigin.Equals(y.AllowSameOrigin) &&
                x.AllowScripts.Equals(y.AllowScripts) &&
                x.AllowTopNavigation.Equals(y.AllowTopNavigation);
        }

        public int GetHashCode(ICspSandboxDirectiveConfiguration obj)
        {
            throw new System.NotImplementedException();
        }
    }
}