/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;
using Microsoft.Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Test.Model
{
    /// <summary>
    ///  Class for testing AnonymizeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AnonymizeRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AnonymizeRequest
        //private AnonymizeRequest instance;

        public AnonymizeRequestTests()
        {
            // TODO uncomment below to create an instance of AnonymizeRequest
            //instance = new AnonymizeRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnonymizeRequest
        /// </summary>
        [Fact]
        public void AnonymizeRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AnonymizeRequest
            //Assert.IsType<AnonymizeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }
        /// <summary>
        /// Test the property 'Anonymizers'
        /// </summary>
        [Fact]
        public void AnonymizersTest()
        {
            // TODO unit test for the property 'Anonymizers'
        }
        /// <summary>
        /// Test the property 'AnalyzerResults'
        /// </summary>
        [Fact]
        public void AnalyzerResultsTest()
        {
            // TODO unit test for the property 'AnalyzerResults'
        }

    }

}
