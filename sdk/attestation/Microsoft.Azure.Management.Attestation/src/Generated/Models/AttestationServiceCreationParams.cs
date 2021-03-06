// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for creating an attestation service instance
    /// </summary>
    public partial class AttestationServiceCreationParams : IResource
    {
        /// <summary>
        /// Initializes a new instance of the AttestationServiceCreationParams
        /// class.
        /// </summary>
        public AttestationServiceCreationParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttestationServiceCreationParams
        /// class.
        /// </summary>
        /// <param name="location">The supported Azure location where the
        /// attestation service instance should be created.</param>
        /// <param name="properties">Properties of the attestation service
        /// instance</param>
        /// <param name="tags">The tags that will be assigned to the
        /// attestation service instance.</param>
        public AttestationServiceCreationParams(string location, AttestationServiceCreationSpecificParams properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the supported Azure location where the attestation
        /// service instance should be created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags that will be assigned to the attestation
        /// service instance.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the attestation service instance
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AttestationServiceCreationSpecificParams Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
        }
    }
}
