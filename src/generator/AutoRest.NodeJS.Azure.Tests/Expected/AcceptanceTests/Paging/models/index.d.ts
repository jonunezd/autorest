/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import { BaseResource } from 'ms-rest-azure';
import { CloudError } from 'ms-rest-azure';
import * as moment from 'moment';

export { BaseResource } from 'ms-rest-azure';
export { CloudError } from 'ms-rest-azure';


/**
 * @class
 * Initializes a new instance of the ProductProperties class.
 * @constructor
 * @member {number} [id]
 * @member {string} [name]
 */
export interface ProductProperties {
  id?: number;
  name?: string;
}

/**
 * @class
 * Initializes a new instance of the Product class.
 * @constructor
 * @member {object} [properties]
 * @member {number} [properties.id]
 * @member {string} [properties.name]
 */
export interface Product {
  properties?: ProductProperties;
}

/**
 * @class
 * Initializes a new instance of the ProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [nextLink]
 */
export interface ProductResult {
  values?: Product[];
  nextLink?: string;
}

/**
 * @class
 * Initializes a new instance of the OdataProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [odatanextLink]
 */
export interface OdataProductResult {
  values?: Product[];
  odatanextLink?: string;
}

/**
 * @class
 * Initializes a new instance of the OperationResult class.
 * @constructor
 * @member {string} [status] The status of the request. Possible values
 * include: 'Succeeded', 'Failed', 'canceled', 'Accepted', 'Creating',
 * 'Created', 'Updating', 'Updated', 'Deleting', 'Deleted', 'OK'
 */
export interface OperationResult {
  status?: string;
}

/**
 * @class
 * Initializes a new instance of the PagingGetMultiplePagesOptions class.
 * @constructor
 * Additional parameters for the Paging_getMultiplePages operation.
 *
 * @member {number} [maxresults] Sets the maximum number of items to return in
 * the response.
 * @member {number} [timeout] Sets the maximum time that the server can spend
 * processing the request, in seconds. The default is 30 seconds. Default
 * value: 30 .
 */
export interface PagingGetMultiplePagesOptions {
  maxresults?: number;
  timeout?: number;
}

/**
 * @class
 * Initializes a new instance of the PagingGetOdataMultiplePagesOptions class.
 * @constructor
 * Additional parameters for the Paging_getOdataMultiplePages operation.
 *
 * @member {number} [maxresults] Sets the maximum number of items to return in
 * the response.
 * @member {number} [timeout] Sets the maximum time that the server can spend
 * processing the request, in seconds. The default is 30 seconds. Default
 * value: 30 .
 */
export interface PagingGetOdataMultiplePagesOptions {
  maxresults?: number;
  timeout?: number;
}

/**
 * @class
 * Initializes a new instance of the PagingGetMultiplePagesWithOffsetOptions class.
 * @constructor
 * Additional parameters for the Paging_getMultiplePagesWithOffset operation.
 *
 * @member {number} [maxresults] Sets the maximum number of items to return in
 * the response.
 * @member {number} offset Offset of return value
 * @member {number} [timeout] Sets the maximum time that the server can spend
 * processing the request, in seconds. The default is 30 seconds. Default
 * value: 30 .
 */
export interface PagingGetMultiplePagesWithOffsetOptions {
  maxresults?: number;
  offset: number;
  timeout?: number;
}

/**
 * @class
 * Initializes a new instance of the CustomParameterGroup class.
 * @constructor
 * Additional parameters for a set of operations, such as:
 * Paging_getMultiplePagesFragmentWithGroupingNextLink,
 * Paging_nextFragmentWithGrouping.
 *
 * @member {string} apiVersion Sets the api version to use.
 * @member {string} tenant Sets the tenant to use.
 */
export interface CustomParameterGroup {
  apiVersion: string;
  tenant: string;
}

/**
 * @class
 * Initializes a new instance of the PagingGetMultiplePagesWithOffsetNextOptions class.
 * @constructor
 * Additional parameters for the getMultiplePagesWithOffsetNext operation.
 *
 * @member {number} [maxresults] Sets the maximum number of items to return in
 * the response.
 * @member {number} [timeout] Sets the maximum time that the server can spend
 * processing the request, in seconds. The default is 30 seconds. Default
 * value: 30 .
 */
export interface PagingGetMultiplePagesWithOffsetNextOptions {
  maxresults?: number;
  timeout?: number;
}

/**
 * @class
 * Initializes a new instance of the ProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [nextLink]
 */
export interface ProductResult {
  values?: Product[];
  nextLink?: string;
}

/**
 * @class
 * Initializes a new instance of the OdataProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [odatanextLink]
 */
export interface OdataProductResult {
  values?: Product[];
  odatanextLink?: string;
}


/**
 * @class
 * Initializes a new instance of the ProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [nextLink]
 */
export interface ProductResult extends Array<Product> {
  nextLink?: string;
}

/**
 * @class
 * Initializes a new instance of the OdataProductResult class.
 * @constructor
 * @member {array} [values]
 * @member {string} [odatanextLink]
 */
export interface OdataProductResult extends Array<Product> {
  odatanextLink?: string;
}
