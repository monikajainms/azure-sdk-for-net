// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Iot.TimeSeriesInsights;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class AggregateVariable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("aggregation");
            writer.WriteObjectValue(Aggregation);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            writer.WriteEndObject();
        }

        internal static AggregateVariable DeserializeAggregateVariable(JsonElement element)
        {
            TimeSeriesExpression aggregation = default;
            string kind = default;
            Optional<TimeSeriesExpression> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"))
                {
                    aggregation = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
            }
            return new AggregateVariable(kind, filter.Value, aggregation);
        }
    }
}