// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace applicationGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualNetworkPeeringsOperations.
    /// </summary>
    public static partial class VirtualNetworkPeeringsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            public static void Delete(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            public static VirtualNetworkPeering Get(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName)
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkPeering> GetAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a peering in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='virtualNetworkPeeringParameters'>
            /// Parameters supplied to the create or update virtual network peering
            /// operation.
            /// </param>
            public static VirtualNetworkPeering CreateOrUpdate(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a peering in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='virtualNetworkPeeringParameters'>
            /// Parameters supplied to the create or update virtual network peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkPeering> CreateOrUpdateAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual network peerings in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static IPage<VirtualNetworkPeering> List(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                return operations.ListAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network peerings in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkPeering>> ListAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the virtual network peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a peering in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='virtualNetworkPeeringParameters'>
            /// Parameters supplied to the create or update virtual network peering
            /// operation.
            /// </param>
            public static VirtualNetworkPeering BeginCreateOrUpdate(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a peering in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='virtualNetworkPeeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='virtualNetworkPeeringParameters'>
            /// Parameters supplied to the create or update virtual network peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkPeering> BeginCreateOrUpdateAsync(this IVirtualNetworkPeeringsOperations operations, string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual network peerings in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkPeering> ListNext(this IVirtualNetworkPeeringsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network peerings in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkPeering>> ListNextAsync(this IVirtualNetworkPeeringsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}