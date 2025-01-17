// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class PredictiveAutoscalePolicyScaleModeExtensions
    {
        public static string ToSerialString(this PredictiveAutoscalePolicyScaleMode value) => value switch
        {
            PredictiveAutoscalePolicyScaleMode.Disabled => "Disabled",
            PredictiveAutoscalePolicyScaleMode.ForecastOnly => "ForecastOnly",
            PredictiveAutoscalePolicyScaleMode.Enabled => "Enabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PredictiveAutoscalePolicyScaleMode value.")
        };

        public static PredictiveAutoscalePolicyScaleMode ToPredictiveAutoscalePolicyScaleMode(this string value)
        {
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return PredictiveAutoscalePolicyScaleMode.Disabled;
            if (string.Equals(value, "ForecastOnly", StringComparison.InvariantCultureIgnoreCase)) return PredictiveAutoscalePolicyScaleMode.ForecastOnly;
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return PredictiveAutoscalePolicyScaleMode.Enabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PredictiveAutoscalePolicyScaleMode value.");
        }
    }
}
