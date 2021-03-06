// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ErrorManagementTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorManagementTypes
    {
        [EnumMember(Value = "RejectAndContinue")]
        RejectAndContinue,
        [EnumMember(Value = "StopImport")]
        StopImport,
        [EnumMember(Value = "RejectUntilLimit")]
        RejectUntilLimit
    }
    internal static class ErrorManagementTypesEnumExtension
    {
        internal static string ToSerializedValue(this ErrorManagementTypes? value)
        {
            return value == null ? null : ((ErrorManagementTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ErrorManagementTypes value)
        {
            switch( value )
            {
                case ErrorManagementTypes.RejectAndContinue:
                    return "RejectAndContinue";
                case ErrorManagementTypes.StopImport:
                    return "StopImport";
                case ErrorManagementTypes.RejectUntilLimit:
                    return "RejectUntilLimit";
            }
            return null;
        }

        internal static ErrorManagementTypes? ParseErrorManagementTypes(this string value)
        {
            switch( value )
            {
                case "RejectAndContinue":
                    return ErrorManagementTypes.RejectAndContinue;
                case "StopImport":
                    return ErrorManagementTypes.StopImport;
                case "RejectUntilLimit":
                    return ErrorManagementTypes.RejectUntilLimit;
            }
            return null;
        }
    }
}
