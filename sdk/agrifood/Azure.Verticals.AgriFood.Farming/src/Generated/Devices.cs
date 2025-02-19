// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated sub-client.
    /// <summary> The Devices sub-client. </summary>
    public partial class Devices
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Devices for mocking. </summary>
        protected Devices()
        {
        }

        /// <summary> Initializes a new instance of Devices. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal Devices(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Create a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/>, <paramref name="deviceId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='CreateOrUpdateAsync(string,string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateAsync(string sensorPartnerId, string deviceId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Devices.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(sensorPartnerId, deviceId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/>, <paramref name="deviceId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='CreateOrUpdate(string,string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdate(string sensorPartnerId, string deviceId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Devices.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(sensorPartnerId, deviceId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='GetDeviceAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> GetDeviceAsync(string sensorPartnerId, string deviceId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));

            using var scope = ClientDiagnostics.CreateScope("Devices.GetDevice");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDeviceRequest(sensorPartnerId, deviceId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='GetDevice(string,string,RequestContext)']/*" />
        public virtual Response GetDevice(string sensorPartnerId, string deviceId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));

            using var scope = ClientDiagnostics.CreateScope("Devices.GetDevice");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDeviceRequest(sensorPartnerId, deviceId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='DeleteAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> DeleteAsync(string sensorPartnerId, string deviceId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));

            using var scope = ClientDiagnostics.CreateScope("Devices.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(sensorPartnerId, deviceId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a device entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="deviceId"> Id of the device resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="deviceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='Delete(string,string,RequestContext)']/*" />
        public virtual Response Delete(string sensorPartnerId, string deviceId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));
            Argument.AssertNotNullOrEmpty(deviceId, nameof(deviceId));

            using var scope = ClientDiagnostics.CreateScope("Devices.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(sensorPartnerId, deviceId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of device resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the associated sensor partner. </param>
        /// <param name="parentDeviceIds"> Id&apos;s of the parent devices. </param>
        /// <param name="deviceDataModelIds"> Id&apos;s of the device data models. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='GetDevicesAsync(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetDevicesAsync(string sensorPartnerId, IEnumerable<string> parentDeviceIds = null, IEnumerable<string> deviceDataModelIds = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetDevicesRequest(sensorPartnerId, parentDeviceIds, deviceDataModelIds, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetDevicesNextPageRequest(nextLink, sensorPartnerId, parentDeviceIds, deviceDataModelIds, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Devices.GetDevices", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of device resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the associated sensor partner. </param>
        /// <param name="parentDeviceIds"> Id&apos;s of the parent devices. </param>
        /// <param name="deviceDataModelIds"> Id&apos;s of the device data models. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Devices.xml" path="doc/members/member[@name='GetDevices(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetDevices(string sensorPartnerId, IEnumerable<string> parentDeviceIds = null, IEnumerable<string> deviceDataModelIds = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(sensorPartnerId, nameof(sensorPartnerId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetDevicesRequest(sensorPartnerId, parentDeviceIds, deviceDataModelIds, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetDevicesNextPageRequest(nextLink, sensorPartnerId, parentDeviceIds, deviceDataModelIds, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Devices.GetDevices", "value", "nextLink", context);
        }

        internal HttpMessage CreateGetDevicesRequest(string sensorPartnerId, IEnumerable<string> parentDeviceIds, IEnumerable<string> deviceDataModelIds, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/devices", false);
            if (parentDeviceIds != null && Optional.IsCollectionDefined(parentDeviceIds))
            {
                foreach (var param in parentDeviceIds)
                {
                    uri.AppendQuery("parentDeviceIds", param, true);
                }
            }
            if (deviceDataModelIds != null && Optional.IsCollectionDefined(deviceDataModelIds))
            {
                foreach (var param in deviceDataModelIds)
                {
                    uri.AppendQuery("deviceDataModelIds", param, true);
                }
            }
            if (ids != null && Optional.IsCollectionDefined(ids))
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null && Optional.IsCollectionDefined(names))
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null && Optional.IsCollectionDefined(propertyFilters))
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null && Optional.IsCollectionDefined(statuses))
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string sensorPartnerId, string deviceId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetDeviceRequest(string sensorPartnerId, string deviceId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string sensorPartnerId, string deviceId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetDevicesNextPageRequest(string nextLink, string sensorPartnerId, IEnumerable<string> parentDeviceIds, IEnumerable<string> deviceDataModelIds, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
