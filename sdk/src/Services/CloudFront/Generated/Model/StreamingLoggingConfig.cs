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
    /// A complex type that controls whether access logs are written for this streaming distribution.
    /// </summary>
    public partial class StreamingLoggingConfig
    {
        private string _bucket;
        private bool? _enabled;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Bucket. The Amazon S3 bucket to store the access logs in,
        /// for example, myawslogbucket.s3.amazonaws.com.
        /// </summary>
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. Specifies whether you want CloudFront to save
        /// access logs to an Amazon S3 bucket. If you do not want to enable logging when you
        /// create a streaming distribution or if you want to disable logging for an existing
        /// streaming distribution, specify false for Enabled, and specify empty Bucket and Prefix
        /// elements. If you specify false for Enabled but you specify values for Bucket and Prefix,
        /// the values are automatically deleted.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. An optional string that you want CloudFront to
        /// prefix to the access log filenames for this streaming distribution, for example, myprefix/.
        /// If you want to enable logging, but you do not want to specify a prefix, you still
        /// must include an empty Prefix element in the Logging element.
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}