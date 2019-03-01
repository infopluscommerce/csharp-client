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
    /// Zone
    /// </summary>
    [DataContract]
    public partial class Zone :  IEquatable<Zone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Zone() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Address">Address.</param>
        /// <param name="IsClimateControlled">IsClimateControlled (default to false).</param>
        /// <param name="IsFoodGrade">IsFoodGrade (default to false).</param>
        /// <param name="IsSecure">IsSecure (default to false).</param>
        /// <param name="IsFrozen">IsFrozen (default to false).</param>
        /// <param name="IsRefrigerated">IsRefrigerated (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Zone(int? WarehouseId = default(int?), string Name = default(string), string Address = default(string), bool? IsClimateControlled = false, bool? IsFoodGrade = false, bool? IsSecure = false, bool? IsFrozen = false, bool? IsRefrigerated = false, Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Zone and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Zone and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Address = Address;
            // use default value if no "IsClimateControlled" provided
            if (IsClimateControlled == null)
            {
                this.IsClimateControlled = false;
            }
            else
            {
                this.IsClimateControlled = IsClimateControlled;
            }
            // use default value if no "IsFoodGrade" provided
            if (IsFoodGrade == null)
            {
                this.IsFoodGrade = false;
            }
            else
            {
                this.IsFoodGrade = IsFoodGrade;
            }
            // use default value if no "IsSecure" provided
            if (IsSecure == null)
            {
                this.IsSecure = false;
            }
            else
            {
                this.IsSecure = IsSecure;
            }
            // use default value if no "IsFrozen" provided
            if (IsFrozen == null)
            {
                this.IsFrozen = false;
            }
            else
            {
                this.IsFrozen = IsFrozen;
            }
            // use default value if no "IsRefrigerated" provided
            if (IsRefrigerated == null)
            {
                this.IsRefrigerated = false;
            }
            else
            {
                this.IsRefrigerated = IsRefrigerated;
            }
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets IsClimateControlled
        /// </summary>
        [DataMember(Name="isClimateControlled", EmitDefaultValue=false)]
        public bool? IsClimateControlled { get; set; }

        /// <summary>
        /// Gets or Sets IsFoodGrade
        /// </summary>
        [DataMember(Name="isFoodGrade", EmitDefaultValue=false)]
        public bool? IsFoodGrade { get; set; }

        /// <summary>
        /// Gets or Sets IsSecure
        /// </summary>
        [DataMember(Name="isSecure", EmitDefaultValue=false)]
        public bool? IsSecure { get; set; }

        /// <summary>
        /// Gets or Sets IsFrozen
        /// </summary>
        [DataMember(Name="isFrozen", EmitDefaultValue=false)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// Gets or Sets IsRefrigerated
        /// </summary>
        [DataMember(Name="isRefrigerated", EmitDefaultValue=false)]
        public bool? IsRefrigerated { get; set; }

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
            sb.Append("class Zone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  IsClimateControlled: ").Append(IsClimateControlled).Append("\n");
            sb.Append("  IsFoodGrade: ").Append(IsFoodGrade).Append("\n");
            sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
            sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  IsRefrigerated: ").Append(IsRefrigerated).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(input as Zone);
        }

        /// <summary>
        /// Returns true if Zone instances are equal
        /// </summary>
        /// <param name="input">Instance of Zone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zone input)
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
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.IsClimateControlled == input.IsClimateControlled ||
                    (this.IsClimateControlled != null &&
                    this.IsClimateControlled.Equals(input.IsClimateControlled))
                ) && 
                (
                    this.IsFoodGrade == input.IsFoodGrade ||
                    (this.IsFoodGrade != null &&
                    this.IsFoodGrade.Equals(input.IsFoodGrade))
                ) && 
                (
                    this.IsSecure == input.IsSecure ||
                    (this.IsSecure != null &&
                    this.IsSecure.Equals(input.IsSecure))
                ) && 
                (
                    this.IsFrozen == input.IsFrozen ||
                    (this.IsFrozen != null &&
                    this.IsFrozen.Equals(input.IsFrozen))
                ) && 
                (
                    this.IsRefrigerated == input.IsRefrigerated ||
                    (this.IsRefrigerated != null &&
                    this.IsRefrigerated.Equals(input.IsRefrigerated))
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
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IsClimateControlled != null)
                    hashCode = hashCode * 59 + this.IsClimateControlled.GetHashCode();
                if (this.IsFoodGrade != null)
                    hashCode = hashCode * 59 + this.IsFoodGrade.GetHashCode();
                if (this.IsSecure != null)
                    hashCode = hashCode * 59 + this.IsSecure.GetHashCode();
                if (this.IsFrozen != null)
                    hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.IsRefrigerated != null)
                    hashCode = hashCode * 59 + this.IsRefrigerated.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
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