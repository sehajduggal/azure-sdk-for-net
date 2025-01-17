// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownMediaTransformPreset. </summary>
    internal partial class UnknownMediaTransformPreset : MediaTransformPreset
    {
        /// <summary> Initializes a new instance of UnknownMediaTransformPreset. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal UnknownMediaTransformPreset(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}
