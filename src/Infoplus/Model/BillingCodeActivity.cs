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
    /// BillingCodeActivity
    /// </summary>
    [DataContract]
    public partial class BillingCodeActivity :  IEquatable<BillingCodeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingCodeActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeActivity" /> class.
        /// </summary>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="Email">Email.</param>
        /// <param name="BillingCodeTypeId">BillingCodeTypeId (required).</param>
        /// <param name="BillingCodeTypeName">BillingCodeTypeName (required).</param>
        /// <param name="Note">Note.</param>
        /// <param name="RecordTypeName">RecordTypeName.</param>
        /// <param name="RecordTypeId">RecordTypeId.</param>
        /// <param name="RecordId">RecordId.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public BillingCodeActivity(decimal? Quantity = default(decimal?), int? LobId = default(int?), int? UserId = default(int?), string Email = default(string), int? BillingCodeTypeId = default(int?), string BillingCodeTypeName = default(string), string Note = default(string), string RecordTypeName = default(string), int? RecordTypeId = default(int?), string RecordId = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "BillingCodeTypeId" is required (not null)
            if (BillingCodeTypeId == null)
            {
                throw new InvalidDataException("BillingCodeTypeId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.BillingCodeTypeId = BillingCodeTypeId;
            }
            // to ensure "BillingCodeTypeName" is required (not null)
            if (BillingCodeTypeName == null)
            {
                throw new InvalidDataException("BillingCodeTypeName is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.BillingCodeTypeName = BillingCodeTypeName;
            }
            this.Email = Email;
            this.Note = Note;
            this.RecordTypeName = RecordTypeName;
            this.RecordTypeId = RecordTypeId;
            this.RecordId = RecordId;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets ImportedId
        /// </summary>
        [DataMember(Name="importedId", EmitDefaultValue=false)]
        public int? ImportedId { get; private set; }

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
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeTypeId
        /// </summary>
        [DataMember(Name="billingCodeTypeId", EmitDefaultValue=false)]
        public int? BillingCodeTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeTypeName
        /// </summary>
        [DataMember(Name="billingCodeTypeName", EmitDefaultValue=false)]
        public string BillingCodeTypeName { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets RecordTypeName
        /// </summary>
        [DataMember(Name="recordTypeName", EmitDefaultValue=false)]
        public string RecordTypeName { get; set; }

        /// <summary>
        /// Gets or Sets RecordTypeId
        /// </summary>
        [DataMember(Name="recordTypeId", EmitDefaultValue=false)]
        public int? RecordTypeId { get; set; }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name="recordId", EmitDefaultValue=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// Gets or Sets BillingQuantity
        /// </summary>
        [DataMember(Name="billingQuantity", EmitDefaultValue=false)]
        public decimal? BillingQuantity { get; private set; }

        /// <summary>
        /// Gets or Sets ChargeRate
        /// </summary>
        [DataMember(Name="chargeRate", EmitDefaultValue=false)]
        public decimal? ChargeRate { get; private set; }

        /// <summary>
        /// Gets or Sets ExtendedCharge
        /// </summary>
        [DataMember(Name="extendedCharge", EmitDefaultValue=false)]
        public decimal? ExtendedCharge { get; private set; }

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
            sb.Append("class BillingCodeActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImportedId: ").Append(ImportedId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BillingCodeTypeId: ").Append(BillingCodeTypeId).Append("\n");
            sb.Append("  BillingCodeTypeName: ").Append(BillingCodeTypeName).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  RecordTypeName: ").Append(RecordTypeName).Append("\n");
            sb.Append("  RecordTypeId: ").Append(RecordTypeId).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  BillingQuantity: ").Append(BillingQuantity).Append("\n");
            sb.Append("  ChargeRate: ").Append(ChargeRate).Append("\n");
            sb.Append("  ExtendedCharge: ").Append(ExtendedCharge).Append("\n");
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
            return this.Equals(input as BillingCodeActivity);
        }

        /// <summary>
        /// Returns true if BillingCodeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingCodeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingCodeActivity input)
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
                    this.ImportedId == input.ImportedId ||
                    (this.ImportedId != null &&
                    this.ImportedId.Equals(input.ImportedId))
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.BillingCodeTypeId == input.BillingCodeTypeId ||
                    (this.BillingCodeTypeId != null &&
                    this.BillingCodeTypeId.Equals(input.BillingCodeTypeId))
                ) && 
                (
                    this.BillingCodeTypeName == input.BillingCodeTypeName ||
                    (this.BillingCodeTypeName != null &&
                    this.BillingCodeTypeName.Equals(input.BillingCodeTypeName))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.RecordTypeName == input.RecordTypeName ||
                    (this.RecordTypeName != null &&
                    this.RecordTypeName.Equals(input.RecordTypeName))
                ) && 
                (
                    this.RecordTypeId == input.RecordTypeId ||
                    (this.RecordTypeId != null &&
                    this.RecordTypeId.Equals(input.RecordTypeId))
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.BillingQuantity == input.BillingQuantity ||
                    (this.BillingQuantity != null &&
                    this.BillingQuantity.Equals(input.BillingQuantity))
                ) && 
                (
                    this.ChargeRate == input.ChargeRate ||
                    (this.ChargeRate != null &&
                    this.ChargeRate.Equals(input.ChargeRate))
                ) && 
                (
                    this.ExtendedCharge == input.ExtendedCharge ||
                    (this.ExtendedCharge != null &&
                    this.ExtendedCharge.Equals(input.ExtendedCharge))
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
                if (this.ImportedId != null)
                    hashCode = hashCode * 59 + this.ImportedId.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.BillingCodeTypeId != null)
                    hashCode = hashCode * 59 + this.BillingCodeTypeId.GetHashCode();
                if (this.BillingCodeTypeName != null)
                    hashCode = hashCode * 59 + this.BillingCodeTypeName.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.RecordTypeName != null)
                    hashCode = hashCode * 59 + this.RecordTypeName.GetHashCode();
                if (this.RecordTypeId != null)
                    hashCode = hashCode * 59 + this.RecordTypeId.GetHashCode();
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.BillingQuantity != null)
                    hashCode = hashCode * 59 + this.BillingQuantity.GetHashCode();
                if (this.ChargeRate != null)
                    hashCode = hashCode * 59 + this.ChargeRate.GetHashCode();
                if (this.ExtendedCharge != null)
                    hashCode = hashCode * 59 + this.ExtendedCharge.GetHashCode();
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
