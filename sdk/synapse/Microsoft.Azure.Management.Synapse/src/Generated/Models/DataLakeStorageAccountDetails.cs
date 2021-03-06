// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the data lake storage account associated with the workspace
    /// </summary>
    public partial class DataLakeStorageAccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeStorageAccountDetails
        /// class.
        /// </summary>
        public DataLakeStorageAccountDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataLakeStorageAccountDetails
        /// class.
        /// </summary>
        /// <param name="accountUrl">Account URL</param>
        /// <param name="filesystem">Filesystem name</param>
        public DataLakeStorageAccountDetails(string accountUrl = default(string), string filesystem = default(string))
        {
            AccountUrl = accountUrl;
            Filesystem = filesystem;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account URL
        /// </summary>
        [JsonProperty(PropertyName = "accountUrl")]
        public string AccountUrl { get; set; }

        /// <summary>
        /// Gets or sets filesystem name
        /// </summary>
        [JsonProperty(PropertyName = "filesystem")]
        public string Filesystem { get; set; }

    }
}
