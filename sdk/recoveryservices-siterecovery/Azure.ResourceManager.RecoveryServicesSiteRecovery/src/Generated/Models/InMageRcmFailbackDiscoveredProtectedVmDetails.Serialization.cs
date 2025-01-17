// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackDiscoveredProtectedVmDetails
    {
        internal static InMageRcmFailbackDiscoveredProtectedVmDetails DeserializeInMageRcmFailbackDiscoveredProtectedVmDetails(JsonElement element)
        {
            Optional<string> vCenterId = default;
            Optional<string> vCenterFqdn = default;
            Optional<IReadOnlyList<string>> datastores = default;
            Optional<IReadOnlyList<string>> ipAddresses = default;
            Optional<string> vmwareToolsStatus = default;
            Optional<string> powerStatus = default;
            Optional<string> vmFqdn = default;
            Optional<string> osName = default;
            Optional<DateTimeOffset> createdTimestamp = default;
            Optional<DateTimeOffset> updatedTimestamp = default;
            Optional<bool> isDeleted = default;
            Optional<DateTimeOffset> lastDiscoveryTimeInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCenterId"))
                {
                    vCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterFqdn"))
                {
                    vCenterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastores"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    datastores = array;
                    continue;
                }
                if (property.NameEquals("ipAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("vmwareToolsStatus"))
                {
                    vmwareToolsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerStatus"))
                {
                    powerStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmFqdn"))
                {
                    vmFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isDeleted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastDiscoveryTimeInUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastDiscoveryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new InMageRcmFailbackDiscoveredProtectedVmDetails(vCenterId.Value, vCenterFqdn.Value, Optional.ToList(datastores), Optional.ToList(ipAddresses), vmwareToolsStatus.Value, powerStatus.Value, vmFqdn.Value, osName.Value, Optional.ToNullable(createdTimestamp), Optional.ToNullable(updatedTimestamp), Optional.ToNullable(isDeleted), Optional.ToNullable(lastDiscoveryTimeInUtc));
        }
    }
}
