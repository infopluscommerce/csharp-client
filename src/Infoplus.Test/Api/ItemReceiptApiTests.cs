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
    ///  Class for testing ItemReceiptApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemReceiptApiTests
    {
        private ItemReceiptApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemReceiptApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemReceiptApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemReceiptApi
            //Assert.IsInstanceOfType(typeof(ItemReceiptApi), instance, "instance is a ItemReceiptApi");
        }

        
        /// <summary>
        /// Test AddItemReceiptAudit
        /// </summary>
        [Test]
        public void AddItemReceiptAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //string itemReceiptAudit = null;
            //instance.AddItemReceiptAudit(itemReceiptId, itemReceiptAudit);
            
        }
        
        /// <summary>
        /// Test AddItemReceiptFile
        /// </summary>
        [Test]
        public void AddItemReceiptFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //string fileName = null;
            //instance.AddItemReceiptFile(itemReceiptId, fileName);
            
        }
        
        /// <summary>
        /// Test AddItemReceiptTag
        /// </summary>
        [Test]
        public void AddItemReceiptTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //string itemReceiptTag = null;
            //instance.AddItemReceiptTag(itemReceiptId, itemReceiptTag);
            
        }
        
        /// <summary>
        /// Test DeleteItemReceiptTag
        /// </summary>
        [Test]
        public void DeleteItemReceiptTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //string itemReceiptTag = null;
            //instance.DeleteItemReceiptTag(itemReceiptId, itemReceiptTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateItemReceiptById
        /// </summary>
        [Test]
        public void GetDuplicateItemReceiptByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //var response = instance.GetDuplicateItemReceiptById(itemReceiptId);
            //Assert.IsInstanceOf<ItemReceipt> (response, "response is ItemReceipt");
        }
        
        /// <summary>
        /// Test GetItemReceiptByFilter
        /// </summary>
        [Test]
        public void GetItemReceiptByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemReceiptByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ItemReceipt>> (response, "response is List<ItemReceipt>");
        }
        
        /// <summary>
        /// Test GetItemReceiptById
        /// </summary>
        [Test]
        public void GetItemReceiptByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //var response = instance.GetItemReceiptById(itemReceiptId);
            //Assert.IsInstanceOf<ItemReceipt> (response, "response is ItemReceipt");
        }
        
        /// <summary>
        /// Test GetItemReceiptTags
        /// </summary>
        [Test]
        public void GetItemReceiptTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemReceiptId = null;
            //instance.GetItemReceiptTags(itemReceiptId);
            
        }
        
        /// <summary>
        /// Test UpdateItemReceipt
        /// </summary>
        [Test]
        public void UpdateItemReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemReceipt body = null;
            //instance.UpdateItemReceipt(body);
            
        }
        
        /// <summary>
        /// Test UpdateItemReceiptCustomFields
        /// </summary>
        [Test]
        public void UpdateItemReceiptCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemReceipt body = null;
            //instance.UpdateItemReceiptCustomFields(body);
            
        }
        
    }

}