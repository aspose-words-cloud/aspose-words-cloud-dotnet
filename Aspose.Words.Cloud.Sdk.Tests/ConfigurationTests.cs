// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConfigurationTests.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// This is a test class for Configuration class
    /// </summary>
    [TestFixture]
    public class ConfigurationTests
    {
        /// <summary>
        /// Check if WordsApi throws an exception for wrong base URL parameter
        /// </summary>
        [Test]
        public void TestWordsApiBaseUrlChecks()
        {
            var nonEmptyString = "non empty sting";

            // parameterValue is a invalid value for both appSID and appKey
            Assert.Throws<ArgumentException>(() => new Configuration
            {
                AppKey = nonEmptyString,
                AppSid = nonEmptyString,
                ApiBaseUrl = nonEmptyString
            });
        }

        /// <summary>
        /// Check if WordsApi uses default base URL if configuration doesn't have it
        /// </summary>
        [Test]
        public void TestForConfigurationWithDefaultBaseUrl()
        {
            var nonEmptyString = "non empty sting";

            var config = new Configuration
            {
                AppKey = nonEmptyString,
                AppSid = nonEmptyString,
                ApiBaseUrl = null
            };

            Assert.NotNull(config.ApiBaseUrl);
        }
    }
}
