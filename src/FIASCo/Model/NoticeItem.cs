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
    /// NoticeItem
    /// </summary>
    [DataContract(Name = "NoticeItem")]
    public partial class NoticeItem : IEquatable<NoticeItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeItem" /> class.
        /// </summary>
        /// <param name="noticeId">noticeId.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="notice">notice.</param>
        public NoticeItem(long noticeId = default(long), int status = default(int), DateTime statusDate = default(DateTime), Notice notice = default(Notice))
        {
            this.NoticeId = noticeId;
            this.Status = status;
            this.StatusDate = statusDate;
            this.Notice = notice;
        }

        /// <summary>
        /// Gets or Sets NoticeId
        /// </summary>
        [DataMember(Name = "notice_id", EmitDefaultValue = false)]
        public long NoticeId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name = "status_date", EmitDefaultValue = false)]
        public DateTime StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets Notice
        /// </summary>
        [DataMember(Name = "notice", EmitDefaultValue = false)]
        public Notice Notice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoticeItem {\n");
            sb.Append("  NoticeId: ").Append(NoticeId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  Notice: ").Append(Notice).Append("\n");
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
            return this.Equals(input as NoticeItem);
        }

        /// <summary>
        /// Returns true if NoticeItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NoticeItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoticeItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoticeId == input.NoticeId ||
                    this.NoticeId.Equals(input.NoticeId)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.Notice == input.Notice ||
                    (this.Notice != null &&
                    this.Notice.Equals(input.Notice))
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
                hashCode = (hashCode * 59) + this.NoticeId.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDate != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDate.GetHashCode();
                }
                if (this.Notice != null)
                {
                    hashCode = (hashCode * 59) + this.Notice.GetHashCode();
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
