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
    /// Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Job() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="SourceJobRecipeId">SourceJobRecipeId.</param>
        /// <param name="AssemblyQuantity">AssemblyQuantity (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Layout">Layout (required).</param>
        /// <param name="TrackAssemblies">TrackAssemblies (required) (default to false).</param>
        /// <param name="TrackSteps">TrackSteps (required) (default to false).</param>
        /// <param name="JobNo">JobNo.</param>
        /// <param name="AssemblyInstructions">AssemblyInstructions.</param>
        /// <param name="Inputs">Inputs.</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="Steps">Steps.</param>
        /// <param name="FulfillmentPlanId">FulfillmentPlanId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Job(int? SourceJobRecipeId = default(int?), int? AssemblyQuantity = default(int?), int? WarehouseId = default(int?), int? LobId = default(int?), string Layout = default(string), bool? TrackAssemblies = false, bool? TrackSteps = false, string JobNo = default(string), string AssemblyInstructions = default(string), List<JobInput> Inputs = default(List<JobInput>), List<JobOutput> Outputs = default(List<JobOutput>), List<JobStep> Steps = default(List<JobStep>), int? FulfillmentPlanId = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "AssemblyQuantity" is required (not null)
            if (AssemblyQuantity == null)
            {
                throw new InvalidDataException("AssemblyQuantity is a required property for Job and cannot be null");
            }
            else
            {
                this.AssemblyQuantity = AssemblyQuantity;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Job and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Job and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Layout" is required (not null)
            if (Layout == null)
            {
                throw new InvalidDataException("Layout is a required property for Job and cannot be null");
            }
            else
            {
                this.Layout = Layout;
            }
            // to ensure "TrackAssemblies" is required (not null)
            if (TrackAssemblies == null)
            {
                throw new InvalidDataException("TrackAssemblies is a required property for Job and cannot be null");
            }
            else
            {
                this.TrackAssemblies = TrackAssemblies;
            }
            // to ensure "TrackSteps" is required (not null)
            if (TrackSteps == null)
            {
                throw new InvalidDataException("TrackSteps is a required property for Job and cannot be null");
            }
            else
            {
                this.TrackSteps = TrackSteps;
            }
            // to ensure "FulfillmentPlanId" is required (not null)
            if (FulfillmentPlanId == null)
            {
                throw new InvalidDataException("FulfillmentPlanId is a required property for Job and cannot be null");
            }
            else
            {
                this.FulfillmentPlanId = FulfillmentPlanId;
            }
            this.SourceJobRecipeId = SourceJobRecipeId;
            this.JobNo = JobNo;
            this.AssemblyInstructions = AssemblyInstructions;
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            this.Steps = Steps;
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
        /// Gets or Sets SourceJobRecipeId
        /// </summary>
        [DataMember(Name="sourceJobRecipeId", EmitDefaultValue=false)]
        public int? SourceJobRecipeId { get; set; }

        /// <summary>
        /// Gets or Sets AssemblyQuantity
        /// </summary>
        [DataMember(Name="assemblyQuantity", EmitDefaultValue=false)]
        public int? AssemblyQuantity { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets OrderNoId
        /// </summary>
        [DataMember(Name="orderNoId", EmitDefaultValue=false)]
        public decimal? OrderNoId { get; private set; }

        /// <summary>
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; private set; }

        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; private set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="layout", EmitDefaultValue=false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or Sets TrackAssemblies
        /// </summary>
        [DataMember(Name="trackAssemblies", EmitDefaultValue=false)]
        public bool? TrackAssemblies { get; set; }

        /// <summary>
        /// Gets or Sets TrackSteps
        /// </summary>
        [DataMember(Name="trackSteps", EmitDefaultValue=false)]
        public bool? TrackSteps { get; set; }

        /// <summary>
        /// Gets or Sets JobNo
        /// </summary>
        [DataMember(Name="jobNo", EmitDefaultValue=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// Gets or Sets AssemblyInstructions
        /// </summary>
        [DataMember(Name="assemblyInstructions", EmitDefaultValue=false)]
        public string AssemblyInstructions { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<JobInput> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<JobOutput> Outputs { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<JobStep> Steps { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPlanId
        /// </summary>
        [DataMember(Name="fulfillmentPlanId", EmitDefaultValue=false)]
        public int? FulfillmentPlanId { get; set; }

        /// <summary>
        /// Gets or Sets TotalPicks
        /// </summary>
        [DataMember(Name="totalPicks", EmitDefaultValue=false)]
        public int? TotalPicks { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedPicks
        /// </summary>
        [DataMember(Name="completedPicks", EmitDefaultValue=false)]
        public int? CompletedPicks { get; private set; }

        /// <summary>
        /// Gets or Sets TotalAssemblies
        /// </summary>
        [DataMember(Name="totalAssemblies", EmitDefaultValue=false)]
        public int? TotalAssemblies { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedAssemblies
        /// </summary>
        [DataMember(Name="completedAssemblies", EmitDefaultValue=false)]
        public int? CompletedAssemblies { get; private set; }

        /// <summary>
        /// Gets or Sets TotalSteps
        /// </summary>
        [DataMember(Name="totalSteps", EmitDefaultValue=false)]
        public int? TotalSteps { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedSteps
        /// </summary>
        [DataMember(Name="completedSteps", EmitDefaultValue=false)]
        public int? CompletedSteps { get; private set; }

        /// <summary>
        /// Gets or Sets TotalReceipts
        /// </summary>
        [DataMember(Name="totalReceipts", EmitDefaultValue=false)]
        public int? TotalReceipts { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedReceipts
        /// </summary>
        [DataMember(Name="completedReceipts", EmitDefaultValue=false)]
        public int? CompletedReceipts { get; private set; }

        /// <summary>
        /// Gets or Sets TotalToDo
        /// </summary>
        [DataMember(Name="totalToDo", EmitDefaultValue=false)]
        public int? TotalToDo { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedToDo
        /// </summary>
        [DataMember(Name="completedToDo", EmitDefaultValue=false)]
        public int? CompletedToDo { get; private set; }

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
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  SourceJobRecipeId: ").Append(SourceJobRecipeId).Append("\n");
            sb.Append("  AssemblyQuantity: ").Append(AssemblyQuantity).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OrderNoId: ").Append(OrderNoId).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  TrackAssemblies: ").Append(TrackAssemblies).Append("\n");
            sb.Append("  TrackSteps: ").Append(TrackSteps).Append("\n");
            sb.Append("  JobNo: ").Append(JobNo).Append("\n");
            sb.Append("  AssemblyInstructions: ").Append(AssemblyInstructions).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  FulfillmentPlanId: ").Append(FulfillmentPlanId).Append("\n");
            sb.Append("  TotalPicks: ").Append(TotalPicks).Append("\n");
            sb.Append("  CompletedPicks: ").Append(CompletedPicks).Append("\n");
            sb.Append("  TotalAssemblies: ").Append(TotalAssemblies).Append("\n");
            sb.Append("  CompletedAssemblies: ").Append(CompletedAssemblies).Append("\n");
            sb.Append("  TotalSteps: ").Append(TotalSteps).Append("\n");
            sb.Append("  CompletedSteps: ").Append(CompletedSteps).Append("\n");
            sb.Append("  TotalReceipts: ").Append(TotalReceipts).Append("\n");
            sb.Append("  CompletedReceipts: ").Append(CompletedReceipts).Append("\n");
            sb.Append("  TotalToDo: ").Append(TotalToDo).Append("\n");
            sb.Append("  CompletedToDo: ").Append(CompletedToDo).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
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
                    this.SourceJobRecipeId == input.SourceJobRecipeId ||
                    (this.SourceJobRecipeId != null &&
                    this.SourceJobRecipeId.Equals(input.SourceJobRecipeId))
                ) && 
                (
                    this.AssemblyQuantity == input.AssemblyQuantity ||
                    (this.AssemblyQuantity != null &&
                    this.AssemblyQuantity.Equals(input.AssemblyQuantity))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.OrderNoId == input.OrderNoId ||
                    (this.OrderNoId != null &&
                    this.OrderNoId.Equals(input.OrderNoId))
                ) && 
                (
                    this.PoNoId == input.PoNoId ||
                    (this.PoNoId != null &&
                    this.PoNoId.Equals(input.PoNoId))
                ) && 
                (
                    this.WorkBatchId == input.WorkBatchId ||
                    (this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(input.WorkBatchId))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.TrackAssemblies == input.TrackAssemblies ||
                    (this.TrackAssemblies != null &&
                    this.TrackAssemblies.Equals(input.TrackAssemblies))
                ) && 
                (
                    this.TrackSteps == input.TrackSteps ||
                    (this.TrackSteps != null &&
                    this.TrackSteps.Equals(input.TrackSteps))
                ) && 
                (
                    this.JobNo == input.JobNo ||
                    (this.JobNo != null &&
                    this.JobNo.Equals(input.JobNo))
                ) && 
                (
                    this.AssemblyInstructions == input.AssemblyInstructions ||
                    (this.AssemblyInstructions != null &&
                    this.AssemblyInstructions.Equals(input.AssemblyInstructions))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.FulfillmentPlanId == input.FulfillmentPlanId ||
                    (this.FulfillmentPlanId != null &&
                    this.FulfillmentPlanId.Equals(input.FulfillmentPlanId))
                ) && 
                (
                    this.TotalPicks == input.TotalPicks ||
                    (this.TotalPicks != null &&
                    this.TotalPicks.Equals(input.TotalPicks))
                ) && 
                (
                    this.CompletedPicks == input.CompletedPicks ||
                    (this.CompletedPicks != null &&
                    this.CompletedPicks.Equals(input.CompletedPicks))
                ) && 
                (
                    this.TotalAssemblies == input.TotalAssemblies ||
                    (this.TotalAssemblies != null &&
                    this.TotalAssemblies.Equals(input.TotalAssemblies))
                ) && 
                (
                    this.CompletedAssemblies == input.CompletedAssemblies ||
                    (this.CompletedAssemblies != null &&
                    this.CompletedAssemblies.Equals(input.CompletedAssemblies))
                ) && 
                (
                    this.TotalSteps == input.TotalSteps ||
                    (this.TotalSteps != null &&
                    this.TotalSteps.Equals(input.TotalSteps))
                ) && 
                (
                    this.CompletedSteps == input.CompletedSteps ||
                    (this.CompletedSteps != null &&
                    this.CompletedSteps.Equals(input.CompletedSteps))
                ) && 
                (
                    this.TotalReceipts == input.TotalReceipts ||
                    (this.TotalReceipts != null &&
                    this.TotalReceipts.Equals(input.TotalReceipts))
                ) && 
                (
                    this.CompletedReceipts == input.CompletedReceipts ||
                    (this.CompletedReceipts != null &&
                    this.CompletedReceipts.Equals(input.CompletedReceipts))
                ) && 
                (
                    this.TotalToDo == input.TotalToDo ||
                    (this.TotalToDo != null &&
                    this.TotalToDo.Equals(input.TotalToDo))
                ) && 
                (
                    this.CompletedToDo == input.CompletedToDo ||
                    (this.CompletedToDo != null &&
                    this.CompletedToDo.Equals(input.CompletedToDo))
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
                if (this.SourceJobRecipeId != null)
                    hashCode = hashCode * 59 + this.SourceJobRecipeId.GetHashCode();
                if (this.AssemblyQuantity != null)
                    hashCode = hashCode * 59 + this.AssemblyQuantity.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrderNoId != null)
                    hashCode = hashCode * 59 + this.OrderNoId.GetHashCode();
                if (this.PoNoId != null)
                    hashCode = hashCode * 59 + this.PoNoId.GetHashCode();
                if (this.WorkBatchId != null)
                    hashCode = hashCode * 59 + this.WorkBatchId.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.TrackAssemblies != null)
                    hashCode = hashCode * 59 + this.TrackAssemblies.GetHashCode();
                if (this.TrackSteps != null)
                    hashCode = hashCode * 59 + this.TrackSteps.GetHashCode();
                if (this.JobNo != null)
                    hashCode = hashCode * 59 + this.JobNo.GetHashCode();
                if (this.AssemblyInstructions != null)
                    hashCode = hashCode * 59 + this.AssemblyInstructions.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.FulfillmentPlanId != null)
                    hashCode = hashCode * 59 + this.FulfillmentPlanId.GetHashCode();
                if (this.TotalPicks != null)
                    hashCode = hashCode * 59 + this.TotalPicks.GetHashCode();
                if (this.CompletedPicks != null)
                    hashCode = hashCode * 59 + this.CompletedPicks.GetHashCode();
                if (this.TotalAssemblies != null)
                    hashCode = hashCode * 59 + this.TotalAssemblies.GetHashCode();
                if (this.CompletedAssemblies != null)
                    hashCode = hashCode * 59 + this.CompletedAssemblies.GetHashCode();
                if (this.TotalSteps != null)
                    hashCode = hashCode * 59 + this.TotalSteps.GetHashCode();
                if (this.CompletedSteps != null)
                    hashCode = hashCode * 59 + this.CompletedSteps.GetHashCode();
                if (this.TotalReceipts != null)
                    hashCode = hashCode * 59 + this.TotalReceipts.GetHashCode();
                if (this.CompletedReceipts != null)
                    hashCode = hashCode * 59 + this.CompletedReceipts.GetHashCode();
                if (this.TotalToDo != null)
                    hashCode = hashCode * 59 + this.TotalToDo.GetHashCode();
                if (this.CompletedToDo != null)
                    hashCode = hashCode * 59 + this.CompletedToDo.GetHashCode();
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
