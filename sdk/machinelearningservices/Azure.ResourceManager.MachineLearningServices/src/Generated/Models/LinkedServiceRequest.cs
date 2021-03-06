// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> object used for creating linked service. </summary>
    public partial class LinkedServiceRequest
    {
        /// <summary> Initializes a new instance of LinkedServiceRequest. </summary>
        public LinkedServiceRequest()
        {
        }

        /// <summary> Friendly name of the linked service. </summary>
        public string Name { get; set; }
        /// <summary> location of the linked service. </summary>
        public string Location { get; set; }
        /// <summary> Identity for the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> LinkedService specific properties. </summary>
        public LinkedServiceProps Properties { get; set; }
    }
}
