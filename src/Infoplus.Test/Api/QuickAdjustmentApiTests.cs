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
    ///  Class for testing QuickAdjustmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class QuickAdjustmentApiTests
    {
        private QuickAdjustmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuickAdjustmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuickAdjustmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' QuickAdjustmentApi
            //Assert.IsInstanceOfType(typeof(QuickAdjustmentApi), instance, "instance is a QuickAdjustmentApi");
        }

        
        /// <summary>
        /// Test AddQuickAdjustment
        /// </summary>
        [Test]
        public void AddQuickAdjustmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickAdjustment body = null;
            //var response = instance.AddQuickAdjustment(body);
            //Assert.IsInstanceOf<QuickAdjustment> (response, "response is QuickAdjustment");
        }
        
        /// <summary>
        /// Test AddQuickAdjustmentAudit
        /// </summary>
        [Test]
        public void AddQuickAdjustmentAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //string quickAdjustmentAudit = null;
            //instance.AddQuickAdjustmentAudit(quickAdjustmentId, quickAdjustmentAudit);
            
        }
        
        /// <summary>
        /// Test AddQuickAdjustmentTag
        /// </summary>
        [Test]
        public void AddQuickAdjustmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //string quickAdjustmentTag = null;
            //instance.AddQuickAdjustmentTag(quickAdjustmentId, quickAdjustmentTag);
            
        }
        
        /// <summary>
        /// Test DeleteQuickAdjustment
        /// </summary>
        [Test]
        public void DeleteQuickAdjustmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //instance.DeleteQuickAdjustment(quickAdjustmentId);
            
        }
        
        /// <summary>
        /// Test DeleteQuickAdjustmentTag
        /// </summary>
        [Test]
        public void DeleteQuickAdjustmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //string quickAdjustmentTag = null;
            //instance.DeleteQuickAdjustmentTag(quickAdjustmentId, quickAdjustmentTag);
            
        }
        
        /// <summary>
        /// Test ExecuteQuickAdjustment
        /// </summary>
        [Test]
        public void ExecuteQuickAdjustmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecuteQuickAdjustmentInputAPIModel body = null;
            //var response = instance.ExecuteQuickAdjustment(body);
            //Assert.IsInstanceOf<List<ProcessOutputAPIModel>> (response, "response is List<ProcessOutputAPIModel>");
        }
        
        /// <summary>
        /// Test GetDuplicateQuickAdjustmentById
        /// </summary>
        [Test]
        public void GetDuplicateQuickAdjustmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //var response = instance.GetDuplicateQuickAdjustmentById(quickAdjustmentId);
            //Assert.IsInstanceOf<QuickAdjustment> (response, "response is QuickAdjustment");
        }
        
        /// <summary>
        /// Test GetQuickAdjustmentByFilter
        /// </summary>
        [Test]
        public void GetQuickAdjustmentByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetQuickAdjustmentByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<QuickAdjustment>> (response, "response is List<QuickAdjustment>");
        }
        
        /// <summary>
        /// Test GetQuickAdjustmentById
        /// </summary>
        [Test]
        public void GetQuickAdjustmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //var response = instance.GetQuickAdjustmentById(quickAdjustmentId);
            //Assert.IsInstanceOf<QuickAdjustment> (response, "response is QuickAdjustment");
        }
        
        /// <summary>
        /// Test GetQuickAdjustmentTags
        /// </summary>
        [Test]
        public void GetQuickAdjustmentTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickAdjustmentId = null;
            //instance.GetQuickAdjustmentTags(quickAdjustmentId);
            
        }
        
        /// <summary>
        /// Test UpdateQuickAdjustment
        /// </summary>
        [Test]
        public void UpdateQuickAdjustmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickAdjustment body = null;
            //instance.UpdateQuickAdjustment(body);
            
        }
        
        /// <summary>
        /// Test UpdateQuickAdjustmentCustomFields
        /// </summary>
        [Test]
        public void UpdateQuickAdjustmentCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickAdjustment body = null;
            //instance.UpdateQuickAdjustmentCustomFields(body);
            
        }
        
    }

}
