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
    ///  Class for testing ReceivingProcessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReceivingProcessApiTests
    {
        private ReceivingProcessApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReceivingProcessApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReceivingProcessApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReceivingProcessApi
            //Assert.IsInstanceOfType(typeof(ReceivingProcessApi), instance, "instance is a ReceivingProcessApi");
        }

        
        /// <summary>
        /// Test AddReceivingProcessAudit
        /// </summary>
        [Test]
        public void AddReceivingProcessAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //string receivingProcessAudit = null;
            //instance.AddReceivingProcessAudit(receivingProcessId, receivingProcessAudit);
            
        }
        
        /// <summary>
        /// Test AddReceivingProcessFile
        /// </summary>
        [Test]
        public void AddReceivingProcessFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //string fileName = null;
            //instance.AddReceivingProcessFile(receivingProcessId, fileName);
            
        }
        
        /// <summary>
        /// Test AddReceivingProcessFileByURL
        /// </summary>
        [Test]
        public void AddReceivingProcessFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? receivingProcessId = null;
            //instance.AddReceivingProcessFileByURL(body, receivingProcessId);
            
        }
        
        /// <summary>
        /// Test AddReceivingProcessTag
        /// </summary>
        [Test]
        public void AddReceivingProcessTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //string receivingProcessTag = null;
            //instance.AddReceivingProcessTag(receivingProcessId, receivingProcessTag);
            
        }
        
        /// <summary>
        /// Test DeleteReceivingProcessFile
        /// </summary>
        [Test]
        public void DeleteReceivingProcessFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //int? fileId = null;
            //instance.DeleteReceivingProcessFile(receivingProcessId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteReceivingProcessTag
        /// </summary>
        [Test]
        public void DeleteReceivingProcessTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //string receivingProcessTag = null;
            //instance.DeleteReceivingProcessTag(receivingProcessId, receivingProcessTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateReceivingProcessById
        /// </summary>
        [Test]
        public void GetDuplicateReceivingProcessByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //var response = instance.GetDuplicateReceivingProcessById(receivingProcessId);
            //Assert.IsInstanceOf<ReceivingProcess> (response, "response is ReceivingProcess");
        }
        
        /// <summary>
        /// Test GetReceivingProcessByFilter
        /// </summary>
        [Test]
        public void GetReceivingProcessByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetReceivingProcessByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ReceivingProcess>> (response, "response is List<ReceivingProcess>");
        }
        
        /// <summary>
        /// Test GetReceivingProcessById
        /// </summary>
        [Test]
        public void GetReceivingProcessByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //var response = instance.GetReceivingProcessById(receivingProcessId);
            //Assert.IsInstanceOf<ReceivingProcess> (response, "response is ReceivingProcess");
        }
        
        /// <summary>
        /// Test GetReceivingProcessFiles
        /// </summary>
        [Test]
        public void GetReceivingProcessFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //instance.GetReceivingProcessFiles(receivingProcessId);
            
        }
        
        /// <summary>
        /// Test GetReceivingProcessTags
        /// </summary>
        [Test]
        public void GetReceivingProcessTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receivingProcessId = null;
            //instance.GetReceivingProcessTags(receivingProcessId);
            
        }
        
        /// <summary>
        /// Test UpdateReceivingProcessCustomFields
        /// </summary>
        [Test]
        public void UpdateReceivingProcessCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReceivingProcess body = null;
            //instance.UpdateReceivingProcessCustomFields(body);
            
        }
        
    }

}
