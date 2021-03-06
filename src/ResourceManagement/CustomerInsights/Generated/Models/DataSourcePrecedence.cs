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
    /// The data source precedence is a way to know the precedence of each data
    /// source.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataSourcePrecedence
    {
        /// <summary>
        /// Initializes a new instance of the DataSourcePrecedence class.
        /// </summary>
        public DataSourcePrecedence()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataSourcePrecedence class.
        /// </summary>
        /// <param name="name">The data source name</param>
        /// <param name="dataSourceType">The data source type. Possible values
        /// include: 'Connector', 'LinkInteraction', 'SystemDefault'</param>
        /// <param name="status">The data source status. Possible values
        /// include: 'None', 'Active', 'Deleted'</param>
        /// <param name="id">The data source ID.</param>
        /// <param name="dataSourceReferenceId">The data source reference
        /// id.</param>
        /// <param name="precedence">the precedence value.</param>
        public DataSourcePrecedence(string name = default(string), string dataSourceType = default(string), string status = default(string), int? id = default(int?), string dataSourceReferenceId = default(string), int? precedence = default(int?))
        {
            Name = name;
            DataSourceType = dataSourceType;
            Status = status;
            Id = id;
            DataSourceReferenceId = dataSourceReferenceId;
            Precedence = precedence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the data source name
        /// </summary>
        [JsonProperty(PropertyName = "dataSource.name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the data source type. Possible values include: 'Connector',
        /// 'LinkInteraction', 'SystemDefault'
        /// </summary>
        [JsonProperty(PropertyName = "dataSource.dataSourceType")]
        public string DataSourceType { get; private set; }

        /// <summary>
        /// Gets the data source status. Possible values include: 'None',
        /// 'Active', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "dataSource.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the data source ID.
        /// </summary>
        [JsonProperty(PropertyName = "dataSource.id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets the data source reference id.
        /// </summary>
        [JsonProperty(PropertyName = "dataSource.dataSourceReferenceId")]
        public string DataSourceReferenceId { get; private set; }

        /// <summary>
        /// Gets or sets the precedence value.
        /// </summary>
        [JsonProperty(PropertyName = "precedence")]
        public int? Precedence { get; set; }

    }
}
