// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition.Blank.PremiumEndpoint
{
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition;

    /// <summary>
    /// The stage of the CDN profile endpoint definition allowing to specify the origin
    /// for CDN Profile with the Premium Verizon SKU.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent CDN profile update to return to after attaching this definition.</typeparam>
    public interface IPremiumEndpoint<ParentT> 
    {
        /// <summary>
        /// Specifies the origin of the CDN endpoint.
        /// </summary>
        /// <param name="originName">Name of the origin.</param>
        /// <param name="originHostName">Origin host name.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition.IWithPremiumAttach<ParentT> WithPremiumOrigin(string originName, string originHostName);

        /// <summary>
        /// Specifies the origin of the CDN endpoint.
        /// </summary>
        /// <param name="originHostName">Origin host name.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition.IWithPremiumAttach<ParentT> WithPremiumOrigin(string originHostName);
    }
}