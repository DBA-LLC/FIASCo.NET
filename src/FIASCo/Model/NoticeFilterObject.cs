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
    /// NoticeFilterObject
    /// </summary>
    [DataContract(Name = "NoticeFilterObject")]
    public partial class NoticeFilterObject : IEquatable<NoticeFilterObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeFilterObject" /> class.
        /// </summary>
        /// <param name="senderCode">senderCode.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="status">status.</param>
        /// <param name="parentObjectGuid">parentObjectGuid.</param>
        public NoticeFilterObject(string senderCode = default(string), string requestId = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), int? status = default(int?), Guid? parentObjectGuid = default(Guid?))
        {
            this.SenderCode = senderCode;
            this.RequestId = requestId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Status = status;
            this.ParentObjectGuid = parentObjectGuid;
        }

        /// <summary>
        /// Gets or Sets SenderCode
        /// </summary>
        [DataMember(Name = "sender_code", EmitDefaultValue = true)]
        public string SenderCode { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "request_id", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets ParentObjectGuid
        /// </summary>
        [DataMember(Name = "parent_object_guid", EmitDefaultValue = true)]
        public Guid? ParentObjectGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoticeFilterObject {\n");
            sb.Append("  SenderCode: ").Append(SenderCode).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ParentObjectGuid: ").Append(ParentObjectGuid).Append("\n");
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
            return this.Equals(input as NoticeFilterObject);
        }

        /// <summary>
        /// Returns true if NoticeFilterObject instances are equal
        /// </summary>
        /// <param name="input">Instance of NoticeFilterObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoticeFilterObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SenderCode == input.SenderCode ||
                    (this.SenderCode != null &&
                    this.SenderCode.Equals(input.SenderCode))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ParentObjectGuid == input.ParentObjectGuid ||
                    (this.ParentObjectGuid != null &&
                    this.ParentObjectGuid.Equals(input.ParentObjectGuid))
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
                if (this.SenderCode != null)
                {
                    hashCode = (hashCode * 59) + this.SenderCode.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.ParentObjectGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ParentObjectGuid.GetHashCode();
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