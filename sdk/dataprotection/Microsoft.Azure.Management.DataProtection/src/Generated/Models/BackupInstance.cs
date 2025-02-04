// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Backup Instance
    /// </summary>
    public partial class BackupInstance
    {
        /// <summary>
        /// Initializes a new instance of the BackupInstance class.
        /// </summary>
        public BackupInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupInstance class.
        /// </summary>
        /// <param name="dataSourceInfo">Gets or sets the data source
        /// information.</param>
        /// <param name="policyInfo">Gets or sets the policy
        /// information.</param>
        /// <param name="friendlyName">Gets or sets the Backup Instance
        /// friendly name.</param>
        /// <param name="dataSourceSetInfo">Gets or sets the data source set
        /// information.</param>
        /// <param name="protectionStatus">Specifies the protection status of
        /// the resource</param>
        /// <param name="currentProtectionState">Specifies the current
        /// protection state of the resource. Possible values include:
        /// 'Invalid', 'NotProtected', 'ConfiguringProtection',
        /// 'ProtectionConfigured', 'BackupSchedulesSuspended',
        /// 'RetentionSchedulesSuspended', 'ProtectionStopped',
        /// 'ProtectionError', 'ConfiguringProtectionFailed', 'SoftDeleting',
        /// 'SoftDeleted', 'UpdatingProtection'</param>
        /// <param name="protectionErrorDetails">Specifies the protection error
        /// of the resource</param>
        /// <param name="provisioningState">Specifies the provisioning state of
        /// the resource i.e. provisioning/updating/Succeeded/Failed</param>
        public BackupInstance(Datasource dataSourceInfo, PolicyInfo policyInfo, string objectType, string friendlyName = default(string), DatasourceSet dataSourceSetInfo = default(DatasourceSet), ProtectionStatusDetails protectionStatus = default(ProtectionStatusDetails), string currentProtectionState = default(string), UserFacingError protectionErrorDetails = default(UserFacingError), string provisioningState = default(string))
        {
            FriendlyName = friendlyName;
            DataSourceInfo = dataSourceInfo;
            DataSourceSetInfo = dataSourceSetInfo;
            PolicyInfo = policyInfo;
            ProtectionStatus = protectionStatus;
            CurrentProtectionState = currentProtectionState;
            ProtectionErrorDetails = protectionErrorDetails;
            ProvisioningState = provisioningState;
            ObjectType = objectType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Backup Instance friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the data source information.
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceInfo")]
        public Datasource DataSourceInfo { get; set; }

        /// <summary>
        /// Gets or sets the data source set information.
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceSetInfo")]
        public DatasourceSet DataSourceSetInfo { get; set; }

        /// <summary>
        /// Gets or sets the policy information.
        /// </summary>
        [JsonProperty(PropertyName = "policyInfo")]
        public PolicyInfo PolicyInfo { get; set; }

        /// <summary>
        /// Gets specifies the protection status of the resource
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public ProtectionStatusDetails ProtectionStatus { get; private set; }

        /// <summary>
        /// Gets specifies the current protection state of the resource.
        /// Possible values include: 'Invalid', 'NotProtected',
        /// 'ConfiguringProtection', 'ProtectionConfigured',
        /// 'BackupSchedulesSuspended', 'RetentionSchedulesSuspended',
        /// 'ProtectionStopped', 'ProtectionError',
        /// 'ConfiguringProtectionFailed', 'SoftDeleting', 'SoftDeleted',
        /// 'UpdatingProtection'
        /// </summary>
        [JsonProperty(PropertyName = "currentProtectionState")]
        public string CurrentProtectionState { get; private set; }

        /// <summary>
        /// Gets specifies the protection error of the resource
        /// </summary>
        [JsonProperty(PropertyName = "protectionErrorDetails")]
        public UserFacingError ProtectionErrorDetails { get; private set; }

        /// <summary>
        /// Gets specifies the provisioning state of the resource i.e.
        /// provisioning/updating/Succeeded/Failed
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSourceInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceInfo");
            }
            if (PolicyInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PolicyInfo");
            }
            if (ObjectType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectType");
            }
            if (DataSourceInfo != null)
            {
                DataSourceInfo.Validate();
            }
            if (DataSourceSetInfo != null)
            {
                DataSourceSetInfo.Validate();
            }
            if (PolicyInfo != null)
            {
                PolicyInfo.Validate();
            }
        }
    }
}
