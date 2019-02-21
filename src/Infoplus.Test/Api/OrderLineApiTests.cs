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
    ///  Class for testing OrderLineApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderLineApiTests
    {
        private OrderLineApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderLineApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderLineApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderLineApi
            //Assert.IsInstanceOfType(typeof(OrderLineApi), instance, "instance is a OrderLineApi");
        }

        
        /// <summary>
        /// Test AddOrderLineAudit
        /// </summary>
        [Test]
        public void AddOrderLineAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //string orderLineAudit = null;
            //instance.AddOrderLineAudit(orderLineId, orderLineAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderLineTag
        /// </summary>
        [Test]
        public void AddOrderLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //string orderLineTag = null;
            //instance.AddOrderLineTag(orderLineId, orderLineTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderLineTag
        /// </summary>
        [Test]
        public void DeleteOrderLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //string orderLineTag = null;
            //instance.DeleteOrderLineTag(orderLineId, orderLineTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderLineById
        /// </summary>
        [Test]
        public void GetDuplicateOrderLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //var response = instance.GetDuplicateOrderLineById(orderLineId);
            //Assert.IsInstanceOf<OrderLine> (response, "response is OrderLine");
        }
        
        /// <summary>
        /// Test GetOrderLineByFilter
        /// </summary>
        [Test]
        public void GetOrderLineByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderLineByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderLine>> (response, "response is List<OrderLine>");
        }
        
        /// <summary>
        /// Test GetOrderLineById
        /// </summary>
        [Test]
        public void GetOrderLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //var response = instance.GetOrderLineById(orderLineId);
            //Assert.IsInstanceOf<OrderLine> (response, "response is OrderLine");
        }
        
        /// <summary>
        /// Test GetOrderLineTags
        /// </summary>
        [Test]
        public void GetOrderLineTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineId = null;
            //instance.GetOrderLineTags(orderLineId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderLineCustomFields
        /// </summary>
        [Test]
        public void UpdateOrderLineCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderLine body = null;
            //instance.UpdateOrderLineCustomFields(body);
            
        }
        
    }

}
