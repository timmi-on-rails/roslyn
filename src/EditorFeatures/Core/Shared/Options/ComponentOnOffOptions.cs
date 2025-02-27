﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Shared.Options
{
    /// <summary>
    /// options to indicate whether a certain component in Roslyn is enabled or not
    /// </summary>
    internal sealed class EditorComponentOnOffOptions
    {
        public static readonly Option2<bool> Adornment = new("EditorComponentOnOffOptions_Adornment", defaultValue: true);
        public static readonly Option2<bool> Tagger = new("EditorComponentOnOffOptions_Tagger", defaultValue: true);
        public static readonly Option2<bool> CodeRefactorings = new("EditorComponentOnOffOptions_CodeRefactorings", defaultValue: true);
    }
}
