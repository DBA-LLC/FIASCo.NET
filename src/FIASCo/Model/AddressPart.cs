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
    /// AddressPart
    /// </summary>
    [DataContract(Name = "AddressPart")]
    public partial class AddressPart : IEquatable<AddressPart>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ObjectLevelId
        /// </summary>
        [DataMember(Name = "object_level_id", EmitDefaultValue = false)]
        public AddressLevel? ObjectLevelId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressPart" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="objectLevelId">objectLevelId.</param>
        /// <param name="objectGuid">objectGuid.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="fullNameShort">fullNameShort.</param>
        public AddressPart(long objectId = default(long), AddressLevel? objectLevelId = default(AddressLevel?), Guid objectGuid = default(Guid), string fullName = default(string), string fullNameShort = default(string))
        {
            this.ObjectId = objectId;
            this.ObjectLevelId = objectLevelId;
            this.ObjectGuid = objectGuid;
            this.FullName = fullName;
            this.FullNameShort = fullNameShort;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "object_id", EmitDefaultValue = false)]
        public long ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectGuid
        /// </summary>
        [DataMember(Name = "object_guid", EmitDefaultValue = false)]
        public Guid ObjectGuid { get; set; }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name = "object_type", EmitDefaultValue = true)]
        public string ObjectType { get; private set; }

        /// <summary>
        /// Returns false as ObjectType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObjectType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets FullNameShort
        /// </summary>
        [DataMember(Name = "full_name_short", EmitDefaultValue = true)]
        public string FullNameShort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressPart {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectLevelId: ").Append(ObjectLevelId).Append("\n");
            sb.Append("  ObjectGuid: ").Append(ObjectGuid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  FullNameShort: ").Append(FullNameShort).Append("\n");
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
            return this.Equals(input as AddressPart);
        }

        /// <summary>
        /// Returns true if AddressPart instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressPart input)
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
                    this.ObjectGuid == input.ObjectGuid ||
                    (this.ObjectGuid != null &&
                    this.ObjectGuid.Equals(input.ObjectGuid))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.FullNameShort == input.FullNameShort ||
                    (this.FullNameShort != null &&
                    this.FullNameShort.Equals(input.FullNameShort))
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
                if (this.ObjectGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGuid.GetHashCode();
                }
                if (this.ObjectType != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectType.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.FullNameShort != null)
                {
                    hashCode = (hashCode * 59) + this.FullNameShort.GetHashCode();
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
