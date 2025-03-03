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
    /// A customer origin.
    /// </summary>
    public partial class CustomOriginConfig
    {
        private int? _httpPort;
        private int? _httpsPort;
        private OriginProtocolPolicy _originProtocolPolicy;
        private OriginSslProtocols _originSslProtocols;

        /// <summary>
        /// Gets and sets the property HTTPPort. The HTTP port the custom origin listens on.
        /// </summary>
        public int HTTPPort
        {
            get { return this._httpPort.GetValueOrDefault(); }
            set { this._httpPort = value; }
        }

        // Check to see if HTTPPort property is set
        internal bool IsSetHTTPPort()
        {
            return this._httpPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HTTPSPort. The HTTPS port the custom origin listens on.
        /// </summary>
        public int HTTPSPort
        {
            get { return this._httpsPort.GetValueOrDefault(); }
            set { this._httpsPort = value; }
        }

        // Check to see if HTTPSPort property is set
        internal bool IsSetHTTPSPort()
        {
            return this._httpsPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginProtocolPolicy. The origin protocol policy to apply
        /// to your origin.
        /// </summary>
        public OriginProtocolPolicy OriginProtocolPolicy
        {
            get { return this._originProtocolPolicy; }
            set { this._originProtocolPolicy = value; }
        }

        // Check to see if OriginProtocolPolicy property is set
        internal bool IsSetOriginProtocolPolicy()
        {
            return this._originProtocolPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property OriginSslProtocols. The SSL/TLS protocols that you want
        /// CloudFront to use when communicating with your origin over HTTPS.
        /// </summary>
        public OriginSslProtocols OriginSslProtocols
        {
            get { return this._originSslProtocols; }
            set { this._originSslProtocols = value; }
        }

        // Check to see if OriginSslProtocols property is set
        internal bool IsSetOriginSslProtocols()
        {
            return this._originSslProtocols != null;
        }

    }
}