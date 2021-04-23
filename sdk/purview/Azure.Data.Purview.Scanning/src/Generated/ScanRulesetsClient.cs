// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

#pragma warning disable AZC0007

namespace Azure.Data.Purview.Scanning
{
    /// <summary> The ScanRulesets service client. </summary>
    public partial class ScanRulesetsClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private Uri endpoint;
        private readonly string apiVersion;

        /// <summary> Initializes a new instance of ScanRulesetsClient for mocking. </summary>
        protected ScanRulesetsClient()
        {
        }

        /// <summary> Initializes a new instance of ScanRulesetsClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.scan.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ScanRulesetsClient(Uri endpoint, TokenCredential credential, ScanningClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ScanningClientOptions();
            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes));
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Get a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAsync(string scanRulesetName, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetRequest(scanRulesetName);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get(string scanRulesetName, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetRequest(scanRulesetName);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="Get"/> and <see cref="GetAsync"/> operations. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        private Request CreateGetRequest(string scanRulesetName)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scanrulesets/", false);
            uri.AppendPath(scanRulesetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Creates or Updates a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CreateOrUpdateAsync(string scanRulesetName, RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCreateOrUpdateRequest(scanRulesetName, requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates or Updates a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CreateOrUpdate(string scanRulesetName, RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCreateOrUpdateRequest(scanRulesetName, requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CreateOrUpdate"/> and <see cref="CreateOrUpdateAsync"/> operations. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="requestBody"> The request body. </param>
        private Request CreateCreateOrUpdateRequest(string scanRulesetName, RequestContent requestBody)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scanrulesets/", false);
            uri.AppendPath(scanRulesetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }

        /// <summary> Deletes a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string scanRulesetName, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteRequest(scanRulesetName);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a scan ruleset. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string scanRulesetName, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteRequest(scanRulesetName);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="Delete"/> and <see cref="DeleteAsync"/> operations. </summary>
        /// <param name="scanRulesetName"> The String to use. </param>
        private Request CreateDeleteRequest(string scanRulesetName)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scanrulesets/", false);
            uri.AppendPath(scanRulesetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> List scan rulesets in Data catalog. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ListAllAsync(CancellationToken cancellationToken = default)
        {
            Request req = CreateListAllRequest();
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> List scan rulesets in Data catalog. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ListAll(CancellationToken cancellationToken = default)
        {
            Request req = CreateListAllRequest();
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="ListAll"/> and <see cref="ListAllAsync"/> operations. </summary>
        private Request CreateListAllRequest()
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scanrulesets", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }
    }
}
