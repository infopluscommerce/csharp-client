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
    ///  Class for testing PackingDetailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PackingDetailApiTests
    {
        private PackingDetailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PackingDetailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PackingDetailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PackingDetailApi
            //Assert.IsInstanceOfType(typeof(PackingDetailApi), instance, "instance is a PackingDetailApi");
        }

        
        /// <summary>
        /// Test AddPackingDetailAudit
        /// </summary>
        [Test]
        public void AddPackingDetailAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //string packingDetailAudit = null;
            //instance.AddPackingDetailAudit(packingDetailId, packingDetailAudit);
            
        }
        
        /// <summary>
        /// Test AddPackingDetailFile
        /// </summary>
        [Test]
        public void AddPackingDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //string fileName = null;
            //instance.AddPackingDetailFile(packingDetailId, fileName);
            
        }
        
        /// <summary>
        /// Test AddPackingDetailFileByURL
        /// </summary>
        [Test]
        public void AddPackingDetailFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? packingDetailId = null;
            //instance.AddPackingDetailFileByURL(body, packingDetailId);
            
        }
        
        /// <summary>
        /// Test AddPackingDetailTag
        /// </summary>
        [Test]
        public void AddPackingDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //string packingDetailTag = null;
            //instance.AddPackingDetailTag(packingDetailId, packingDetailTag);
            
        }
        
        /// <summary>
        /// Test DeletePackingDetailFile
        /// </summary>
        [Test]
        public void DeletePackingDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //int? fileId = null;
            //instance.DeletePackingDetailFile(packingDetailId, fileId);
            
        }
        
        /// <summary>
        /// Test DeletePackingDetailTag
        /// </summary>
        [Test]
        public void DeletePackingDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //string packingDetailTag = null;
            //instance.DeletePackingDetailTag(packingDetailId, packingDetailTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicatePackingDetailById
        /// </summary>
        [Test]
        public void GetDuplicatePackingDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //var response = instance.GetDuplicatePackingDetailById(packingDetailId);
            //Assert.IsInstanceOf<PackingDetail> (response, "response is PackingDetail");
        }
        
        /// <summary>
        /// Test GetPackingDetailByFilter
        /// </summary>
        [Test]
        public void GetPackingDetailByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetPackingDetailByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<PackingDetail>> (response, "response is List<PackingDetail>");
        }
        
        /// <summary>
        /// Test GetPackingDetailById
        /// </summary>
        [Test]
        public void GetPackingDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //var response = instance.GetPackingDetailById(packingDetailId);
            //Assert.IsInstanceOf<PackingDetail> (response, "response is PackingDetail");
        }
        
        /// <summary>
        /// Test GetPackingDetailFiles
        /// </summary>
        [Test]
        public void GetPackingDetailFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //instance.GetPackingDetailFiles(packingDetailId);
            
        }
        
        /// <summary>
        /// Test GetPackingDetailTags
        /// </summary>
        [Test]
        public void GetPackingDetailTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packingDetailId = null;
            //instance.GetPackingDetailTags(packingDetailId);
            
        }
        
        /// <summary>
        /// Test UpdatePackingDetailCustomFields
        /// </summary>
        [Test]
        public void UpdatePackingDetailCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PackingDetail body = null;
            //instance.UpdatePackingDetailCustomFields(body);
            
        }
        
    }

}
