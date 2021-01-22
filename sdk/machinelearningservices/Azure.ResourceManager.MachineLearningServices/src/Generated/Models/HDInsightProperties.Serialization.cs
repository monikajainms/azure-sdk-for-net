// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class HDInsightProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SshPort))
            {
                writer.WritePropertyName("sshPort");
                writer.WriteNumberValue(SshPort.Value);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(AdministratorAccount))
            {
                writer.WritePropertyName("administratorAccount");
                writer.WriteObjectValue(AdministratorAccount);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightProperties DeserializeHDInsightProperties(JsonElement element)
        {
            Optional<int> sshPort = default;
            Optional<string> address = default;
            Optional<VirtualMachineSshCredentials> administratorAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sshPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("administratorAccount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    administratorAccount = VirtualMachineSshCredentials.DeserializeVirtualMachineSshCredentials(property.Value);
                    continue;
                }
            }
            return new HDInsightProperties(Optional.ToNullable(sshPort), address.Value, administratorAccount.Value);
        }
    }
}