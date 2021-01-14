// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The identity of the Batch account, if configured. This is only used
    /// when the user specifies 'Microsoft.KeyVault' as their Batch account
    /// encryption configuration.
    /// </summary>
    public partial class BatchAccountIdentity
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountIdentity class.
        /// </summary>
        public BatchAccountIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccountIdentity class.
        /// </summary>
        /// <param name="type">The type of identity used for the Batch account.
        /// Possible values include: 'SystemAssigned', 'UserAssigned',
        /// 'None'</param>
        /// <param name="principalId">The principal id of the Batch account.
        /// This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="tenantId">The tenant id associated with the Batch
        /// account. This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="userAssignedIdentities">The list of user identities
        /// associated with the Batch account. The user identity dictionary key
        /// references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.</param>
        public BatchAccountIdentity(ResourceIdentityType type, string principalId = default(string), string tenantId = default(string), IDictionary<string, BatchAccountIdentityUserAssignedIdentitiesValue> userAssignedIdentities = default(IDictionary<string, BatchAccountIdentityUserAssignedIdentitiesValue>))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of the Batch account. This property will only
        /// be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id associated with the Batch account. This property
        /// will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the type of identity used for the Batch account.
        /// Possible values include: 'SystemAssigned', 'UserAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType Type { get; set; }

        /// <summary>
        /// Gets or sets the list of user identities associated with the Batch
        /// account. The user identity dictionary key references will be ARM
        /// resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, BatchAccountIdentityUserAssignedIdentitiesValue> UserAssignedIdentities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
