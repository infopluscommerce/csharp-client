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
    /// LegacyLowstockContact
    /// </summary>
    [DataContract]
    public partial class LegacyLowstockContact :  IEquatable<LegacyLowstockContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyLowstockContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LegacyLowstockContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyLowstockContact" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public LegacyLowstockContact(int? LobId = default(int?), string Id = default(string), string Name = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for LegacyLowstockContact and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for LegacyLowstockContact and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LegacyLowstockContact and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets InternalId
        /// </summary>
        [DataMember(Name="internalId", EmitDefaultValue=false)]
        public int? InternalId { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class LegacyLowstockContact {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  InternalId: ").Append(InternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as LegacyLowstockContact);
        }

        /// <summary>
        /// Returns true if LegacyLowstockContact instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyLowstockContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyLowstockContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.InternalId == input.InternalId ||
                    (this.InternalId != null &&
                    this.InternalId.Equals(input.InternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.InternalId != null)
                    hashCode = hashCode * 59 + this.InternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
