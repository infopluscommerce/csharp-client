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
    /// QuickReceipt
    /// </summary>
    [DataContract]
    public partial class QuickReceipt :  IEquatable<QuickReceipt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickReceipt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuickReceipt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickReceipt" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="LocationId">LocationId (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="WrapCode">WrapCode.</param>
        /// <param name="WeightPerWrap">WeightPerWrap (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap.</param>
        /// <param name="QuantityPerInnerPack">QuantityPerInnerPack.</param>
        /// <param name="UnitsPerCase">UnitsPerCase.</param>
        /// <param name="QuantityPerPallet">QuantityPerPallet.</param>
        /// <param name="CaseWeight">CaseWeight.</param>
        /// <param name="ProductionLot">ProductionLot.</param>
        /// <param name="RevisionDate">RevisionDate.</param>
        /// <param name="Origin">Origin.</param>
        /// <param name="CartonLength">CartonLength.</param>
        /// <param name="CartonWidth">CartonWidth.</param>
        /// <param name="CartonHeight">CartonHeight.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="SellPrice">SellPrice.</param>
        /// <param name="PricingPer">PricingPer.</param>
        /// <param name="DockDate">DockDate.</param>
        /// <param name="ProductIdTag">ProductIdTag.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>
        public QuickReceipt(int? WarehouseId = default(int?), int? LobId = default(int?), int? LocationId = default(int?), int? Quantity = default(int?), int? VendorId = default(int?), string Carrier = default(string), string WrapCode = default(string), decimal? WeightPerWrap = default(decimal?), int? UnitsPerWrap = default(int?), int? QuantityPerInnerPack = default(int?), int? UnitsPerCase = default(int?), int? QuantityPerPallet = default(int?), decimal? CaseWeight = default(decimal?), string ProductionLot = default(string), string RevisionDate = default(string), string Origin = default(string), decimal? CartonLength = default(decimal?), decimal? CartonWidth = default(decimal?), decimal? CartonHeight = default(decimal?), decimal? Cost = default(decimal?), decimal? SellPrice = default(decimal?), string PricingPer = default(string), DateTime? DockDate = default(DateTime?), string ProductIdTag = default(string), DateTime? ExpirationDate = default(DateTime?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>), string Sku = default(string))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "WeightPerWrap" is required (not null)
            if (WeightPerWrap == null)
            {
                throw new InvalidDataException("WeightPerWrap is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.WeightPerWrap = WeightPerWrap;
            }
            this.VendorId = VendorId;
            this.Carrier = Carrier;
            this.WrapCode = WrapCode;
            this.UnitsPerWrap = UnitsPerWrap;
            this.QuantityPerInnerPack = QuantityPerInnerPack;
            this.UnitsPerCase = UnitsPerCase;
            this.QuantityPerPallet = QuantityPerPallet;
            this.CaseWeight = CaseWeight;
            this.ProductionLot = ProductionLot;
            this.RevisionDate = RevisionDate;
            this.Origin = Origin;
            this.CartonLength = CartonLength;
            this.CartonWidth = CartonWidth;
            this.CartonHeight = CartonHeight;
            this.Cost = Cost;
            this.SellPrice = SellPrice;
            this.PricingPer = PricingPer;
            this.DockDate = DockDate;
            this.ProductIdTag = ProductIdTag;
            this.ExpirationDate = ExpirationDate;
            this.CustomFields = CustomFields;
            this.Sku = Sku;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; private set; }

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
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets UnitCode
        /// </summary>
        [DataMember(Name="unitCode", EmitDefaultValue=false)]
        public string UnitCode { get; private set; }

        /// <summary>
        /// Gets or Sets WrapCode
        /// </summary>
        [DataMember(Name="wrapCode", EmitDefaultValue=false)]
        public string WrapCode { get; set; }

        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public decimal? WeightPerWrap { get; set; }

        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPerInnerPack
        /// </summary>
        [DataMember(Name="quantityPerInnerPack", EmitDefaultValue=false)]
        public int? QuantityPerInnerPack { get; set; }

        /// <summary>
        /// Gets or Sets UnitsPerCase
        /// </summary>
        [DataMember(Name="unitsPerCase", EmitDefaultValue=false)]
        public int? UnitsPerCase { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPerPallet
        /// </summary>
        [DataMember(Name="quantityPerPallet", EmitDefaultValue=false)]
        public int? QuantityPerPallet { get; set; }

        /// <summary>
        /// Gets or Sets CaseWeight
        /// </summary>
        [DataMember(Name="caseWeight", EmitDefaultValue=false)]
        public decimal? CaseWeight { get; set; }

        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; set; }

        /// <summary>
        /// Gets or Sets RevisionDate
        /// </summary>
        [DataMember(Name="revisionDate", EmitDefaultValue=false)]
        public string RevisionDate { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets CartonLength
        /// </summary>
        [DataMember(Name="cartonLength", EmitDefaultValue=false)]
        public decimal? CartonLength { get; set; }

        /// <summary>
        /// Gets or Sets CartonWidth
        /// </summary>
        [DataMember(Name="cartonWidth", EmitDefaultValue=false)]
        public decimal? CartonWidth { get; set; }

        /// <summary>
        /// Gets or Sets CartonHeight
        /// </summary>
        [DataMember(Name="cartonHeight", EmitDefaultValue=false)]
        public decimal? CartonHeight { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Gets or Sets SellPrice
        /// </summary>
        [DataMember(Name="sellPrice", EmitDefaultValue=false)]
        public decimal? SellPrice { get; set; }

        /// <summary>
        /// Gets or Sets PricingPer
        /// </summary>
        [DataMember(Name="pricingPer", EmitDefaultValue=false)]
        public string PricingPer { get; set; }

        /// <summary>
        /// Gets or Sets GeneratedItemReceiptId
        /// </summary>
        [DataMember(Name="generatedItemReceiptId", EmitDefaultValue=false)]
        public int? GeneratedItemReceiptId { get; private set; }

        /// <summary>
        /// Gets or Sets GeneratedASNId
        /// </summary>
        [DataMember(Name="generatedASNId", EmitDefaultValue=false)]
        public int? GeneratedASNId { get; private set; }

        /// <summary>
        /// Gets or Sets DockDate
        /// </summary>
        [DataMember(Name="dockDate", EmitDefaultValue=false)]
        public DateTime? DockDate { get; set; }

        /// <summary>
        /// Gets or Sets ProductIdTag
        /// </summary>
        [DataMember(Name="productIdTag", EmitDefaultValue=false)]
        public string ProductIdTag { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickReceipt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  QuantityPerInnerPack: ").Append(QuantityPerInnerPack).Append("\n");
            sb.Append("  UnitsPerCase: ").Append(UnitsPerCase).Append("\n");
            sb.Append("  QuantityPerPallet: ").Append(QuantityPerPallet).Append("\n");
            sb.Append("  CaseWeight: ").Append(CaseWeight).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  RevisionDate: ").Append(RevisionDate).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  CartonLength: ").Append(CartonLength).Append("\n");
            sb.Append("  CartonWidth: ").Append(CartonWidth).Append("\n");
            sb.Append("  CartonHeight: ").Append(CartonHeight).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  SellPrice: ").Append(SellPrice).Append("\n");
            sb.Append("  PricingPer: ").Append(PricingPer).Append("\n");
            sb.Append("  GeneratedItemReceiptId: ").Append(GeneratedItemReceiptId).Append("\n");
            sb.Append("  GeneratedASNId: ").Append(GeneratedASNId).Append("\n");
            sb.Append("  DockDate: ").Append(DockDate).Append("\n");
            sb.Append("  ProductIdTag: ").Append(ProductIdTag).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(input as QuickReceipt);
        }

        /// <summary>
        /// Returns true if QuickReceipt instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickReceipt input)
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
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UnitCode == input.UnitCode ||
                    (this.UnitCode != null &&
                    this.UnitCode.Equals(input.UnitCode))
                ) && 
                (
                    this.WrapCode == input.WrapCode ||
                    (this.WrapCode != null &&
                    this.WrapCode.Equals(input.WrapCode))
                ) && 
                (
                    this.WeightPerWrap == input.WeightPerWrap ||
                    (this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(input.WeightPerWrap))
                ) && 
                (
                    this.UnitsPerWrap == input.UnitsPerWrap ||
                    (this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(input.UnitsPerWrap))
                ) && 
                (
                    this.QuantityPerInnerPack == input.QuantityPerInnerPack ||
                    (this.QuantityPerInnerPack != null &&
                    this.QuantityPerInnerPack.Equals(input.QuantityPerInnerPack))
                ) && 
                (
                    this.UnitsPerCase == input.UnitsPerCase ||
                    (this.UnitsPerCase != null &&
                    this.UnitsPerCase.Equals(input.UnitsPerCase))
                ) && 
                (
                    this.QuantityPerPallet == input.QuantityPerPallet ||
                    (this.QuantityPerPallet != null &&
                    this.QuantityPerPallet.Equals(input.QuantityPerPallet))
                ) && 
                (
                    this.CaseWeight == input.CaseWeight ||
                    (this.CaseWeight != null &&
                    this.CaseWeight.Equals(input.CaseWeight))
                ) && 
                (
                    this.ProductionLot == input.ProductionLot ||
                    (this.ProductionLot != null &&
                    this.ProductionLot.Equals(input.ProductionLot))
                ) && 
                (
                    this.RevisionDate == input.RevisionDate ||
                    (this.RevisionDate != null &&
                    this.RevisionDate.Equals(input.RevisionDate))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.CartonLength == input.CartonLength ||
                    (this.CartonLength != null &&
                    this.CartonLength.Equals(input.CartonLength))
                ) && 
                (
                    this.CartonWidth == input.CartonWidth ||
                    (this.CartonWidth != null &&
                    this.CartonWidth.Equals(input.CartonWidth))
                ) && 
                (
                    this.CartonHeight == input.CartonHeight ||
                    (this.CartonHeight != null &&
                    this.CartonHeight.Equals(input.CartonHeight))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.SellPrice == input.SellPrice ||
                    (this.SellPrice != null &&
                    this.SellPrice.Equals(input.SellPrice))
                ) && 
                (
                    this.PricingPer == input.PricingPer ||
                    (this.PricingPer != null &&
                    this.PricingPer.Equals(input.PricingPer))
                ) && 
                (
                    this.GeneratedItemReceiptId == input.GeneratedItemReceiptId ||
                    (this.GeneratedItemReceiptId != null &&
                    this.GeneratedItemReceiptId.Equals(input.GeneratedItemReceiptId))
                ) && 
                (
                    this.GeneratedASNId == input.GeneratedASNId ||
                    (this.GeneratedASNId != null &&
                    this.GeneratedASNId.Equals(input.GeneratedASNId))
                ) && 
                (
                    this.DockDate == input.DockDate ||
                    (this.DockDate != null &&
                    this.DockDate.Equals(input.DockDate))
                ) && 
                (
                    this.ProductIdTag == input.ProductIdTag ||
                    (this.ProductIdTag != null &&
                    this.ProductIdTag.Equals(input.ProductIdTag))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UnitCode != null)
                    hashCode = hashCode * 59 + this.UnitCode.GetHashCode();
                if (this.WrapCode != null)
                    hashCode = hashCode * 59 + this.WrapCode.GetHashCode();
                if (this.WeightPerWrap != null)
                    hashCode = hashCode * 59 + this.WeightPerWrap.GetHashCode();
                if (this.UnitsPerWrap != null)
                    hashCode = hashCode * 59 + this.UnitsPerWrap.GetHashCode();
                if (this.QuantityPerInnerPack != null)
                    hashCode = hashCode * 59 + this.QuantityPerInnerPack.GetHashCode();
                if (this.UnitsPerCase != null)
                    hashCode = hashCode * 59 + this.UnitsPerCase.GetHashCode();
                if (this.QuantityPerPallet != null)
                    hashCode = hashCode * 59 + this.QuantityPerPallet.GetHashCode();
                if (this.CaseWeight != null)
                    hashCode = hashCode * 59 + this.CaseWeight.GetHashCode();
                if (this.ProductionLot != null)
                    hashCode = hashCode * 59 + this.ProductionLot.GetHashCode();
                if (this.RevisionDate != null)
                    hashCode = hashCode * 59 + this.RevisionDate.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.CartonLength != null)
                    hashCode = hashCode * 59 + this.CartonLength.GetHashCode();
                if (this.CartonWidth != null)
                    hashCode = hashCode * 59 + this.CartonWidth.GetHashCode();
                if (this.CartonHeight != null)
                    hashCode = hashCode * 59 + this.CartonHeight.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.SellPrice != null)
                    hashCode = hashCode * 59 + this.SellPrice.GetHashCode();
                if (this.PricingPer != null)
                    hashCode = hashCode * 59 + this.PricingPer.GetHashCode();
                if (this.GeneratedItemReceiptId != null)
                    hashCode = hashCode * 59 + this.GeneratedItemReceiptId.GetHashCode();
                if (this.GeneratedASNId != null)
                    hashCode = hashCode * 59 + this.GeneratedASNId.GetHashCode();
                if (this.DockDate != null)
                    hashCode = hashCode * 59 + this.DockDate.GetHashCode();
                if (this.ProductIdTag != null)
                    hashCode = hashCode * 59 + this.ProductIdTag.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
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
