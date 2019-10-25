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
    /// InventoryAdjustment
    /// </summary>
    [DataContract]
    public partial class InventoryAdjustment :  IEquatable<InventoryAdjustment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAdjustment" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="LobId">LobId.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="PoNoId">PoNoId.</param>
        /// <param name="AdjustmentDate">AdjustmentDate.</param>
        /// <param name="AdjustmentTime">AdjustmentTime.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="Note">Note.</param>
        /// <param name="AuthorizedBy">AuthorizedBy.</param>
        /// <param name="Printed">Printed.</param>
        /// <param name="OrderNo">OrderNo.</param>
        /// <param name="AdjustmentCode">AdjustmentCode.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public InventoryAdjustment(int? Id = default(int?), int? LobId = default(int?), string Sku = default(string), int? PoNoId = default(int?), DateTime? AdjustmentDate = default(DateTime?), string AdjustmentTime = default(string), string Location = default(string), int? Qty = default(int?), string Note = default(string), string AuthorizedBy = default(string), string Printed = default(string), decimal? OrderNo = default(decimal?), string AdjustmentCode = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            this.Id = Id;
            this.LobId = LobId;
            this.Sku = Sku;
            this.PoNoId = PoNoId;
            this.AdjustmentDate = AdjustmentDate;
            this.AdjustmentTime = AdjustmentTime;
            this.Location = Location;
            this.Qty = Qty;
            this.Note = Note;
            this.AuthorizedBy = AuthorizedBy;
            this.Printed = Printed;
            this.OrderNo = OrderNo;
            this.AdjustmentCode = AdjustmentCode;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

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
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentDate
        /// </summary>
        [DataMember(Name="adjustmentDate", EmitDefaultValue=false)]
        public DateTime? AdjustmentDate { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentTime
        /// </summary>
        [DataMember(Name="adjustmentTime", EmitDefaultValue=false)]
        public string AdjustmentTime { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public int? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedBy
        /// </summary>
        [DataMember(Name="authorizedBy", EmitDefaultValue=false)]
        public string AuthorizedBy { get; set; }

        /// <summary>
        /// Gets or Sets Printed
        /// </summary>
        [DataMember(Name="printed", EmitDefaultValue=false)]
        public string Printed { get; set; }

        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public decimal? OrderNo { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentCode
        /// </summary>
        [DataMember(Name="adjustmentCode", EmitDefaultValue=false)]
        public string AdjustmentCode { get; set; }

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
            sb.Append("class InventoryAdjustment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
            sb.Append("  AdjustmentTime: ").Append(AdjustmentTime).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AuthorizedBy: ").Append(AuthorizedBy).Append("\n");
            sb.Append("  Printed: ").Append(Printed).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  AdjustmentCode: ").Append(AdjustmentCode).Append("\n");
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
            return this.Equals(input as InventoryAdjustment);
        }

        /// <summary>
        /// Returns true if InventoryAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAdjustment input)
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
                    this.PoNoId == input.PoNoId ||
                    (this.PoNoId != null &&
                    this.PoNoId.Equals(input.PoNoId))
                ) && 
                (
                    this.AdjustmentDate == input.AdjustmentDate ||
                    (this.AdjustmentDate != null &&
                    this.AdjustmentDate.Equals(input.AdjustmentDate))
                ) && 
                (
                    this.AdjustmentTime == input.AdjustmentTime ||
                    (this.AdjustmentTime != null &&
                    this.AdjustmentTime.Equals(input.AdjustmentTime))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.AuthorizedBy == input.AuthorizedBy ||
                    (this.AuthorizedBy != null &&
                    this.AuthorizedBy.Equals(input.AuthorizedBy))
                ) && 
                (
                    this.Printed == input.Printed ||
                    (this.Printed != null &&
                    this.Printed.Equals(input.Printed))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.AdjustmentCode == input.AdjustmentCode ||
                    (this.AdjustmentCode != null &&
                    this.AdjustmentCode.Equals(input.AdjustmentCode))
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
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.PoNoId != null)
                    hashCode = hashCode * 59 + this.PoNoId.GetHashCode();
                if (this.AdjustmentDate != null)
                    hashCode = hashCode * 59 + this.AdjustmentDate.GetHashCode();
                if (this.AdjustmentTime != null)
                    hashCode = hashCode * 59 + this.AdjustmentTime.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.AuthorizedBy != null)
                    hashCode = hashCode * 59 + this.AuthorizedBy.GetHashCode();
                if (this.Printed != null)
                    hashCode = hashCode * 59 + this.Printed.GetHashCode();
                if (this.OrderNo != null)
                    hashCode = hashCode * 59 + this.OrderNo.GetHashCode();
                if (this.AdjustmentCode != null)
                    hashCode = hashCode * 59 + this.AdjustmentCode.GetHashCode();
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
