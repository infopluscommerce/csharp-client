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
    /// OrderLoadProgram
    /// </summary>
    [DataContract]
    public partial class OrderLoadProgram :  IEquatable<OrderLoadProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLoadProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderLoadProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLoadProgram" /> class.
        /// </summary>
        /// <param name="FullEntityClassName">FullEntityClassName.</param>
        public OrderLoadProgram(string FullEntityClassName = default(string))
        {
            this.FullEntityClassName = FullEntityClassName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; private set; }

        /// <summary>
        /// Gets or Sets FullEntityClassName
        /// </summary>
        [DataMember(Name="fullEntityClassName", EmitDefaultValue=false)]
        public string FullEntityClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLoadProgram {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  FullEntityClassName: ").Append(FullEntityClassName).Append("\n");
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
            return this.Equals(input as OrderLoadProgram);
        }

        /// <summary>
        /// Returns true if OrderLoadProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderLoadProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLoadProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.FullEntityClassName == input.FullEntityClassName ||
                    (this.FullEntityClassName != null &&
                    this.FullEntityClassName.Equals(input.FullEntityClassName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.FullEntityClassName != null)
                    hashCode = hashCode * 59 + this.FullEntityClassName.GetHashCode();
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
