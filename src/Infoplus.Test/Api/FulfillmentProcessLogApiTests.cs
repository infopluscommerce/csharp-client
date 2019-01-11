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
    ///  Class for testing FulfillmentProcessLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FulfillmentProcessLogApiTests
    {
        private FulfillmentProcessLogApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FulfillmentProcessLogApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentProcessLogApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FulfillmentProcessLogApi
            //Assert.IsInstanceOfType(typeof(FulfillmentProcessLogApi), instance, "instance is a FulfillmentProcessLogApi");
        }

        
        /// <summary>
        /// Test AddFulfillmentProcessLogAudit
        /// </summary>
        [Test]
        public void AddFulfillmentProcessLogAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //string fulfillmentProcessLogAudit = null;
            //instance.AddFulfillmentProcessLogAudit(fulfillmentProcessLogId, fulfillmentProcessLogAudit);
            
        }
        
        /// <summary>
        /// Test AddFulfillmentProcessLogTag
        /// </summary>
        [Test]
        public void AddFulfillmentProcessLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //string fulfillmentProcessLogTag = null;
            //instance.AddFulfillmentProcessLogTag(fulfillmentProcessLogId, fulfillmentProcessLogTag);
            
        }
        
        /// <summary>
        /// Test DeleteFulfillmentProcessLogTag
        /// </summary>
        [Test]
        public void DeleteFulfillmentProcessLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //string fulfillmentProcessLogTag = null;
            //instance.DeleteFulfillmentProcessLogTag(fulfillmentProcessLogId, fulfillmentProcessLogTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateFulfillmentProcessLogById
        /// </summary>
        [Test]
        public void GetDuplicateFulfillmentProcessLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //var response = instance.GetDuplicateFulfillmentProcessLogById(fulfillmentProcessLogId);
            //Assert.IsInstanceOf<FulfillmentProcessLog> (response, "response is FulfillmentProcessLog");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessLogByFilter
        /// </summary>
        [Test]
        public void GetFulfillmentProcessLogByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetFulfillmentProcessLogByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<FulfillmentProcessLog>> (response, "response is List<FulfillmentProcessLog>");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessLogById
        /// </summary>
        [Test]
        public void GetFulfillmentProcessLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //var response = instance.GetFulfillmentProcessLogById(fulfillmentProcessLogId);
            //Assert.IsInstanceOf<FulfillmentProcessLog> (response, "response is FulfillmentProcessLog");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessLogTags
        /// </summary>
        [Test]
        public void GetFulfillmentProcessLogTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessLogId = null;
            //instance.GetFulfillmentProcessLogTags(fulfillmentProcessLogId);
            
        }
        
    }

}
