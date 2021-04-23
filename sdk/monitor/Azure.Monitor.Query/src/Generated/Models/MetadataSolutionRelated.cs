// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the Log Analytics solution. </summary>
    internal partial class MetadataSolutionRelated
    {
        /// <summary> Initializes a new instance of MetadataSolutionRelated. </summary>
        /// <param name="tables"> The tables related to the Log Analytics solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tables"/> is null. </exception>
        internal MetadataSolutionRelated(IEnumerable<string> tables)
        {
            if (tables == null)
            {
                throw new ArgumentNullException(nameof(tables));
            }

            Tables = tables.ToList();
            Functions = new ChangeTrackingList<string>();
            Categories = new ChangeTrackingList<string>();
            Queries = new ChangeTrackingList<string>();
            Workspaces = new ChangeTrackingList<string>();
        }

        /// <summary> The tables related to the Log Analytics solution. </summary>
        public IReadOnlyList<string> Tables { get; }
        /// <summary> The functions related to the Log Analytics solution. </summary>
        public IReadOnlyList<string> Functions { get; }
        /// <summary> The categories related to the Log Analytics solution. </summary>
        public IReadOnlyList<string> Categories { get; }
        /// <summary> The saved queries related to the Log Analytics solution. </summary>
        public IReadOnlyList<string> Queries { get; }
        /// <summary> The Workspaces referenced in the metadata request that are related to the Log Analytics solution. </summary>
        public IReadOnlyList<string> Workspaces { get; }
    }
}
