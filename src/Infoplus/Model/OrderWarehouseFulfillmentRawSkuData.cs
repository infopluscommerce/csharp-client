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
    /// OrderWarehouseFulfillmentRawSkuData
    /// </summary>
    [DataContract]
    public partial class OrderWarehouseFulfillmentRawSkuData :  IEquatable<OrderWarehouseFulfillmentRawSkuData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentRawSkuData" /> class.
        /// </summary>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="CanFulfill">CanFulfill (default to false).</param>
        public OrderWarehouseFulfillmentRawSkuData(int? Quantity = default(int?), bool? CanFulfill = false)
        {
            this.Quantity = Quantity;
            // use default value if no "CanFulfill" provided
            if (CanFulfill == null)
            {
                this.CanFulfill = false;
            }
            else
            {
                this.CanFulfill = CanFulfill;
            }
        }
        
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets CanFulfill
        /// </summary>
        [DataMember(Name="canFulfill", EmitDefaultValue=false)]
        public bool? CanFulfill { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderWarehouseFulfillmentRawSkuData {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CanFulfill: ").Append(CanFulfill).Append("\n");
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
            return this.Equals(input as OrderWarehouseFulfillmentRawSkuData);
        }

        /// <summary>
        /// Returns true if OrderWarehouseFulfillmentRawSkuData instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderWarehouseFulfillmentRawSkuData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderWarehouseFulfillmentRawSkuData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.CanFulfill == input.CanFulfill ||
                    (this.CanFulfill != null &&
                    this.CanFulfill.Equals(input.CanFulfill))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.CanFulfill != null)
                    hashCode = hashCode * 59 + this.CanFulfill.GetHashCode();
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