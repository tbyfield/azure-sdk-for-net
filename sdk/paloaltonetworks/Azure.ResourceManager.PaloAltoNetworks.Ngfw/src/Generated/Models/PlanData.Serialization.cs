// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class PlanData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UsageType))
            {
                writer.WritePropertyName("usageType"u8);
                writer.WriteStringValue(UsageType.Value.ToString());
            }
            writer.WritePropertyName("billingCycle"u8);
            writer.WriteStringValue(BillingCycle.ToString());
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            writer.WriteEndObject();
        }

        internal static PlanData DeserializePlanData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UsageType> usageType = default;
            BillingCycle billingCycle = default;
            string planId = default;
            Optional<DateTimeOffset> effectiveDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageType = new UsageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingCycle"u8))
                {
                    billingCycle = new BillingCycle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PlanData(Optional.ToNullable(usageType), billingCycle, planId, Optional.ToNullable(effectiveDate));
        }
    }
}
