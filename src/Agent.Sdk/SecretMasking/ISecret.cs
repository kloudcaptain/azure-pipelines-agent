﻿using System;
using System.Collections.Generic;
using Agent.Sdk.Util;

namespace Agent.Sdk.SecretMasking;

internal interface ISecret
{
    /// <summary>
    /// Returns one item (start, length) for each match found in the input string.
    /// </summary>
    IEnumerable<ReplacementPosition> GetPositions(String input);
}