// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The secondary DNS settings.
    /// </summary>
    public partial class SecondaryDNSSettings
    {
        /// <summary>
        /// Initializes a new instance of the SecondaryDNSSettings class.
        /// </summary>
        public SecondaryDNSSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecondaryDNSSettings class.
        /// </summary>
        /// <param name="secondaryDnsServers">The list of secondary DNS Server
        /// IP addresses.</param>
        public SecondaryDNSSettings(IList<string> secondaryDnsServers = default(IList<string>))
        {
            SecondaryDnsServers = secondaryDnsServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of secondary DNS Server IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryDnsServers")]
        public IList<string> SecondaryDnsServers { get; set; }

    }
}
