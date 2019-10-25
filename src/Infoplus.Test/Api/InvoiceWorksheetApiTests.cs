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
    ///  Class for testing InvoiceWorksheetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoiceWorksheetApiTests
    {
        private InvoiceWorksheetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceWorksheetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceWorksheetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceWorksheetApi
            //Assert.IsInstanceOfType(typeof(InvoiceWorksheetApi), instance, "instance is a InvoiceWorksheetApi");
        }

        
        /// <summary>
        /// Test AddInvoiceWorksheet
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceWorksheet body = null;
            //var response = instance.AddInvoiceWorksheet(body);
            //Assert.IsInstanceOf<InvoiceWorksheet> (response, "response is InvoiceWorksheet");
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetAudit
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //string invoiceWorksheetAudit = null;
            //instance.AddInvoiceWorksheetAudit(invoiceWorksheetId, invoiceWorksheetAudit);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetFile
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //string fileName = null;
            //instance.AddInvoiceWorksheetFile(invoiceWorksheetId, fileName);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetTag
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //string invoiceWorksheetTag = null;
            //instance.AddInvoiceWorksheetTag(invoiceWorksheetId, invoiceWorksheetTag);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheet
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //instance.DeleteInvoiceWorksheet(invoiceWorksheetId);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetTag
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //string invoiceWorksheetTag = null;
            //instance.DeleteInvoiceWorksheetTag(invoiceWorksheetId, invoiceWorksheetTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateInvoiceWorksheetById
        /// </summary>
        [Test]
        public void GetDuplicateInvoiceWorksheetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //var response = instance.GetDuplicateInvoiceWorksheetById(invoiceWorksheetId);
            //Assert.IsInstanceOf<InvoiceWorksheet> (response, "response is InvoiceWorksheet");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetByFilter
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetInvoiceWorksheetByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<InvoiceWorksheet>> (response, "response is List<InvoiceWorksheet>");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetById
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //var response = instance.GetInvoiceWorksheetById(invoiceWorksheetId);
            //Assert.IsInstanceOf<InvoiceWorksheet> (response, "response is InvoiceWorksheet");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetTags
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetId = null;
            //instance.GetInvoiceWorksheetTags(invoiceWorksheetId);
            
        }
        
        /// <summary>
        /// Test UpdateInvoiceWorksheet
        /// </summary>
        [Test]
        public void UpdateInvoiceWorksheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceWorksheet body = null;
            //instance.UpdateInvoiceWorksheet(body);
            
        }
        
    }

}