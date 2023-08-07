/*
 * SPAS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FIASCo.Client.OpenAPIDateConverter;

namespace FIASCo.Model
{
    /// <summary>
    /// AddressItem
    /// </summary>
    [DataContract(Name = "AddressItem")]
    public partial class AddressItem : IEquatable<AddressItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ObjectLevelId
        /// </summary>
        [DataMember(Name = "object_level_id", EmitDefaultValue = false)]
        public AddressLevel? ObjectLevelId { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name = "address_type", EmitDefaultValue = false)]
        public AddressType? AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressItem" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="objectLevelId">objectLevelId.</param>
        /// <param name="operationTypeId">operationTypeId.</param>
        /// <param name="objectGuid">objectGuid.</param>
        /// <param name="addressType">addressType.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="regionCode">regionCode.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="path">path.</param>
        /// <param name="addressDetails">addressDetails.</param>
        /// <param name="successorRef">successorRef.</param>
        /// <param name="hierarchy">hierarchy.</param>
        public AddressItem(long objectId = default(long), AddressLevel? objectLevelId = default(AddressLevel?), int? operationTypeId = default(int?), Guid objectGuid = default(Guid), AddressType? addressType = default(AddressType?), string fullName = default(string), int regionCode = default(int), bool isActive = default(bool), string path = default(string), AddressDetails addressDetails = default(AddressDetails), ObjectRef successorRef = default(ObjectRef), List<AddressPart> hierarchy = default(List<AddressPart>))
        {
            this.ObjectId = objectId;
            this.ObjectLevelId = objectLevelId;
            this.OperationTypeId = operationTypeId;
            this.ObjectGuid = objectGuid;
            this.AddressType = addressType;
            this.FullName = fullName;
            this.RegionCode = regionCode;
            this.IsActive = isActive;
            this.Path = path;
            this.AddressDetails = addressDetails;
            this.SuccessorRef = successorRef;
            this.Hierarchy = hierarchy;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "object_id", EmitDefaultValue = false)]
        public long ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets OperationTypeId
        /// </summary>
        [DataMember(Name = "operation_type_id", EmitDefaultValue = true)]
        public int? OperationTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectGuid
        /// </summary>
        [DataMember(Name = "object_guid", EmitDefaultValue = false)]
        public Guid ObjectGuid { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets RegionCode
        /// </summary>
        [DataMember(Name = "region_code", EmitDefaultValue = false)]
        public int RegionCode { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets AddressDetails
        /// </summary>
        [DataMember(Name = "address_details", EmitDefaultValue = false)]
        public AddressDetails AddressDetails { get; set; }

        /// <summary>
        /// Gets or Sets SuccessorRef
        /// </summary>
        [DataMember(Name = "successor_ref", EmitDefaultValue = false)]
        public ObjectRef SuccessorRef { get; set; }

        /// <summary>
        /// Gets or Sets Hierarchy
        /// </summary>
        [DataMember(Name = "hierarchy", EmitDefaultValue = true)]
        public List<AddressPart> Hierarchy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressItem {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectLevelId: ").Append(ObjectLevelId).Append("\n");
            sb.Append("  OperationTypeId: ").Append(OperationTypeId).Append("\n");
            sb.Append("  ObjectGuid: ").Append(ObjectGuid).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  AddressDetails: ").Append(AddressDetails).Append("\n");
            sb.Append("  SuccessorRef: ").Append(SuccessorRef).Append("\n");
            sb.Append("  Hierarchy: ").Append(Hierarchy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressItem);
        }

        /// <summary>
        /// Returns true if AddressItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectId == input.ObjectId ||
                    this.ObjectId.Equals(input.ObjectId)
                ) && 
                (
                    this.ObjectLevelId == input.ObjectLevelId ||
                    this.ObjectLevelId.Equals(input.ObjectLevelId)
                ) && 
                (
                    this.OperationTypeId == input.OperationTypeId ||
                    (this.OperationTypeId != null &&
                    this.OperationTypeId.Equals(input.OperationTypeId))
                ) && 
                (
                    this.ObjectGuid == input.ObjectGuid ||
                    (this.ObjectGuid != null &&
                    this.ObjectGuid.Equals(input.ObjectGuid))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    this.AddressType.Equals(input.AddressType)
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.RegionCode == input.RegionCode ||
                    this.RegionCode.Equals(input.RegionCode)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.AddressDetails == input.AddressDetails ||
                    (this.AddressDetails != null &&
                    this.AddressDetails.Equals(input.AddressDetails))
                ) && 
                (
                    this.SuccessorRef == input.SuccessorRef ||
                    (this.SuccessorRef != null &&
                    this.SuccessorRef.Equals(input.SuccessorRef))
                ) && 
                (
                    this.Hierarchy == input.Hierarchy ||
                    this.Hierarchy != null &&
                    input.Hierarchy != null &&
                    this.Hierarchy.SequenceEqual(input.Hierarchy)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.ObjectId.GetHashCode();
                hashCode = (hashCode * 59) + this.ObjectLevelId.GetHashCode();
                if (this.OperationTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationTypeId.GetHashCode();
                }
                if (this.ObjectGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddressType.GetHashCode();
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RegionCode.GetHashCode();
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.AddressDetails != null)
                {
                    hashCode = (hashCode * 59) + this.AddressDetails.GetHashCode();
                }
                if (this.SuccessorRef != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessorRef.GetHashCode();
                }
                if (this.Hierarchy != null)
                {
                    hashCode = (hashCode * 59) + this.Hierarchy.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}