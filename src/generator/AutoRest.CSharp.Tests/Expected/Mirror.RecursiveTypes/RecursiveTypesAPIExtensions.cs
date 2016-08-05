// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorRecursiveTypes
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for RecursiveTypesAPI.
    /// </summary>
    public static partial class RecursiveTypesAPIExtensions
    {
            /// <summary>
            /// Products
            /// </summary>
            /// <remarks>
            /// The Products endpoint returns information about the Uber products offered
            /// at a given location. The response includes the display name and other
            /// details about each product, and lists the products in the proper display
            /// order.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group Id.
            /// </param>
            /// <param name='apiVersion'>
            /// API Id.
            /// </param>
            /// <param name='body'>
            /// API body mody.
            /// </param>
            public static Product Post(this IRecursiveTypesAPI operations, string subscriptionId, string resourceGroupName, string apiVersion, Product body = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRecursiveTypesAPI)s).PostAsync(subscriptionId, resourceGroupName, apiVersion, body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Products
            /// </summary>
            /// <remarks>
            /// The Products endpoint returns information about the Uber products offered
            /// at a given location. The response includes the display name and other
            /// details about each product, and lists the products in the proper display
            /// order.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group Id.
            /// </param>
            /// <param name='apiVersion'>
            /// API Id.
            /// </param>
            /// <param name='body'>
            /// API body mody.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> PostAsync(this IRecursiveTypesAPI operations, string subscriptionId, string resourceGroupName, string apiVersion, Product body = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(subscriptionId, resourceGroupName, apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}