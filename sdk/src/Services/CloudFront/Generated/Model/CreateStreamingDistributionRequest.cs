/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudfront-2016-01-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamingDistribution operation.
    /// Create a new streaming distribution.
    /// </summary>
    public partial class CreateStreamingDistributionRequest : AmazonCloudFrontRequest
    {
        private StreamingDistributionConfig _streamingDistributionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateStreamingDistributionRequest() { }

        /// <summary>
        /// Instantiates CreateStreamingDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="streamingDistributionConfig">The streaming distribution's configuration information.</param>
        public CreateStreamingDistributionRequest(StreamingDistributionConfig streamingDistributionConfig)
        {
            _streamingDistributionConfig = streamingDistributionConfig;
        }

        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. The streaming distribution's
        /// configuration information.
        /// </summary>
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this._streamingDistributionConfig; }
            set { this._streamingDistributionConfig = value; }
        }

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this._streamingDistributionConfig != null;
        }

    }
}