﻿namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System.CodeDom.Compiler;
    using System.Runtime.Serialization;

    /// <summary>
    /// Assembly that contains one or more plug-in types.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("pluginassembly")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginAssembly : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PluginAssembly() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "pluginassembly";

        public const int EntityTypeCode = 4605;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((PropertyChanging != null))
            {
                PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public OptionSetValue ComponentState
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Bytes of the assembly, in Base64 format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
        public string Content
        {
            get
            {
                return GetAttributeValue<string>("content");
            }
            set
            {
                OnPropertyChanging("Content");
                SetAttributeValue("content", value);
                OnPropertyChanged("Content");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public EntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.DateTime? CreatedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the pluginassembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Culture code for the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("culture")]
        public string Culture
        {
            get
            {
                return GetAttributeValue<string>("culture");
            }
            set
            {
                OnPropertyChanging("Culture");
                SetAttributeValue("culture", value);
                OnPropertyChanged("Culture");
            }
        }

        /// <summary>
        /// Customization Level.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get
            {
                return GetAttributeValue<int?>("customizationlevel");
            }
        }

        /// <summary>
        /// Description of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get
            {
                return GetAttributeValue<string>("description");
            }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Information that specifies whether this component should be hidden.
        /// </summary>
        [AttributeLogicalName("ishidden")]
        public BooleanManagedProperty IsHidden
        {
            get
            {
                return GetAttributeValue<BooleanManagedProperty>("ishidden");
            }
            set
            {
                OnPropertyChanging("IsHidden");
                SetAttributeValue("ishidden", value);
                OnPropertyChanged("IsHidden");
            }
        }

        /// <summary>
        /// Information that specifies whether this component is managed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get
            {
                return GetAttributeValue<bool?>("ismanaged");
            }
        }

        /// <summary>
        /// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isolationmode")]
        public OptionSetValue IsolationMode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("isolationmode");
            }
            set
            {
                OnPropertyChanging("IsolationMode");
                SetAttributeValue("isolationmode", value);
                OnPropertyChanged("IsolationMode");
            }
        }

        /// <summary>
        /// Major of the assembly version.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("major")]
        public System.Nullable<int> Major
        {
            get
            {
                return GetAttributeValue<int?>("major");
            }
        }

        /// <summary>
        /// Minor of the assembly version.
        /// </summary>
        [AttributeLogicalName("minor")]
        public System.Nullable<int> Minor
        {
            get
            {
                return GetAttributeValue<int?>("minor");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.DateTime? ModifiedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the pluginassembly.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Name of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get
            {
                return GetAttributeValue<string>("name");
            }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the organization with which the plug-in assembly is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get
            {
                return GetAttributeValue<EntityReference>("organizationid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public System.DateTime? OverwriteTime
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("overwritetime");
            }
        }

        /// <summary>
        /// File name of the plug-in assembly. Used when the source type is set to 1.
        /// </summary>
        [AttributeLogicalName("path")]
        public string Path
        {
            get
            {
                return GetAttributeValue<string>("path");
            }
            set
            {
                OnPropertyChanging("Path");
                SetAttributeValue("path", value);
                OnPropertyChanged("Path");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
        public System.Nullable<System.Guid> PluginAssemblyId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("pluginassemblyid");
            }
            set
            {
                OnPropertyChanging("PluginAssemblyId");
                SetAttributeValue("pluginassemblyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("PluginAssemblyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                PluginAssemblyId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyidunique")]
        public System.Nullable<System.Guid> PluginAssemblyIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("pluginassemblyidunique");
            }
        }

        /// <summary>
        /// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
        public string PublicKeyToken
        {
            get
            {
                return GetAttributeValue<string>("publickeytoken");
            }
            set
            {
                OnPropertyChanging("PublicKeyToken");
                SetAttributeValue("publickeytoken", value);
                OnPropertyChanged("PublicKeyToken");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("solutionid");
            }
        }

        /// <summary>
        /// Hash of the source of the assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcehash")]
        public string SourceHash
        {
            get
            {
                return GetAttributeValue<string>("sourcehash");
            }
            set
            {
                OnPropertyChanging("SourceHash");
                SetAttributeValue("sourcehash", value);
                OnPropertyChanged("SourceHash");
            }
        }

        /// <summary>
        /// Location of the assembly, for example 0=database, 1=on-disk.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetype")]
        public OptionSetValue SourceType
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("sourcetype");
            }
            set
            {
                OnPropertyChanging("SourceType");
                SetAttributeValue("sourcetype", value);
                OnPropertyChanged("SourceType");
            }
        }

        /// <summary>
        /// Version number of the assembly. The value can be obtained from the assembly through reflection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public string Version
        {
            get
            {
                return GetAttributeValue<string>("version");
            }
            set
            {
                OnPropertyChanging("Version");
                SetAttributeValue("version", value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N pluginassembly_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
        public System.Collections.Generic.IEnumerable<PluginType> pluginassembly_plugintype
        {
            get
            {
                return GetRelatedEntities<PluginType>("pluginassembly_plugintype", null);
            }
            set
            {
                OnPropertyChanging("pluginassembly_plugintype");
                SetRelatedEntities("pluginassembly_plugintype", null, value);
                OnPropertyChanged("pluginassembly_plugintype");
            }
        }
    }
}