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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The role resource format.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RoleResourceFormat class.
        /// </summary>
        public RoleResourceFormat()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleResourceFormat class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="roleName">The role name.</param>
        /// <param name="description">The description of the role.</param>
        public RoleResourceFormat(string id = default(string), string name = default(string), string type = default(string), string roleName = default(string), string description = default(string))
            : base(id, name, type)
        {
            RoleName = roleName;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the description of the role.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}
