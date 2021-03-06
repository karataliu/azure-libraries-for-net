// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{

    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Entry point to providers management API.
    /// </summary>
    public interface IProviders  :
        ISupportsListing<IProvider>,
        ISupportsGettingByName<IProvider>
    {
        /// <summary>
        /// Unregisters provider from a subscription.
        /// </summary>
        /// <param name="resourceProviderNamespace">resourceProviderNamespace Namespace of the resource provider</param>
        /// <returns>the ProviderInner object wrapped in {@link ServiceResponse} if successful</returns>
        IProvider Unregister (string resourceProviderNamespace);

        /// <summary>
        /// Unregisters provider from a subscription.
        /// </summary>
        /// <param name="resourceProviderNamespace">resourceProviderNamespace Namespace of the resource provider</param>
        /// <returns>the ProviderInner object wrapped in {@link ServiceResponse} if successful</returns>
        Task<IProvider> UnregisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Registers provider to be used with a subscription.
        /// </summary>
        /// <param name="resourceProviderNamespace">resourceProviderNamespace Namespace of the resource provider</param>
        /// <returns>the ProviderInner object wrapped in {@link ServiceResponse} if successful</returns>
        IProvider Register (string resourceProviderNamespace);

        /// <summary>
        /// Registers provider to be used with a subscription.
        /// </summary>
        /// <param name="resourceProviderNamespace">resourceProviderNamespace Namespace of the resource provider</param>
        /// <returns>the ProviderInner object wrapped in {@link ServiceResponse} if successful</returns>
        Task<IProvider> RegisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken));
    }
}