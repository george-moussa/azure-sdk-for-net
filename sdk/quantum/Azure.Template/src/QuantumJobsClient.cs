// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;
using Azure.Quantum.Models;

namespace Azure.Quantum
{
    /// <summary>
    /// Quantum jobs client
    /// </summary>
    public class QuantumJobsClient
    {
        private readonly JobsRestClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantumJobsClient"/> class.
        /// Needed for mocking
        /// </summary>
        protected QuantumJobsClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantumJobsClient"/> class.
        /// </summary>
        /// <param name="subscriptionId">The subscription identifier.</param>
        /// <param name="resourceGroupName">Name of the resource group.</param>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="location">The location.</param>
        /// <param name="options">The options.</param>
        /// <param name="tokenCredential">The token credential.</param>
        public QuantumJobsClient(
            string subscriptionId,
            string resourceGroupName,
            string workspaceName,
            string location,
            QuantumJobsClientOptions options = default,
            TokenCredential tokenCredential = default)
        {
            if (options == null)
            {
                options = new QuantumJobsClientOptions();
            }

            if (tokenCredential == null)
            {
                tokenCredential = new DefaultAzureCredential(new DefaultAzureCredentialOptions());
            }

            var authPolicy = new BearerTokenAuthenticationPolicy(tokenCredential, "https://quantum.microsoft.com");

            client = new JobsRestClient(
                new ClientDiagnostics(options),
                HttpPipelineBuilder.Build(options, authPolicy),
                subscriptionId,
                resourceGroupName,
                workspaceName,
                new Uri($"https://{location}.quantum.azure.com"));
        }

        /// <summary>
        /// Lists the jobs.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>List of jobs</returns>
        public Task<Response<JobDetailsList>> ListJobs(CancellationToken cancellationToken)
        {
            return client.ListAsync(cancellationToken);
        }
    }
}
