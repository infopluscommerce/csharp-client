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
    /// PackingDetail
    /// </summary>
    [DataContract]
    public partial class PackingDetail :  IEquatable<PackingDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingDetail" /> class.
        /// </summary>
        /// <param name="LobId">LobId.</param>
        /// <param name="OrderId">OrderId.</param>
        /// <param name="PalletId">PalletId.</param>
        /// <param name="MasterCartonId">MasterCartonId.</param>
        /// <param name="CartonId">CartonId.</param>
        /// <param name="SkuId">SkuId.</param>
        /// <param name="ItemReceiptId">ItemReceiptId.</param>
        /// <param name="LineItemId">LineItemId.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public PackingDetail(int? LobId = default(int?), decimal? OrderId = default(decimal?), int? PalletId = default(int?), int? MasterCartonId = default(int?), int? CartonId = default(int?), int? SkuId = default(int?), int? ItemReceiptId = default(int?), int? LineItemId = default(int?), int? Quantity = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            this.LobId = LobId;
            this.OrderId = OrderId;
            this.PalletId = PalletId;
            this.MasterCartonId = MasterCartonId;
            this.CartonId = CartonId;
            this.SkuId = SkuId;
            this.ItemReceiptId = ItemReceiptId;
            this.LineItemId = LineItemId;
            this.Quantity = Quantity;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public decimal? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PalletId
        /// </summary>
        [DataMember(Name="palletId", EmitDefaultValue=false)]
        public int? PalletId { get; set; }

        /// <summary>
        /// Gets or Sets MasterCartonId
        /// </summary>
        [DataMember(Name="masterCartonId", EmitDefaultValue=false)]
        public int? MasterCartonId { get; set; }

        /// <summary>
        /// Gets or Sets CartonId
        /// </summary>
        [DataMember(Name="cartonId", EmitDefaultValue=false)]
        public int? CartonId { get; set; }

        /// <summary>
        /// Gets or Sets SkuId
        /// </summary>
        [DataMember(Name="skuId", EmitDefaultValue=false)]
        public int? SkuId { get; set; }

        /// <summary>
        /// Gets or Sets ItemReceiptId
        /// </summary>
        [DataMember(Name="itemReceiptId", EmitDefaultValue=false)]
        public int? ItemReceiptId { get; set; }

        /// <summary>
        /// Gets or Sets LineItemId
        /// </summary>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public int? LineItemId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

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
            sb.Append("class PackingDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PalletId: ").Append(PalletId).Append("\n");
            sb.Append("  MasterCartonId: ").Append(MasterCartonId).Append("\n");
            sb.Append("  CartonId: ").Append(CartonId).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
            sb.Append("  ItemReceiptId: ").Append(ItemReceiptId).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as PackingDetail);
        }

        /// <summary>
        /// Returns true if PackingDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PackingDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackingDetail input)
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
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PalletId == input.PalletId ||
                    (this.PalletId != null &&
                    this.PalletId.Equals(input.PalletId))
                ) && 
                (
                    this.MasterCartonId == input.MasterCartonId ||
                    (this.MasterCartonId != null &&
                    this.MasterCartonId.Equals(input.MasterCartonId))
                ) && 
                (
                    this.CartonId == input.CartonId ||
                    (this.CartonId != null &&
                    this.CartonId.Equals(input.CartonId))
                ) && 
                (
                    this.SkuId == input.SkuId ||
                    (this.SkuId != null &&
                    this.SkuId.Equals(input.SkuId))
                ) && 
                (
                    this.ItemReceiptId == input.ItemReceiptId ||
                    (this.ItemReceiptId != null &&
                    this.ItemReceiptId.Equals(input.ItemReceiptId))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PalletId != null)
                    hashCode = hashCode * 59 + this.PalletId.GetHashCode();
                if (this.MasterCartonId != null)
                    hashCode = hashCode * 59 + this.MasterCartonId.GetHashCode();
                if (this.CartonId != null)
                    hashCode = hashCode * 59 + this.CartonId.GetHashCode();
                if (this.SkuId != null)
                    hashCode = hashCode * 59 + this.SkuId.GetHashCode();
                if (this.ItemReceiptId != null)
                    hashCode = hashCode * 59 + this.ItemReceiptId.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
