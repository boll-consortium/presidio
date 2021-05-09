/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Microsoft.Presidio.Client;
using Microsoft.Presidio.Api;
// uncomment below to import models
//using Microsoft.Presidio.Model;

namespace Microsoft.Presidio.Test.Api
{
    /// <summary>
    ///  Class for testing DeanonymizeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeanonymizeApiTests : IDisposable
    {
        private DeanonymizeApi instance;

        public DeanonymizeApiTests()
        {
            instance = new DeanonymizeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeanonymizeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DeanonymizeApi
            //Assert.IsType<DeanonymizeApi>(instance);
        }

        /// <summary>
        /// Test DeanonymizePost
        /// </summary>
        [Fact]
        public void DeanonymizePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeanonymizeRequest deanonymizeRequest = null;
            //var response = instance.DeanonymizePost(deanonymizeRequest);
            //Assert.IsType<DeanonymizeResponse>(response);
        }
    }
}
