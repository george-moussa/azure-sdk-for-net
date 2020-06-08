// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse nested debug resource. </summary>
    public partial class SubResourceDebugResource
    {
        /// <summary> Initializes a new instance of SubResourceDebugResource. </summary>
        public SubResourceDebugResource()
        {
        }

        /// <summary> Initializes a new instance of SubResourceDebugResource. </summary>
        /// <param name="name"> The resource name. </param>
        internal SubResourceDebugResource(string name)
        {
            Name = name;
        }

        /// <summary> The resource name. </summary>
        public string Name { get; set; }
    }
}