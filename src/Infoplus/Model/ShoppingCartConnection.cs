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
    /// ShoppingCartConnection
    /// </summary>
    [DataContract]
    public partial class ShoppingCartConnection :  IEquatable<ShoppingCartConnection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartConnection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShoppingCartConnection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartConnection" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="IntegrationPartnerId">IntegrationPartnerId (required).</param>
        /// <param name="ConnectionType">ConnectionType (required).</param>
        /// <param name="ItemFilterId">ItemFilterId.</param>
        /// <param name="InfoplusSKUFieldToMap">InfoplusSKUFieldToMap (required).</param>
        /// <param name="ShoppingCartSKUFieldToMap">ShoppingCartSKUFieldToMap (required).</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="ShoppingCartStoreURL">ShoppingCartStoreURL (required).</param>
        /// <param name="AccessCode">AccessCode (required).</param>
        /// <param name="AccessToken">AccessToken (required).</param>
        /// <param name="Username">Username (required).</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="DefaultCarrierId">DefaultCarrierId.</param>
        /// <param name="OrderShipmentLevel">OrderShipmentLevel (required).</param>
        /// <param name="CreateInvoices">CreateInvoices (default to false).</param>
        /// <param name="SyncOrders">SyncOrders (required) (default to false).</param>
        /// <param name="SyncInventory">SyncInventory (required) (default to false).</param>
        /// <param name="SyncTrackingData">SyncTrackingData (required) (default to false).</param>
        /// <param name="FulfillAllItems">FulfillAllItems (required) (default to false).</param>
        /// <param name="InventoryLevelWarehouseControls">InventoryLevelWarehouseControls (required).</param>
        /// <param name="WarehouseList">WarehouseList.</param>
        /// <param name="InventoryLevelStoreControls">InventoryLevelStoreControls (required).</param>
        /// <param name="StoreList">StoreList.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public ShoppingCartConnection(int? LobId = default(int?), int? OrderSourceId = default(int?), int? IntegrationPartnerId = default(int?), string ConnectionType = default(string), int? ItemFilterId = default(int?), string InfoplusSKUFieldToMap = default(string), string ShoppingCartSKUFieldToMap = default(string), int? ScriptId = default(int?), string Name = default(string), string ShoppingCartStoreURL = default(string), string AccessCode = default(string), string AccessToken = default(string), string Username = default(string), string Password = default(string), int? DefaultCarrierId = default(int?), string OrderShipmentLevel = default(string), bool? CreateInvoices = false, bool? SyncOrders = false, bool? SyncInventory = false, bool? SyncTrackingData = false, bool? FulfillAllItems = false, string InventoryLevelWarehouseControls = default(string), List<Warehouse> WarehouseList = default(List<Warehouse>), string InventoryLevelStoreControls = default(string), List<Store> StoreList = default(List<Store>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "OrderSourceId" is required (not null)
            if (OrderSourceId == null)
            {
                throw new InvalidDataException("OrderSourceId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.OrderSourceId = OrderSourceId;
            }
            // to ensure "IntegrationPartnerId" is required (not null)
            if (IntegrationPartnerId == null)
            {
                throw new InvalidDataException("IntegrationPartnerId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.IntegrationPartnerId = IntegrationPartnerId;
            }
            // to ensure "ConnectionType" is required (not null)
            if (ConnectionType == null)
            {
                throw new InvalidDataException("ConnectionType is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ConnectionType = ConnectionType;
            }
            // to ensure "InfoplusSKUFieldToMap" is required (not null)
            if (InfoplusSKUFieldToMap == null)
            {
                throw new InvalidDataException("InfoplusSKUFieldToMap is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.InfoplusSKUFieldToMap = InfoplusSKUFieldToMap;
            }
            // to ensure "ShoppingCartSKUFieldToMap" is required (not null)
            if (ShoppingCartSKUFieldToMap == null)
            {
                throw new InvalidDataException("ShoppingCartSKUFieldToMap is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ShoppingCartSKUFieldToMap = ShoppingCartSKUFieldToMap;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShoppingCartStoreURL" is required (not null)
            if (ShoppingCartStoreURL == null)
            {
                throw new InvalidDataException("ShoppingCartStoreURL is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ShoppingCartStoreURL = ShoppingCartStoreURL;
            }
            // to ensure "AccessCode" is required (not null)
            if (AccessCode == null)
            {
                throw new InvalidDataException("AccessCode is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.AccessCode = AccessCode;
            }
            // to ensure "AccessToken" is required (not null)
            if (AccessToken == null)
            {
                throw new InvalidDataException("AccessToken is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.AccessToken = AccessToken;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "OrderShipmentLevel" is required (not null)
            if (OrderShipmentLevel == null)
            {
                throw new InvalidDataException("OrderShipmentLevel is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.OrderShipmentLevel = OrderShipmentLevel;
            }
            // to ensure "SyncOrders" is required (not null)
            if (SyncOrders == null)
            {
                throw new InvalidDataException("SyncOrders is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncOrders = SyncOrders;
            }
            // to ensure "SyncInventory" is required (not null)
            if (SyncInventory == null)
            {
                throw new InvalidDataException("SyncInventory is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncInventory = SyncInventory;
            }
            // to ensure "SyncTrackingData" is required (not null)
            if (SyncTrackingData == null)
            {
                throw new InvalidDataException("SyncTrackingData is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncTrackingData = SyncTrackingData;
            }
            // to ensure "FulfillAllItems" is required (not null)
            if (FulfillAllItems == null)
            {
                throw new InvalidDataException("FulfillAllItems is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.FulfillAllItems = FulfillAllItems;
            }
            // to ensure "InventoryLevelWarehouseControls" is required (not null)
            if (InventoryLevelWarehouseControls == null)
            {
                throw new InvalidDataException("InventoryLevelWarehouseControls is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.InventoryLevelWarehouseControls = InventoryLevelWarehouseControls;
            }
            // to ensure "InventoryLevelStoreControls" is required (not null)
            if (InventoryLevelStoreControls == null)
            {
                throw new InvalidDataException("InventoryLevelStoreControls is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.InventoryLevelStoreControls = InventoryLevelStoreControls;
            }
            this.ItemFilterId = ItemFilterId;
            this.ScriptId = ScriptId;
            this.DefaultCarrierId = DefaultCarrierId;
            // use default value if no "CreateInvoices" provided
            if (CreateInvoices == null)
            {
                this.CreateInvoices = false;
            }
            else
            {
                this.CreateInvoices = CreateInvoices;
            }
            this.WarehouseList = WarehouseList;
            this.StoreList = StoreList;
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
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public int? ClientId { get; private set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationPartnerId
        /// </summary>
        [DataMember(Name="integrationPartnerId", EmitDefaultValue=false)]
        public int? IntegrationPartnerId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name="connectionType", EmitDefaultValue=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets ItemFilterId
        /// </summary>
        [DataMember(Name="itemFilterId", EmitDefaultValue=false)]
        public int? ItemFilterId { get; set; }

        /// <summary>
        /// Gets or Sets InfoplusSKUFieldToMap
        /// </summary>
        [DataMember(Name="infoplusSKUFieldToMap", EmitDefaultValue=false)]
        public string InfoplusSKUFieldToMap { get; set; }

        /// <summary>
        /// Gets or Sets ShoppingCartSKUFieldToMap
        /// </summary>
        [DataMember(Name="shoppingCartSKUFieldToMap", EmitDefaultValue=false)]
        public string ShoppingCartSKUFieldToMap { get; set; }

        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public int? ScriptId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShoppingCartStoreURL
        /// </summary>
        [DataMember(Name="shoppingCartStoreURL", EmitDefaultValue=false)]
        public string ShoppingCartStoreURL { get; set; }

        /// <summary>
        /// Gets or Sets AccessCode
        /// </summary>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCarrierId
        /// </summary>
        [DataMember(Name="defaultCarrierId", EmitDefaultValue=false)]
        public int? DefaultCarrierId { get; set; }

        /// <summary>
        /// Gets or Sets OrderShipmentLevel
        /// </summary>
        [DataMember(Name="orderShipmentLevel", EmitDefaultValue=false)]
        public string OrderShipmentLevel { get; set; }

        /// <summary>
        /// Gets or Sets CreateInvoices
        /// </summary>
        [DataMember(Name="createInvoices", EmitDefaultValue=false)]
        public bool? CreateInvoices { get; set; }

        /// <summary>
        /// Gets or Sets SyncOrders
        /// </summary>
        [DataMember(Name="syncOrders", EmitDefaultValue=false)]
        public bool? SyncOrders { get; set; }

        /// <summary>
        /// Gets or Sets SyncInventory
        /// </summary>
        [DataMember(Name="syncInventory", EmitDefaultValue=false)]
        public bool? SyncInventory { get; set; }

        /// <summary>
        /// Gets or Sets SyncTrackingData
        /// </summary>
        [DataMember(Name="syncTrackingData", EmitDefaultValue=false)]
        public bool? SyncTrackingData { get; set; }

        /// <summary>
        /// Gets or Sets FulfillAllItems
        /// </summary>
        [DataMember(Name="fulfillAllItems", EmitDefaultValue=false)]
        public bool? FulfillAllItems { get; set; }

        /// <summary>
        /// Gets or Sets SyncInventoryLevelsLastRunTime
        /// </summary>
        [DataMember(Name="syncInventoryLevelsLastRunTime", EmitDefaultValue=false)]
        public DateTime? SyncInventoryLevelsLastRunTime { get; private set; }

        /// <summary>
        /// Gets or Sets SyncOrdersLastRunTime
        /// </summary>
        [DataMember(Name="syncOrdersLastRunTime", EmitDefaultValue=false)]
        public DateTime? SyncOrdersLastRunTime { get; private set; }

        /// <summary>
        /// Gets or Sets InventoryLevelWarehouseControls
        /// </summary>
        [DataMember(Name="inventoryLevelWarehouseControls", EmitDefaultValue=false)]
        public string InventoryLevelWarehouseControls { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseList
        /// </summary>
        [DataMember(Name="warehouseList", EmitDefaultValue=false)]
        public List<Warehouse> WarehouseList { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLevelStoreControls
        /// </summary>
        [DataMember(Name="inventoryLevelStoreControls", EmitDefaultValue=false)]
        public string InventoryLevelStoreControls { get; set; }

        /// <summary>
        /// Gets or Sets StoreList
        /// </summary>
        [DataMember(Name="storeList", EmitDefaultValue=false)]
        public List<Store> StoreList { get; set; }

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
            sb.Append("class ShoppingCartConnection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  IntegrationPartnerId: ").Append(IntegrationPartnerId).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  ItemFilterId: ").Append(ItemFilterId).Append("\n");
            sb.Append("  InfoplusSKUFieldToMap: ").Append(InfoplusSKUFieldToMap).Append("\n");
            sb.Append("  ShoppingCartSKUFieldToMap: ").Append(ShoppingCartSKUFieldToMap).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShoppingCartStoreURL: ").Append(ShoppingCartStoreURL).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DefaultCarrierId: ").Append(DefaultCarrierId).Append("\n");
            sb.Append("  OrderShipmentLevel: ").Append(OrderShipmentLevel).Append("\n");
            sb.Append("  CreateInvoices: ").Append(CreateInvoices).Append("\n");
            sb.Append("  SyncOrders: ").Append(SyncOrders).Append("\n");
            sb.Append("  SyncInventory: ").Append(SyncInventory).Append("\n");
            sb.Append("  SyncTrackingData: ").Append(SyncTrackingData).Append("\n");
            sb.Append("  FulfillAllItems: ").Append(FulfillAllItems).Append("\n");
            sb.Append("  SyncInventoryLevelsLastRunTime: ").Append(SyncInventoryLevelsLastRunTime).Append("\n");
            sb.Append("  SyncOrdersLastRunTime: ").Append(SyncOrdersLastRunTime).Append("\n");
            sb.Append("  InventoryLevelWarehouseControls: ").Append(InventoryLevelWarehouseControls).Append("\n");
            sb.Append("  WarehouseList: ").Append(WarehouseList).Append("\n");
            sb.Append("  InventoryLevelStoreControls: ").Append(InventoryLevelStoreControls).Append("\n");
            sb.Append("  StoreList: ").Append(StoreList).Append("\n");
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
            return this.Equals(input as ShoppingCartConnection);
        }

        /// <summary>
        /// Returns true if ShoppingCartConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of ShoppingCartConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShoppingCartConnection input)
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
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.OrderSourceId == input.OrderSourceId ||
                    (this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(input.OrderSourceId))
                ) && 
                (
                    this.IntegrationPartnerId == input.IntegrationPartnerId ||
                    (this.IntegrationPartnerId != null &&
                    this.IntegrationPartnerId.Equals(input.IntegrationPartnerId))
                ) && 
                (
                    this.ConnectionType == input.ConnectionType ||
                    (this.ConnectionType != null &&
                    this.ConnectionType.Equals(input.ConnectionType))
                ) && 
                (
                    this.ItemFilterId == input.ItemFilterId ||
                    (this.ItemFilterId != null &&
                    this.ItemFilterId.Equals(input.ItemFilterId))
                ) && 
                (
                    this.InfoplusSKUFieldToMap == input.InfoplusSKUFieldToMap ||
                    (this.InfoplusSKUFieldToMap != null &&
                    this.InfoplusSKUFieldToMap.Equals(input.InfoplusSKUFieldToMap))
                ) && 
                (
                    this.ShoppingCartSKUFieldToMap == input.ShoppingCartSKUFieldToMap ||
                    (this.ShoppingCartSKUFieldToMap != null &&
                    this.ShoppingCartSKUFieldToMap.Equals(input.ShoppingCartSKUFieldToMap))
                ) && 
                (
                    this.ScriptId == input.ScriptId ||
                    (this.ScriptId != null &&
                    this.ScriptId.Equals(input.ScriptId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShoppingCartStoreURL == input.ShoppingCartStoreURL ||
                    (this.ShoppingCartStoreURL != null &&
                    this.ShoppingCartStoreURL.Equals(input.ShoppingCartStoreURL))
                ) && 
                (
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.DefaultCarrierId == input.DefaultCarrierId ||
                    (this.DefaultCarrierId != null &&
                    this.DefaultCarrierId.Equals(input.DefaultCarrierId))
                ) && 
                (
                    this.OrderShipmentLevel == input.OrderShipmentLevel ||
                    (this.OrderShipmentLevel != null &&
                    this.OrderShipmentLevel.Equals(input.OrderShipmentLevel))
                ) && 
                (
                    this.CreateInvoices == input.CreateInvoices ||
                    (this.CreateInvoices != null &&
                    this.CreateInvoices.Equals(input.CreateInvoices))
                ) && 
                (
                    this.SyncOrders == input.SyncOrders ||
                    (this.SyncOrders != null &&
                    this.SyncOrders.Equals(input.SyncOrders))
                ) && 
                (
                    this.SyncInventory == input.SyncInventory ||
                    (this.SyncInventory != null &&
                    this.SyncInventory.Equals(input.SyncInventory))
                ) && 
                (
                    this.SyncTrackingData == input.SyncTrackingData ||
                    (this.SyncTrackingData != null &&
                    this.SyncTrackingData.Equals(input.SyncTrackingData))
                ) && 
                (
                    this.FulfillAllItems == input.FulfillAllItems ||
                    (this.FulfillAllItems != null &&
                    this.FulfillAllItems.Equals(input.FulfillAllItems))
                ) && 
                (
                    this.SyncInventoryLevelsLastRunTime == input.SyncInventoryLevelsLastRunTime ||
                    (this.SyncInventoryLevelsLastRunTime != null &&
                    this.SyncInventoryLevelsLastRunTime.Equals(input.SyncInventoryLevelsLastRunTime))
                ) && 
                (
                    this.SyncOrdersLastRunTime == input.SyncOrdersLastRunTime ||
                    (this.SyncOrdersLastRunTime != null &&
                    this.SyncOrdersLastRunTime.Equals(input.SyncOrdersLastRunTime))
                ) && 
                (
                    this.InventoryLevelWarehouseControls == input.InventoryLevelWarehouseControls ||
                    (this.InventoryLevelWarehouseControls != null &&
                    this.InventoryLevelWarehouseControls.Equals(input.InventoryLevelWarehouseControls))
                ) && 
                (
                    this.WarehouseList == input.WarehouseList ||
                    this.WarehouseList != null &&
                    this.WarehouseList.SequenceEqual(input.WarehouseList)
                ) && 
                (
                    this.InventoryLevelStoreControls == input.InventoryLevelStoreControls ||
                    (this.InventoryLevelStoreControls != null &&
                    this.InventoryLevelStoreControls.Equals(input.InventoryLevelStoreControls))
                ) && 
                (
                    this.StoreList == input.StoreList ||
                    this.StoreList != null &&
                    this.StoreList.SequenceEqual(input.StoreList)
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.OrderSourceId != null)
                    hashCode = hashCode * 59 + this.OrderSourceId.GetHashCode();
                if (this.IntegrationPartnerId != null)
                    hashCode = hashCode * 59 + this.IntegrationPartnerId.GetHashCode();
                if (this.ConnectionType != null)
                    hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
                if (this.ItemFilterId != null)
                    hashCode = hashCode * 59 + this.ItemFilterId.GetHashCode();
                if (this.InfoplusSKUFieldToMap != null)
                    hashCode = hashCode * 59 + this.InfoplusSKUFieldToMap.GetHashCode();
                if (this.ShoppingCartSKUFieldToMap != null)
                    hashCode = hashCode * 59 + this.ShoppingCartSKUFieldToMap.GetHashCode();
                if (this.ScriptId != null)
                    hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShoppingCartStoreURL != null)
                    hashCode = hashCode * 59 + this.ShoppingCartStoreURL.GetHashCode();
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.DefaultCarrierId != null)
                    hashCode = hashCode * 59 + this.DefaultCarrierId.GetHashCode();
                if (this.OrderShipmentLevel != null)
                    hashCode = hashCode * 59 + this.OrderShipmentLevel.GetHashCode();
                if (this.CreateInvoices != null)
                    hashCode = hashCode * 59 + this.CreateInvoices.GetHashCode();
                if (this.SyncOrders != null)
                    hashCode = hashCode * 59 + this.SyncOrders.GetHashCode();
                if (this.SyncInventory != null)
                    hashCode = hashCode * 59 + this.SyncInventory.GetHashCode();
                if (this.SyncTrackingData != null)
                    hashCode = hashCode * 59 + this.SyncTrackingData.GetHashCode();
                if (this.FulfillAllItems != null)
                    hashCode = hashCode * 59 + this.FulfillAllItems.GetHashCode();
                if (this.SyncInventoryLevelsLastRunTime != null)
                    hashCode = hashCode * 59 + this.SyncInventoryLevelsLastRunTime.GetHashCode();
                if (this.SyncOrdersLastRunTime != null)
                    hashCode = hashCode * 59 + this.SyncOrdersLastRunTime.GetHashCode();
                if (this.InventoryLevelWarehouseControls != null)
                    hashCode = hashCode * 59 + this.InventoryLevelWarehouseControls.GetHashCode();
                if (this.WarehouseList != null)
                    hashCode = hashCode * 59 + this.WarehouseList.GetHashCode();
                if (this.InventoryLevelStoreControls != null)
                    hashCode = hashCode * 59 + this.InventoryLevelStoreControls.GetHashCode();
                if (this.StoreList != null)
                    hashCode = hashCode * 59 + this.StoreList.GetHashCode();
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
