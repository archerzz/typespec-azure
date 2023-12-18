// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated />

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.TypeSpec.ProviderHub.Controller;

namespace Microsoft.Contoso.Service.Models
{
    /// <summary>
    /// Details of the Contoso Employee.
    /// </summary>
    public partial class EmployeeProperties : ISerializationTracker
    {

        /// <summary>
        /// Extensibility point - allows changing class properties during construction.
        /// </summary>
        partial void OnBeforeInitialize();

        /// <summary>
        /// Extensibility point - allows changing class properties during construction.
        /// </summary>
        partial void OnAfterInitialize();

        /// <summary>
        /// Initializes a new instance of the EmployeeProperties class.
        /// </summary>
        public EmployeeProperties()
        {
            OnBeforeInitialize();
            OnAfterInitialize();
        }

        /// <summary>
        /// The status of the last operation.
        /// </summary>
        [JsonProperty("provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }


        /// <summary>
        /// Tracks deserialization of the resource.
        /// </summary>
        [JsonIgnore]
        public ResourceSerializationInfo SerializationInfo { get; set; } = new DefaultSerializationInfo();
    }
}