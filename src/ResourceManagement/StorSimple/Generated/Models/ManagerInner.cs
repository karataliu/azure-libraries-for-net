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
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The StorSimple Manager.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagerInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagerInner class.
        /// </summary>
        public ManagerInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagerInner class.
        /// </summary>
        /// <param name="cisIntrinsicSettings">Represents the type of
        /// StorSimple Manager.</param>
        /// <param name="provisioningState">Specifies the state of the resource
        /// as it is getting provisioned. Value of "Succeeded" means the
        /// Manager was successfully created.</param>
        /// <param name="etag">The etag of the manager.</param>
        public ManagerInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ManagerIntrinsicSettings cisIntrinsicSettings = default(ManagerIntrinsicSettings), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            CisIntrinsicSettings = cisIntrinsicSettings;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ManagerInner class.
        /// </summary>
        static ManagerInner()
        {
            Sku = new ManagerSku();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represents the type of StorSimple Manager.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cisIntrinsicSettings")]
        public ManagerIntrinsicSettings CisIntrinsicSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the state of the resource as it is getting
        /// provisioned. Value of "Succeeded" means the Manager was
        /// successfully created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the etag of the manager.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Specifies the Sku.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public static ManagerSku Sku { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CisIntrinsicSettings != null)
            {
                CisIntrinsicSettings.Validate();
            }
        }
    }
}
