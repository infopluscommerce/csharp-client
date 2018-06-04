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
    ///  Class for testing LocationBillingTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationBillingTypeApiTests
    {
        private LocationBillingTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationBillingTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationBillingTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocationBillingTypeApi
            //Assert.IsInstanceOfType(typeof(LocationBillingTypeApi), instance, "instance is a LocationBillingTypeApi");
        }

        
        /// <summary>
        /// Test AddLocationBillingType
        /// </summary>
        [Test]
        public void AddLocationBillingTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationBillingType body = null;
            //var response = instance.AddLocationBillingType(body);
            //Assert.IsInstanceOf<LocationBillingType> (response, "response is LocationBillingType");
        }
        
        /// <summary>
        /// Test AddLocationBillingTypeAudit
        /// </summary>
        [Test]
        public void AddLocationBillingTypeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //string locationBillingTypeAudit = null;
            //instance.AddLocationBillingTypeAudit(locationBillingTypeId, locationBillingTypeAudit);
            
        }
        
        /// <summary>
        /// Test AddLocationBillingTypeTag
        /// </summary>
        [Test]
        public void AddLocationBillingTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //string locationBillingTypeTag = null;
            //instance.AddLocationBillingTypeTag(locationBillingTypeId, locationBillingTypeTag);
            
        }
        
        /// <summary>
        /// Test DeleteLocationBillingType
        /// </summary>
        [Test]
        public void DeleteLocationBillingTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //instance.DeleteLocationBillingType(locationBillingTypeId);
            
        }
        
        /// <summary>
        /// Test DeleteLocationBillingTypeTag
        /// </summary>
        [Test]
        public void DeleteLocationBillingTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //string locationBillingTypeTag = null;
            //instance.DeleteLocationBillingTypeTag(locationBillingTypeId, locationBillingTypeTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateLocationBillingTypeById
        /// </summary>
        [Test]
        public void GetDuplicateLocationBillingTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //var response = instance.GetDuplicateLocationBillingTypeById(locationBillingTypeId);
            //Assert.IsInstanceOf<LocationBillingType> (response, "response is LocationBillingType");
        }
        
        /// <summary>
        /// Test GetLocationBillingTypeByFilter
        /// </summary>
        [Test]
        public void GetLocationBillingTypeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetLocationBillingTypeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<LocationBillingType>> (response, "response is List<LocationBillingType>");
        }
        
        /// <summary>
        /// Test GetLocationBillingTypeById
        /// </summary>
        [Test]
        public void GetLocationBillingTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //var response = instance.GetLocationBillingTypeById(locationBillingTypeId);
            //Assert.IsInstanceOf<LocationBillingType> (response, "response is LocationBillingType");
        }
        
        /// <summary>
        /// Test GetLocationBillingTypeTags
        /// </summary>
        [Test]
        public void GetLocationBillingTypeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationBillingTypeId = null;
            //instance.GetLocationBillingTypeTags(locationBillingTypeId);
            
        }
        
        /// <summary>
        /// Test UpdateLocationBillingType
        /// </summary>
        [Test]
        public void UpdateLocationBillingTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationBillingType body = null;
            //instance.UpdateLocationBillingType(body);
            
        }
        
        /// <summary>
        /// Test UpdateLocationBillingTypeCustomFields
        /// </summary>
        [Test]
        public void UpdateLocationBillingTypeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationBillingType body = null;
            //instance.UpdateLocationBillingTypeCustomFields(body);
            
        }
        
    }

}
