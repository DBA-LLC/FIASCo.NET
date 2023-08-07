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
    /// Подсказки для поиска, полученые от сервиса
    /// </summary>
    [DataContract(Name = "HintResult")]
    public partial class HintResult : IEquatable<HintResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HintResult" /> class.
        /// </summary>
        /// <param name="hints">Список подсказок для поиска.</param>
        public HintResult(List<AddressHintItem> hints = default(List<AddressHintItem>))
        {
            this.Hints = hints;
        }

        /// <summary>
        /// Список подсказок для поиска
        /// </summary>
        /// <value>Список подсказок для поиска</value>
        [DataMember(Name = "hints", EmitDefaultValue = true)]
        public List<AddressHintItem> Hints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HintResult {\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
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
            return this.Equals(input as HintResult);
        }

        /// <summary>
        /// Returns true if HintResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HintResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HintResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hints == input.Hints ||
                    this.Hints != null &&
                    input.Hints != null &&
                    this.Hints.SequenceEqual(input.Hints)
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
                if (this.Hints != null)
                {
                    hashCode = (hashCode * 59) + this.Hints.GetHashCode();
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