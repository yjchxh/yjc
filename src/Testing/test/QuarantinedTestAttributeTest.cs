// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Xunit;

namespace Microsoft.AspNetCore.Testing.Tests;

public class QuarantinedTestAttributeTest
{
    [Fact(Skip = "These tests are nice when you need them but annoying when on all the time.")]
    [QuarantinedTest("No issue")]
    public void AlwaysFlakyInCI()
    {
        if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("HELIX")) || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("AGENT_OS")))
        {
            throw new Exception("Flaky!");
        }
    }
}
