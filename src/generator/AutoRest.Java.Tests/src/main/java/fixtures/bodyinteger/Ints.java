/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodyinteger;

import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.bodyinteger.models.ErrorException;
import java.io.IOException;
import org.joda.time.DateTime;

/**
 * An instance of this class provides access to all the operations defined
 * in Ints.
 */
public interface Ints {
    /**
     * Get null Int value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getNull() throws ErrorException, IOException;

    /**
     * Get null Int value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Integer>> getNullAsync(final ServiceCallback<Integer> serviceCallback) throws IllegalArgumentException;

    /**
     * Get invalid Int value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getInvalid() throws ErrorException, IOException;

    /**
     * Get invalid Int value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Integer>> getInvalidAsync(final ServiceCallback<Integer> serviceCallback) throws IllegalArgumentException;

    /**
     * Get overflow Int32 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getOverflowInt32() throws ErrorException, IOException;

    /**
     * Get overflow Int32 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Integer>> getOverflowInt32Async(final ServiceCallback<Integer> serviceCallback) throws IllegalArgumentException;

    /**
     * Get underflow Int32 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getUnderflowInt32() throws ErrorException, IOException;

    /**
     * Get underflow Int32 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Integer>> getUnderflowInt32Async(final ServiceCallback<Integer> serviceCallback) throws IllegalArgumentException;

    /**
     * Get overflow Int64 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the long object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Long> getOverflowInt64() throws ErrorException, IOException;

    /**
     * Get overflow Int64 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Long>> getOverflowInt64Async(final ServiceCallback<Long> serviceCallback) throws IllegalArgumentException;

    /**
     * Get underflow Int64 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the long object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Long> getUnderflowInt64() throws ErrorException, IOException;

    /**
     * Get underflow Int64 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Long>> getUnderflowInt64Async(final ServiceCallback<Long> serviceCallback) throws IllegalArgumentException;

    /**
     * Put max int32 value.
     *
     * @param intBody the int value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMax32(int intBody) throws ErrorException, IOException;

    /**
     * Put max int32 value.
     *
     * @param intBody the int value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putMax32Async(int intBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Put max int64 value.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMax64(long intBody) throws ErrorException, IOException;

    /**
     * Put max int64 value.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putMax64Async(long intBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Put min int32 value.
     *
     * @param intBody the int value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMin32(int intBody) throws ErrorException, IOException;

    /**
     * Put min int32 value.
     *
     * @param intBody the int value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putMin32Async(int intBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Put min int64 value.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMin64(long intBody) throws ErrorException, IOException;

    /**
     * Put min int64 value.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putMin64Async(long intBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Get datetime encoded as Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getUnixTime() throws ErrorException, IOException;

    /**
     * Get datetime encoded as Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<DateTime>> getUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback) throws IllegalArgumentException;

    /**
     * Put datetime encoded as Unix time.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putUnixTimeDate(DateTime intBody) throws ErrorException, IOException;

    /**
     * Put datetime encoded as Unix time.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<Void>> putUnixTimeDateAsync(DateTime intBody, final ServiceCallback<Void> serviceCallback) throws IllegalArgumentException;

    /**
     * Get invalid Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getInvalidUnixTime() throws ErrorException, IOException;

    /**
     * Get invalid Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<DateTime>> getInvalidUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback) throws IllegalArgumentException;

    /**
     * Get null Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getNullUnixTime() throws ErrorException, IOException;

    /**
     * Get null Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link ServiceCall} object
     */
    ServiceCall<ServiceResponse<DateTime>> getNullUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback) throws IllegalArgumentException;

}
