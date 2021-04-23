// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using BaseBlobServiceClientProvider = Microsoft.Azure.WebJobs.StorageProvider.Blobs.BlobServiceClientProvider;

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs
{
    internal class BlobServiceClientProvider : BaseBlobServiceClientProvider
    {
        public BlobServiceClientProvider(IConfiguration configuration, AzureComponentFactory componentFactory, AzureEventSourceLogForwarder logForwarder, ILogger<BlobServiceClient> logger)
            : base(configuration, componentFactory, logForwarder, logger) {}
    }
}
