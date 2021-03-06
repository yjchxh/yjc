// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Microsoft.AspNetCore.Mvc.IntegrationTests;

public class ComplexObjectIntegrationTest : ComplexTypeIntegrationTestBase
{
    protected override Type ExpectedModelBinderType => typeof(ComplexObjectModelBinder);
}
