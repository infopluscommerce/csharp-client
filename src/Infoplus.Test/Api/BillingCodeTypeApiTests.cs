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
    ///  Class for testing BillingCodeTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingCodeTypeApiTests
    {
        private BillingCodeTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingCodeTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingCodeTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingCodeTypeApi
            //Assert.IsInstanceOfType(typeof(BillingCodeTypeApi), instance, "instance is a BillingCodeTypeApi");
        }

        
        /// <summary>
        /// Test AddBillingCodeType
        /// </summary>
        [Test]
        public void AddBillingCodeTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCodeType body = null;
            //var response = instance.AddBillingCodeType(body);
            //Assert.IsInstanceOf<BillingCodeType> (response, "response is BillingCodeType");
        }
        
        /// <summary>
        /// Test AddBillingCodeTypeAudit
        /// </summary>
        [Test]
        public void AddBillingCodeTypeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //string billingCodeTypeAudit = null;
            //instance.AddBillingCodeTypeAudit(billingCodeTypeId, billingCodeTypeAudit);
            
        }
        
        /// <summary>
        /// Test AddBillingCodeTypeTag
        /// </summary>
        [Test]
        public void AddBillingCodeTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //string billingCodeTypeTag = null;
            //instance.AddBillingCodeTypeTag(billingCodeTypeId, billingCodeTypeTag);
            
        }
        
        /// <summary>
        /// Test DeleteBillingCodeType
        /// </summary>
        [Test]
        public void DeleteBillingCodeTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //instance.DeleteBillingCodeType(billingCodeTypeId);
            
        }
        
        /// <summary>
        /// Test DeleteBillingCodeTypeTag
        /// </summary>
        [Test]
        public void DeleteBillingCodeTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //string billingCodeTypeTag = null;
            //instance.DeleteBillingCodeTypeTag(billingCodeTypeId, billingCodeTypeTag);
            
        }
        
        /// <summary>
        /// Test GetBillingCodeTypeByFilter
        /// </summary>
        [Test]
        public void GetBillingCodeTypeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetBillingCodeTypeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<BillingCodeType>> (response, "response is List<BillingCodeType>");
        }
        
        /// <summary>
        /// Test GetBillingCodeTypeById
        /// </summary>
        [Test]
        public void GetBillingCodeTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //var response = instance.GetBillingCodeTypeById(billingCodeTypeId);
            //Assert.IsInstanceOf<BillingCodeType> (response, "response is BillingCodeType");
        }
        
        /// <summary>
        /// Test GetBillingCodeTypeTags
        /// </summary>
        [Test]
        public void GetBillingCodeTypeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //instance.GetBillingCodeTypeTags(billingCodeTypeId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateBillingCodeTypeById
        /// </summary>
        [Test]
        public void GetDuplicateBillingCodeTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeTypeId = null;
            //var response = instance.GetDuplicateBillingCodeTypeById(billingCodeTypeId);
            //Assert.IsInstanceOf<BillingCodeType> (response, "response is BillingCodeType");
        }
        
        /// <summary>
        /// Test UpdateBillingCodeType
        /// </summary>
        [Test]
        public void UpdateBillingCodeTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCodeType body = null;
            //instance.UpdateBillingCodeType(body);
            
        }
        
        /// <summary>
        /// Test UpdateBillingCodeTypeCustomFields
        /// </summary>
        [Test]
        public void UpdateBillingCodeTypeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCodeType body = null;
            //instance.UpdateBillingCodeTypeCustomFields(body);
            
        }
        
    }

}
