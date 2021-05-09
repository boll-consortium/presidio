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
    ///  Class for testing AnonymizerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnonymizerApiTests : IDisposable
    {
        private AnonymizerApi instance;

        public AnonymizerApiTests()
        {
            instance = new AnonymizerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnonymizerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AnonymizerApi
            //Assert.IsType<AnonymizerApi>(instance);
        }

        /// <summary>
        /// Test AnonymizePost
        /// </summary>
        [Fact]
        public void AnonymizePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AnonymizeRequest anonymizeRequest = null;
            //var response = instance.AnonymizePost(anonymizeRequest);
            //Assert.IsType<AnonymizeResponse>(response);
        }

        /// <summary>
        /// Test AnonymizersGet
        /// </summary>
        [Fact]
        public void AnonymizersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AnonymizersGet();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test DeanonymizersGet
        /// </summary>
        [Fact]
        public void DeanonymizersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeanonymizersGet();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test HealthGet
        /// </summary>
        [Fact]
        public void HealthGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HealthGet();
            //Assert.IsType<string>(response);
        }
    }
}
