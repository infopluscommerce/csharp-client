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
    /// OrderSourceItemSetup
    /// </summary>
    [DataContract]
    public partial class OrderSourceItemSetup :  IEquatable<OrderSourceItemSetup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSourceItemSetup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderSourceItemSetup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSourceItemSetup" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="PackingNotes">PackingNotes.</param>
        /// <param name="SkuTranslation">SkuTranslation.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public OrderSourceItemSetup(int? LobId = default(int?), string Sku = default(string), int? OrderSourceId = default(int?), string PackingNotes = default(string), string SkuTranslation = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for OrderSourceItemSetup and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for OrderSourceItemSetup and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "OrderSourceId" is required (not null)
            if (OrderSourceId == null)
            {
                throw new InvalidDataException("OrderSourceId is a required property for OrderSourceItemSetup and cannot be null");
            }
            else
            {
                this.OrderSourceId = OrderSourceId;
            }
            this.PackingNotes = PackingNotes;
            this.SkuTranslation = SkuTranslation;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }

        /// <summary>
        /// Gets or Sets PackingNotes
        /// </summary>
        [DataMember(Name="packingNotes", EmitDefaultValue=false)]
        public string PackingNotes { get; set; }

        /// <summary>
        /// Gets or Sets SkuTranslation
        /// </summary>
        [DataMember(Name="skuTranslation", EmitDefaultValue=false)]
        public string SkuTranslation { get; set; }

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
            sb.Append("class OrderSourceItemSetup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  PackingNotes: ").Append(PackingNotes).Append("\n");
            sb.Append("  SkuTranslation: ").Append(SkuTranslation).Append("\n");
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
            return this.Equals(input as OrderSourceItemSetup);
        }

        /// <summary>
        /// Returns true if OrderSourceItemSetup instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderSourceItemSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderSourceItemSetup input)
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
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.OrderSourceId == input.OrderSourceId ||
                    (this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(input.OrderSourceId))
                ) && 
                (
                    this.PackingNotes == input.PackingNotes ||
                    (this.PackingNotes != null &&
                    this.PackingNotes.Equals(input.PackingNotes))
                ) && 
                (
                    this.SkuTranslation == input.SkuTranslation ||
                    (this.SkuTranslation != null &&
                    this.SkuTranslation.Equals(input.SkuTranslation))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.OrderSourceId != null)
                    hashCode = hashCode * 59 + this.OrderSourceId.GetHashCode();
                if (this.PackingNotes != null)
                    hashCode = hashCode * 59 + this.PackingNotes.GetHashCode();
                if (this.SkuTranslation != null)
                    hashCode = hashCode * 59 + this.SkuTranslation.GetHashCode();
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
