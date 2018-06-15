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
    /// CustomerInvoiceTemplateLine
    /// </summary>
    [DataContract]
    public partial class CustomerInvoiceTemplateLine :  IEquatable<CustomerInvoiceTemplateLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerInvoiceTemplateLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLine" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="SeqNo">SeqNo.</param>
        /// <param name="AccountCode">AccountCode.</param>
        /// <param name="Active">Active (required) (default to false).</param>
        /// <param name="IncludeIfZero">IncludeIfZero (required) (default to false).</param>
        /// <param name="Department">Department.</param>
        /// <param name="ItemCode">ItemCode.</param>
        /// <param name="InvoiceTemplateId">InvoiceTemplateId.</param>
        /// <param name="BillingRuleId">BillingRuleId (required).</param>
        /// <param name="PriceLevelMode">PriceLevelMode (required).</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="PriceLevelList">PriceLevelList.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public CustomerInvoiceTemplateLine(int? LobId = default(int?), string Description = default(string), int? SeqNo = default(int?), string AccountCode = default(string), bool? Active = false, bool? IncludeIfZero = false, string Department = default(string), string ItemCode = default(string), int? InvoiceTemplateId = default(int?), int? BillingRuleId = default(int?), string PriceLevelMode = default(string), int? ScriptId = default(int?), List<InvoiceTemplateLinePriceLevel> PriceLevelList = default(List<InvoiceTemplateLinePriceLevel>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            // to ensure "IncludeIfZero" is required (not null)
            if (IncludeIfZero == null)
            {
                throw new InvalidDataException("IncludeIfZero is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.IncludeIfZero = IncludeIfZero;
            }
            // to ensure "BillingRuleId" is required (not null)
            if (BillingRuleId == null)
            {
                throw new InvalidDataException("BillingRuleId is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.BillingRuleId = BillingRuleId;
            }
            // to ensure "PriceLevelMode" is required (not null)
            if (PriceLevelMode == null)
            {
                throw new InvalidDataException("PriceLevelMode is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.PriceLevelMode = PriceLevelMode;
            }
            this.Description = Description;
            this.SeqNo = SeqNo;
            this.AccountCode = AccountCode;
            this.Department = Department;
            this.ItemCode = ItemCode;
            this.InvoiceTemplateId = InvoiceTemplateId;
            this.ScriptId = ScriptId;
            this.PriceLevelList = PriceLevelList;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SeqNo
        /// </summary>
        [DataMember(Name="seqNo", EmitDefaultValue=false)]
        public int? SeqNo { get; set; }

        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets IncludeIfZero
        /// </summary>
        [DataMember(Name="includeIfZero", EmitDefaultValue=false)]
        public bool? IncludeIfZero { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets ItemCode
        /// </summary>
        [DataMember(Name="itemCode", EmitDefaultValue=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTemplateId
        /// </summary>
        [DataMember(Name="invoiceTemplateId", EmitDefaultValue=false)]
        public int? InvoiceTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets BillingRuleId
        /// </summary>
        [DataMember(Name="billingRuleId", EmitDefaultValue=false)]
        public int? BillingRuleId { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelMode
        /// </summary>
        [DataMember(Name="priceLevelMode", EmitDefaultValue=false)]
        public string PriceLevelMode { get; set; }

        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public int? ScriptId { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelList
        /// </summary>
        [DataMember(Name="priceLevelList", EmitDefaultValue=false)]
        public List<InvoiceTemplateLinePriceLevel> PriceLevelList { get; set; }

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
            sb.Append("class CustomerInvoiceTemplateLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SeqNo: ").Append(SeqNo).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  IncludeIfZero: ").Append(IncludeIfZero).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
            sb.Append("  BillingRuleId: ").Append(BillingRuleId).Append("\n");
            sb.Append("  PriceLevelMode: ").Append(PriceLevelMode).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  PriceLevelList: ").Append(PriceLevelList).Append("\n");
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
            return this.Equals(input as CustomerInvoiceTemplateLine);
        }

        /// <summary>
        /// Returns true if CustomerInvoiceTemplateLine instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerInvoiceTemplateLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerInvoiceTemplateLine input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SeqNo == input.SeqNo ||
                    (this.SeqNo != null &&
                    this.SeqNo.Equals(input.SeqNo))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.IncludeIfZero == input.IncludeIfZero ||
                    (this.IncludeIfZero != null &&
                    this.IncludeIfZero.Equals(input.IncludeIfZero))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.InvoiceTemplateId == input.InvoiceTemplateId ||
                    (this.InvoiceTemplateId != null &&
                    this.InvoiceTemplateId.Equals(input.InvoiceTemplateId))
                ) && 
                (
                    this.BillingRuleId == input.BillingRuleId ||
                    (this.BillingRuleId != null &&
                    this.BillingRuleId.Equals(input.BillingRuleId))
                ) && 
                (
                    this.PriceLevelMode == input.PriceLevelMode ||
                    (this.PriceLevelMode != null &&
                    this.PriceLevelMode.Equals(input.PriceLevelMode))
                ) && 
                (
                    this.ScriptId == input.ScriptId ||
                    (this.ScriptId != null &&
                    this.ScriptId.Equals(input.ScriptId))
                ) && 
                (
                    this.PriceLevelList == input.PriceLevelList ||
                    this.PriceLevelList != null &&
                    this.PriceLevelList.SequenceEqual(input.PriceLevelList)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SeqNo != null)
                    hashCode = hashCode * 59 + this.SeqNo.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.IncludeIfZero != null)
                    hashCode = hashCode * 59 + this.IncludeIfZero.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.ItemCode != null)
                    hashCode = hashCode * 59 + this.ItemCode.GetHashCode();
                if (this.InvoiceTemplateId != null)
                    hashCode = hashCode * 59 + this.InvoiceTemplateId.GetHashCode();
                if (this.BillingRuleId != null)
                    hashCode = hashCode * 59 + this.BillingRuleId.GetHashCode();
                if (this.PriceLevelMode != null)
                    hashCode = hashCode * 59 + this.PriceLevelMode.GetHashCode();
                if (this.ScriptId != null)
                    hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.PriceLevelList != null)
                    hashCode = hashCode * 59 + this.PriceLevelList.GetHashCode();
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