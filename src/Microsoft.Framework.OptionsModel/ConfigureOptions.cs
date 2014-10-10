// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Framework.OptionsModel
{
    public class ConfigureOptions<TOptions> : IConfigureOptions<TOptions>
    {
        public ConfigureOptions([NotNull]Action<TOptions> action)
        {
            Action = action;
        }

        public Action<TOptions> Action { get; private set; }

        public string Name { get; set; } = "";
        public virtual int Order { get; set; } = OptionsConstants.DefaultOrder;

        public virtual void Configure([NotNull]TOptions options, string name = "")
        {
            Action.Invoke(options);
        }
    }
}