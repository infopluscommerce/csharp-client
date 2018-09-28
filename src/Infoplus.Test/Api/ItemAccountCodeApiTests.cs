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
    ///  Class for testing ItemAccountCodeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemAccountCodeApiTests
    {
        private ItemAccountCodeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemAccountCodeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemAccountCodeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemAccountCodeApi
            //Assert.IsInstanceOfType(typeof(ItemAccountCodeApi), instance, "instance is a ItemAccountCodeApi");
        }

        
        /// <summary>
        /// Test AddItemAccountCode
        /// </summary>
        [Test]
        public void AddItemAccountCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemAccountCode body = null;
            //var response = instance.AddItemAccountCode(body);
            //Assert.IsInstanceOf<ItemAccountCode> (response, "response is ItemAccountCode");
        }
        
        /// <summary>
        /// Test AddItemAccountCodeAudit
        /// </summary>
        [Test]
        public void AddItemAccountCodeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //string itemAccountCodeAudit = null;
            //instance.AddItemAccountCodeAudit(itemAccountCodeId, itemAccountCodeAudit);
            
        }
        
        /// <summary>
        /// Test AddItemAccountCodeTag
        /// </summary>
        [Test]
        public void AddItemAccountCodeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //string itemAccountCodeTag = null;
            //instance.AddItemAccountCodeTag(itemAccountCodeId, itemAccountCodeTag);
            
        }
        
        /// <summary>
        /// Test DeleteItemAccountCode
        /// </summary>
        [Test]
        public void DeleteItemAccountCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //instance.DeleteItemAccountCode(itemAccountCodeId);
            
        }
        
        /// <summary>
        /// Test DeleteItemAccountCodeTag
        /// </summary>
        [Test]
        public void DeleteItemAccountCodeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //string itemAccountCodeTag = null;
            //instance.DeleteItemAccountCodeTag(itemAccountCodeId, itemAccountCodeTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateItemAccountCodeById
        /// </summary>
        [Test]
        public void GetDuplicateItemAccountCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //var response = instance.GetDuplicateItemAccountCodeById(itemAccountCodeId);
            //Assert.IsInstanceOf<ItemAccountCode> (response, "response is ItemAccountCode");
        }
        
        /// <summary>
        /// Test GetItemAccountCodeByFilter
        /// </summary>
        [Test]
        public void GetItemAccountCodeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemAccountCodeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ItemAccountCode>> (response, "response is List<ItemAccountCode>");
        }
        
        /// <summary>
        /// Test GetItemAccountCodeById
        /// </summary>
        [Test]
        public void GetItemAccountCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //var response = instance.GetItemAccountCodeById(itemAccountCodeId);
            //Assert.IsInstanceOf<ItemAccountCode> (response, "response is ItemAccountCode");
        }
        
        /// <summary>
        /// Test GetItemAccountCodeTags
        /// </summary>
        [Test]
        public void GetItemAccountCodeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemAccountCodeId = null;
            //instance.GetItemAccountCodeTags(itemAccountCodeId);
            
        }
        
        /// <summary>
        /// Test UpdateItemAccountCode
        /// </summary>
        [Test]
        public void UpdateItemAccountCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemAccountCode body = null;
            //instance.UpdateItemAccountCode(body);
            
        }
        
    }

}
