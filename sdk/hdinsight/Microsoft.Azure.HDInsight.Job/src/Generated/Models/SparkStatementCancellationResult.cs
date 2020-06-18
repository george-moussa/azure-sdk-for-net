// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SparkStatementCancellationResult
    {
        /// <summary>
        /// Initializes a new instance of the SparkStatementCancellationResult
        /// class.
        /// </summary>
        public SparkStatementCancellationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkStatementCancellationResult
        /// class.
        /// </summary>
        public SparkStatementCancellationResult(string cancelMessage = default(string))
        {
            CancelMessage = cancelMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msg")]
        public string CancelMessage { get; set; }

    }
}