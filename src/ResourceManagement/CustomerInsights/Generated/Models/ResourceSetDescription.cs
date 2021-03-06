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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource set description.
    /// </summary>
    public partial class ResourceSetDescription
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSetDescription class.
        /// </summary>
        public ResourceSetDescription()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSetDescription class.
        /// </summary>
        /// <param name="elements">The elements included in the set.</param>
        /// <param name="exceptions">The elements that are not included in the
        /// set, in case elements contains '*' indicating 'all'.</param>
        public ResourceSetDescription(IList<string> elements = default(IList<string>), IList<string> exceptions = default(IList<string>))
        {
            Elements = elements;
            Exceptions = exceptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the elements included in the set.
        /// </summary>
        [JsonProperty(PropertyName = "elements")]
        public IList<string> Elements { get; set; }

        /// <summary>
        /// Gets or sets the elements that are not included in the set, in case
        /// elements contains '*' indicating 'all'.
        /// </summary>
        [JsonProperty(PropertyName = "exceptions")]
        public IList<string> Exceptions { get; set; }

    }
}
