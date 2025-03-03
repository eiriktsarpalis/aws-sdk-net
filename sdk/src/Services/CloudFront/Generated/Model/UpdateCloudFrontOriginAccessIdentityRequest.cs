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
    /// Container for the parameters to the UpdateCloudFrontOriginAccessIdentity operation.
    /// Update an origin access identity.
    /// </summary>
    public partial class UpdateCloudFrontOriginAccessIdentityRequest : AmazonCloudFrontRequest
    {
        private CloudFrontOriginAccessIdentityConfig _cloudFrontOriginAccessIdentityConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateCloudFrontOriginAccessIdentityRequest() { }

        /// <summary>
        /// Instantiates UpdateCloudFrontOriginAccessIdentityRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The identity's id.</param>
        /// <param name="ifMatch">The value of the ETag header you received when retrieving the identity's configuration. For example: E2QWRUHAPOMQZL.</param>
        /// <param name="cloudFrontOriginAccessIdentityConfig">The identity's configuration information.</param>
        public UpdateCloudFrontOriginAccessIdentityRequest(string id, string ifMatch, CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            _id = id;
            _ifMatch = ifMatch;
            _cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
        }

        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentityConfig. The identity's configuration
        /// information.
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this._cloudFrontOriginAccessIdentityConfig; }
            set { this._cloudFrontOriginAccessIdentityConfig = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this._cloudFrontOriginAccessIdentityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The identity's id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. The value of the ETag header you received when
        /// retrieving the identity's configuration. For example: E2QWRUHAPOMQZL.
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}