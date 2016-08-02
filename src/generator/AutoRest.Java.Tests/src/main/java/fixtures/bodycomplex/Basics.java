/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex;

import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.bodycomplex.models.Basic;
import fixtures.bodycomplex.models.ErrorException;
import java.io.IOException;

/**
 * An instance of this class provides access to all the operations defined
 * in Basics.
 */
public interface Basics {
    /**
     * Get complex type {id: 2, name: 'abc', color: 'YELLOW'}.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Basic object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Basic> getValid() throws ErrorException, IOException;

    /**
     * Get complex type {id: 2, name: 'abc', color: 'YELLOW'}.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Basic>> getValidAsync(final ServiceCallback<Basic> serviceCallback) throws IllegalArgumentException;

    /**
     * Please put {id: 2, name: 'abc', color: 'Magenta'}.
     *
     * @param complexBody Please put {id: 2, name: 'abc', color: 'Magenta'}
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putValid(Basic complexBody) throws ErrorException, IOException, IllegalArgumentException;

    /**
     * Please put {id: 2, name: 'abc', color: 'Magenta'}.
     *
     * @param complexBody Please put {id: 2, name: 'abc', color: 'Magenta'}
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putValidAsync(Basic complexBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Get a basic complex type that is invalid for the local strong type.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Basic object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Basic> getInvalid() throws ErrorException, IOException;

    /**
     * Get a basic complex type that is invalid for the local strong type.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Basic>> getInvalidAsync(final ServiceCallback<Basic> serviceCallback) throws IllegalArgumentException;

    /**
     * Get a basic complex type that is empty.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Basic object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Basic> getEmpty() throws ErrorException, IOException;

    /**
     * Get a basic complex type that is empty.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Basic>> getEmptyAsync(final ServiceCallback<Basic> serviceCallback) throws IllegalArgumentException;

    /**
     * Get a basic complex type whose properties are null.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Basic object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Basic> getNull() throws ErrorException, IOException;

    /**
     * Get a basic complex type whose properties are null.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Basic>> getNullAsync(final ServiceCallback<Basic> serviceCallback) throws IllegalArgumentException;

    /**
     * Get a basic complex type while the server doesn't provide a response payload.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Basic object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Basic> getNotProvided() throws ErrorException, IOException;

    /**
     * Get a basic complex type while the server doesn't provide a response payload.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Basic>> getNotProvidedAsync(final ServiceCallback<Basic> serviceCallback) throws IllegalArgumentException;

}
