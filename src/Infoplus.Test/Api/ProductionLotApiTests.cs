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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Infoplus.Client;
using Infoplus.Api;
using Infoplus.Model;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing ProductionLotApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductionLotApiTests
    {
        private ProductionLotApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductionLotApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductionLotApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductionLotApi
            //Assert.IsInstanceOfType(typeof(ProductionLotApi), instance, "instance is a ProductionLotApi");
        }

        
        /// <summary>
        /// Test AddProductionLot
        /// </summary>
        [Test]
        public void AddProductionLotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionLot body = null;
            //var response = instance.AddProductionLot(body);
            //Assert.IsInstanceOf<ProductionLot> (response, "response is ProductionLot");
        }
        
        /// <summary>
        /// Test AddProductionLotAudit
        /// </summary>
        [Test]
        public void AddProductionLotAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //string productionLotAudit = null;
            //instance.AddProductionLotAudit(productionLotId, productionLotAudit);
            
        }
        
        /// <summary>
        /// Test AddProductionLotTag
        /// </summary>
        [Test]
        public void AddProductionLotTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //string productionLotTag = null;
            //instance.AddProductionLotTag(productionLotId, productionLotTag);
            
        }
        
        /// <summary>
        /// Test DeleteProductionLot
        /// </summary>
        [Test]
        public void DeleteProductionLotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //instance.DeleteProductionLot(productionLotId);
            
        }
        
        /// <summary>
        /// Test DeleteProductionLotTag
        /// </summary>
        [Test]
        public void DeleteProductionLotTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //string productionLotTag = null;
            //instance.DeleteProductionLotTag(productionLotId, productionLotTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateProductionLotById
        /// </summary>
        [Test]
        public void GetDuplicateProductionLotByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //var response = instance.GetDuplicateProductionLotById(productionLotId);
            //Assert.IsInstanceOf<ProductionLot> (response, "response is ProductionLot");
        }
        
        /// <summary>
        /// Test GetProductionLotByFilter
        /// </summary>
        [Test]
        public void GetProductionLotByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetProductionLotByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ProductionLot>> (response, "response is List<ProductionLot>");
        }
        
        /// <summary>
        /// Test GetProductionLotById
        /// </summary>
        [Test]
        public void GetProductionLotByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //var response = instance.GetProductionLotById(productionLotId);
            //Assert.IsInstanceOf<ProductionLot> (response, "response is ProductionLot");
        }
        
        /// <summary>
        /// Test GetProductionLotTags
        /// </summary>
        [Test]
        public void GetProductionLotTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //instance.GetProductionLotTags(productionLotId);
            
        }
        
        /// <summary>
        /// Test UpdateProductionLot
        /// </summary>
        [Test]
        public void UpdateProductionLotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionLot body = null;
            //instance.UpdateProductionLot(body);
            
        }
        
        /// <summary>
        /// Test UpdateProductionLotCustomFields
        /// </summary>
        [Test]
        public void UpdateProductionLotCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionLot body = null;
            //instance.UpdateProductionLotCustomFields(body);
            
        }
        
    }

}