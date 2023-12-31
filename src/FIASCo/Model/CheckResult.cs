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
    /// Результат проверки
    /// </summary>
    [DataContract(Name = "CheckResult")]
    public partial class CheckResult : IEquatable<CheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckResult" /> class.
        /// </summary>
        /// <param name="check">Результат.</param>
        public CheckResult(bool check = default(bool))
        {
            this.Check = check;
        }

        /// <summary>
        /// Результат
        /// </summary>
        /// <value>Результат</value>
        [DataMember(Name = "check", EmitDefaultValue = true)]
        public bool Check { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckResult {\n");
            sb.Append("  Check: ").Append(Check).Append("\n");
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
            return this.Equals(input as CheckResult);
        }

        /// <summary>
        /// Returns true if CheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Check == input.Check ||
                    this.Check.Equals(input.Check)
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
                hashCode = (hashCode * 59) + this.Check.GetHashCode();
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
