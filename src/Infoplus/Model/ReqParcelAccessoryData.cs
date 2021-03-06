/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// ReqParcelAccessoryData
    /// </summary>
    [DataContract]
    public partial class ReqParcelAccessoryData :  IEquatable<ReqParcelAccessoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReqParcelAccessoryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReqParcelAccessoryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReqParcelAccessoryData" /> class.
        /// </summary>
        /// <param name="Accessory">Accessory (required).</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public ReqParcelAccessoryData(string Accessory = default(string), decimal? Amount = default(decimal?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Accessory" is required (not null)
            if (Accessory == null)
            {
                throw new InvalidDataException("Accessory is a required property for ReqParcelAccessoryData and cannot be null");
            }
            else
            {
                this.Accessory = Accessory;
            }
            this.Amount = Amount;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Accessory
        /// </summary>
        [DataMember(Name="accessory", EmitDefaultValue=false)]
        public string Accessory { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqParcelAccessoryData {\n");
            sb.Append("  Accessory: ").Append(Accessory).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReqParcelAccessoryData);
        }

        /// <summary>
        /// Returns true if ReqParcelAccessoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of ReqParcelAccessoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReqParcelAccessoryData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accessory == input.Accessory ||
                    (this.Accessory != null &&
                    this.Accessory.Equals(input.Accessory))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.Accessory != null)
                    hashCode = hashCode * 59 + this.Accessory.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
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
