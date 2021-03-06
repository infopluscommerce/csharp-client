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
    ///  Class for testing ItemLowstockCodeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemLowstockCodeApiTests
    {
        private ItemLowstockCodeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemLowstockCodeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemLowstockCodeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemLowstockCodeApi
            //Assert.IsInstanceOfType(typeof(ItemLowstockCodeApi), instance, "instance is a ItemLowstockCodeApi");
        }

        
        /// <summary>
        /// Test AddItemLowstockCode
        /// </summary>
        [Test]
        public void AddItemLowstockCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemLowstockCode body = null;
            //var response = instance.AddItemLowstockCode(body);
            //Assert.IsInstanceOf<ItemLowstockCode> (response, "response is ItemLowstockCode");
        }
        
        /// <summary>
        /// Test AddItemLowstockCodeAudit
        /// </summary>
        [Test]
        public void AddItemLowstockCodeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //string itemLowstockCodeAudit = null;
            //instance.AddItemLowstockCodeAudit(itemLowstockCodeId, itemLowstockCodeAudit);
            
        }
        
        /// <summary>
        /// Test AddItemLowstockCodeFile
        /// </summary>
        [Test]
        public void AddItemLowstockCodeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //string fileName = null;
            //instance.AddItemLowstockCodeFile(itemLowstockCodeId, fileName);
            
        }
        
        /// <summary>
        /// Test AddItemLowstockCodeFileByURL
        /// </summary>
        [Test]
        public void AddItemLowstockCodeFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? itemLowstockCodeId = null;
            //instance.AddItemLowstockCodeFileByURL(body, itemLowstockCodeId);
            
        }
        
        /// <summary>
        /// Test AddItemLowstockCodeTag
        /// </summary>
        [Test]
        public void AddItemLowstockCodeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //string itemLowstockCodeTag = null;
            //instance.AddItemLowstockCodeTag(itemLowstockCodeId, itemLowstockCodeTag);
            
        }
        
        /// <summary>
        /// Test DeleteItemLowstockCode
        /// </summary>
        [Test]
        public void DeleteItemLowstockCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //instance.DeleteItemLowstockCode(itemLowstockCodeId);
            
        }
        
        /// <summary>
        /// Test DeleteItemLowstockCodeFile
        /// </summary>
        [Test]
        public void DeleteItemLowstockCodeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //int? fileId = null;
            //instance.DeleteItemLowstockCodeFile(itemLowstockCodeId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteItemLowstockCodeTag
        /// </summary>
        [Test]
        public void DeleteItemLowstockCodeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //string itemLowstockCodeTag = null;
            //instance.DeleteItemLowstockCodeTag(itemLowstockCodeId, itemLowstockCodeTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateItemLowstockCodeById
        /// </summary>
        [Test]
        public void GetDuplicateItemLowstockCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //var response = instance.GetDuplicateItemLowstockCodeById(itemLowstockCodeId);
            //Assert.IsInstanceOf<ItemLowstockCode> (response, "response is ItemLowstockCode");
        }
        
        /// <summary>
        /// Test GetItemLowstockCodeByFilter
        /// </summary>
        [Test]
        public void GetItemLowstockCodeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemLowstockCodeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ItemLowstockCode>> (response, "response is List<ItemLowstockCode>");
        }
        
        /// <summary>
        /// Test GetItemLowstockCodeById
        /// </summary>
        [Test]
        public void GetItemLowstockCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //var response = instance.GetItemLowstockCodeById(itemLowstockCodeId);
            //Assert.IsInstanceOf<ItemLowstockCode> (response, "response is ItemLowstockCode");
        }
        
        /// <summary>
        /// Test GetItemLowstockCodeFiles
        /// </summary>
        [Test]
        public void GetItemLowstockCodeFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //instance.GetItemLowstockCodeFiles(itemLowstockCodeId);
            
        }
        
        /// <summary>
        /// Test GetItemLowstockCodeTags
        /// </summary>
        [Test]
        public void GetItemLowstockCodeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemLowstockCodeId = null;
            //instance.GetItemLowstockCodeTags(itemLowstockCodeId);
            
        }
        
        /// <summary>
        /// Test UpdateItemLowstockCode
        /// </summary>
        [Test]
        public void UpdateItemLowstockCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemLowstockCode body = null;
            //instance.UpdateItemLowstockCode(body);
            
        }
        
    }

}
