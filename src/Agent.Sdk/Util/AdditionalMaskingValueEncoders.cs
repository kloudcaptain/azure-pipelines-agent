// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Text.RegularExpressions;

namespace Microsoft.VisualStudio.Services.Agent.Util;

public static class AdditionalMaskingValueEncoders
{
    public static string RemoveSpecialSymbols(string value)
    {
        return RemoveSpecialSymbolsRegex.Replace(value, string.Empty);
    }

    // Here we can add symbols we think are safe, e.g. ., -, ~, _
    private static readonly Regex RemoveSpecialSymbolsRegex = new(@"[^\w\.~\-_]", RegexOptions.Compiled);
}
