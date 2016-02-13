﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Authentication
{
    public interface ITokenStore
    {
        string Get(string key);

        void Set(string key, string value);
    }
}
