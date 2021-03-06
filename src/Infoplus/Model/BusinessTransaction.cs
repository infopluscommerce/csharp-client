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
    /// BusinessTransaction
    /// </summary>
    [DataContract]
    public partial class BusinessTransaction :  IEquatable<BusinessTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BusinessTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessTransaction" /> class.
        /// </summary>
        /// <param name="QueueName">QueueName.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="MessageBody">MessageBody.</param>
        /// <param name="AlertId">AlertId.</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public BusinessTransaction(string QueueName = default(string), int? LobId = default(int?), string MessageBody = default(string), int? AlertId = default(int?), string Status = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for BusinessTransaction and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for BusinessTransaction and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.QueueName = QueueName;
            this.MessageBody = MessageBody;
            this.AlertId = AlertId;
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
        /// Gets or Sets ServerName
        /// </summary>
        [DataMember(Name="serverName", EmitDefaultValue=false)]
        public string ServerName { get; private set; }

        /// <summary>
        /// Gets or Sets QueueName
        /// </summary>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets MessageBody
        /// </summary>
        [DataMember(Name="messageBody", EmitDefaultValue=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// Gets or Sets AlertId
        /// </summary>
        [DataMember(Name="alertId", EmitDefaultValue=false)]
        public int? AlertId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

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
            sb.Append("class BusinessTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  MessageBody: ").Append(MessageBody).Append("\n");
            sb.Append("  AlertId: ").Append(AlertId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as BusinessTransaction);
        }

        /// <summary>
        /// Returns true if BusinessTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessTransaction input)
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
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.MessageBody == input.MessageBody ||
                    (this.MessageBody != null &&
                    this.MessageBody.Equals(input.MessageBody))
                ) && 
                (
                    this.AlertId == input.AlertId ||
                    (this.AlertId != null &&
                    this.AlertId.Equals(input.AlertId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.MessageBody != null)
                    hashCode = hashCode * 59 + this.MessageBody.GetHashCode();
                if (this.AlertId != null)
                    hashCode = hashCode * 59 + this.AlertId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
