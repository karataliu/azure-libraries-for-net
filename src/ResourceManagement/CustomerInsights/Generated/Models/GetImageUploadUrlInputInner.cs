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
    using System.Linq;

    /// <summary>
    /// Input type for getting image upload url.
    /// </summary>
    public partial class GetImageUploadUrlInputInner
    {
        /// <summary>
        /// Initializes a new instance of the GetImageUploadUrlInputInner
        /// class.
        /// </summary>
        public GetImageUploadUrlInputInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetImageUploadUrlInputInner
        /// class.
        /// </summary>
        /// <param name="entityType">Type of entity. Can be Profile or
        /// Interaction.</param>
        /// <param name="entityTypeName">Name of the entity type.</param>
        /// <param name="relativePath">Relative path of the image.</param>
        public GetImageUploadUrlInputInner(string entityType = default(string), string entityTypeName = default(string), string relativePath = default(string))
        {
            EntityType = entityType;
            EntityTypeName = entityTypeName;
            RelativePath = relativePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of entity. Can be Profile or Interaction.
        /// </summary>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets name of the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Gets or sets relative path of the image.
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

    }
}
