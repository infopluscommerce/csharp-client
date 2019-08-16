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
    /// RunFulfillmentPlanInputAPIModel
    /// </summary>
    [DataContract]
    public partial class RunFulfillmentPlanInputAPIModel :  IEquatable<RunFulfillmentPlanInputAPIModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunFulfillmentPlanInputAPIModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunFulfillmentPlanInputAPIModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunFulfillmentPlanInputAPIModel" /> class.
        /// </summary>
        /// <param name="OrderNoList">OrderNoList.</param>
        /// <param name="FulfillmentPlanId">FulfillmentPlanId (required).</param>
        /// <param name="FirstPickPosition">FirstPickPosition.</param>
        /// <param name="MaxSKUs">MaxSKUs.</param>
        /// <param name="MaxCartons">MaxCartons.</param>
        /// <param name="ShipDate">ShipDate (required).</param>
        public RunFulfillmentPlanInputAPIModel(List<decimal?> OrderNoList = default(List<decimal?>), int? FulfillmentPlanId = default(int?), int? FirstPickPosition = default(int?), int? MaxSKUs = default(int?), int? MaxCartons = default(int?), DateTime? ShipDate = default(DateTime?))
        {
            // to ensure "FulfillmentPlanId" is required (not null)
            if (FulfillmentPlanId == null)
            {
                throw new InvalidDataException("FulfillmentPlanId is a required property for RunFulfillmentPlanInputAPIModel and cannot be null");
            }
            else
            {
                this.FulfillmentPlanId = FulfillmentPlanId;
            }
            // to ensure "ShipDate" is required (not null)
            if (ShipDate == null)
            {
                throw new InvalidDataException("ShipDate is a required property for RunFulfillmentPlanInputAPIModel and cannot be null");
            }
            else
            {
                this.ShipDate = ShipDate;
            }
            this.OrderNoList = OrderNoList;
            this.FirstPickPosition = FirstPickPosition;
            this.MaxSKUs = MaxSKUs;
            this.MaxCartons = MaxCartons;
        }
        
        /// <summary>
        /// Gets or Sets OrderNoList
        /// </summary>
        [DataMember(Name="orderNoList", EmitDefaultValue=false)]
        public List<decimal?> OrderNoList { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPlanId
        /// </summary>
        [DataMember(Name="fulfillmentPlanId", EmitDefaultValue=false)]
        public int? FulfillmentPlanId { get; set; }

        /// <summary>
        /// Gets or Sets FirstPickPosition
        /// </summary>
        [DataMember(Name="firstPickPosition", EmitDefaultValue=false)]
        public int? FirstPickPosition { get; set; }

        /// <summary>
        /// Gets or Sets MaxSKUs
        /// </summary>
        [DataMember(Name="maxSKUs", EmitDefaultValue=false)]
        public int? MaxSKUs { get; set; }

        /// <summary>
        /// Gets or Sets MaxCartons
        /// </summary>
        [DataMember(Name="maxCartons", EmitDefaultValue=false)]
        public int? MaxCartons { get; set; }

        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunFulfillmentPlanInputAPIModel {\n");
            sb.Append("  OrderNoList: ").Append(OrderNoList).Append("\n");
            sb.Append("  FulfillmentPlanId: ").Append(FulfillmentPlanId).Append("\n");
            sb.Append("  FirstPickPosition: ").Append(FirstPickPosition).Append("\n");
            sb.Append("  MaxSKUs: ").Append(MaxSKUs).Append("\n");
            sb.Append("  MaxCartons: ").Append(MaxCartons).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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
            return this.Equals(input as RunFulfillmentPlanInputAPIModel);
        }

        /// <summary>
        /// Returns true if RunFulfillmentPlanInputAPIModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RunFulfillmentPlanInputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunFulfillmentPlanInputAPIModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderNoList == input.OrderNoList ||
                    this.OrderNoList != null &&
                    this.OrderNoList.SequenceEqual(input.OrderNoList)
                ) && 
                (
                    this.FulfillmentPlanId == input.FulfillmentPlanId ||
                    (this.FulfillmentPlanId != null &&
                    this.FulfillmentPlanId.Equals(input.FulfillmentPlanId))
                ) && 
                (
                    this.FirstPickPosition == input.FirstPickPosition ||
                    (this.FirstPickPosition != null &&
                    this.FirstPickPosition.Equals(input.FirstPickPosition))
                ) && 
                (
                    this.MaxSKUs == input.MaxSKUs ||
                    (this.MaxSKUs != null &&
                    this.MaxSKUs.Equals(input.MaxSKUs))
                ) && 
                (
                    this.MaxCartons == input.MaxCartons ||
                    (this.MaxCartons != null &&
                    this.MaxCartons.Equals(input.MaxCartons))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
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
                if (this.OrderNoList != null)
                    hashCode = hashCode * 59 + this.OrderNoList.GetHashCode();
                if (this.FulfillmentPlanId != null)
                    hashCode = hashCode * 59 + this.FulfillmentPlanId.GetHashCode();
                if (this.FirstPickPosition != null)
                    hashCode = hashCode * 59 + this.FirstPickPosition.GetHashCode();
                if (this.MaxSKUs != null)
                    hashCode = hashCode * 59 + this.MaxSKUs.GetHashCode();
                if (this.MaxCartons != null)
                    hashCode = hashCode * 59 + this.MaxCartons.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
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
