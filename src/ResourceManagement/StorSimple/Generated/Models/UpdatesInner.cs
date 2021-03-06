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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The updates profile of a device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdatesInner : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdatesInner class.
        /// </summary>
        public UpdatesInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatesInner class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="kind">The Kind of the object. Currently only
        /// Series8000 is supported. Possible values include:
        /// 'Series8000'</param>
        /// <param name="regularUpdatesAvailable">Set to 'true' if regular
        /// updates are available for the device.</param>
        /// <param name="maintenanceModeUpdatesAvailable">Set to 'true' if
        /// maintenance mode update available.</param>
        /// <param name="isUpdateInProgress">Indicates whether an update is in
        /// progress or not.</param>
        /// <param name="lastUpdatedTime">The time when the last update was
        /// completed.</param>
        public UpdatesInner(string id = default(string), string name = default(string), string type = default(string), Kind? kind = default(Kind?), bool? regularUpdatesAvailable = default(bool?), bool? maintenanceModeUpdatesAvailable = default(bool?), bool? isUpdateInProgress = default(bool?), System.DateTime? lastUpdatedTime = default(System.DateTime?))
            : base(id, name, type, kind)
        {
            RegularUpdatesAvailable = regularUpdatesAvailable;
            MaintenanceModeUpdatesAvailable = maintenanceModeUpdatesAvailable;
            IsUpdateInProgress = isUpdateInProgress;
            LastUpdatedTime = lastUpdatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets set to 'true' if regular updates are available for the
        /// device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.regularUpdatesAvailable")]
        public bool? RegularUpdatesAvailable { get; set; }

        /// <summary>
        /// Gets or sets set to 'true' if maintenance mode update available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceModeUpdatesAvailable")]
        public bool? MaintenanceModeUpdatesAvailable { get; set; }

        /// <summary>
        /// Gets or sets indicates whether an update is in progress or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isUpdateInProgress")]
        public bool? IsUpdateInProgress { get; set; }

        /// <summary>
        /// Gets or sets the time when the last update was completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; set; }

    }
}
