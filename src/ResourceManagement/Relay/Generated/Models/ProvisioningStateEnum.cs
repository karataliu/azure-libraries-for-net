// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Relay.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Azure.Management.Relay.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningStateEnum
    {
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Updating")]
        Updating,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class ProvisioningStateEnumEnumExtension
    {
        internal static string ToSerializedValue(this ProvisioningStateEnum? value)
        {
            return value == null ? null : ((ProvisioningStateEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProvisioningStateEnum value)
        {
            switch( value )
            {
                case ProvisioningStateEnum.Created:
                    return "Created";
                case ProvisioningStateEnum.Succeeded:
                    return "Succeeded";
                case ProvisioningStateEnum.Deleted:
                    return "Deleted";
                case ProvisioningStateEnum.Failed:
                    return "Failed";
                case ProvisioningStateEnum.Updating:
                    return "Updating";
                case ProvisioningStateEnum.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static ProvisioningStateEnum? ParseProvisioningStateEnum(this string value)
        {
            switch( value )
            {
                case "Created":
                    return ProvisioningStateEnum.Created;
                case "Succeeded":
                    return ProvisioningStateEnum.Succeeded;
                case "Deleted":
                    return ProvisioningStateEnum.Deleted;
                case "Failed":
                    return ProvisioningStateEnum.Failed;
                case "Updating":
                    return ProvisioningStateEnum.Updating;
                case "Unknown":
                    return ProvisioningStateEnum.Unknown;
            }
            return null;
        }
    }
}
