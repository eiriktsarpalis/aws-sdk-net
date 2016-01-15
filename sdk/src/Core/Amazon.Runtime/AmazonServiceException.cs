﻿/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Globalization;
using System.Net;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// A base exception for some Amazon Web Services.
    /// <para>
    /// Most exceptions thrown to client code will be service-specific exceptions, though some services
    /// may throw this exception if there is a problem which is caught in the core client code.
    /// </para>
    /// </summary>
    public class AmazonServiceException : Exception
    {
        private ErrorType errorType;
        private string errorCode;
        private string requestId;
        private HttpStatusCode statusCode;

        public AmazonServiceException()
            : base()
        {
        }

        public AmazonServiceException(string message)
            : base(message)
        {
        }

        public AmazonServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AmazonServiceException(string message, Exception innerException, HttpStatusCode statusCode)
            : base(message, innerException)
        {
            this.statusCode = statusCode;
        }

        public AmazonServiceException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public AmazonServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message ??
                BuildGenericErrorMessage(errorCode, statusCode))
        {
            this.errorCode = errorCode;
            this.errorType = errorType;
            this.requestId = requestId;
            this.statusCode = statusCode;
        }

        public AmazonServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message ??
                BuildGenericErrorMessage(errorCode, statusCode), 
                innerException)
        {
            this.errorCode = errorCode;
            this.errorType = errorType;
            this.requestId = requestId;
            this.statusCode = statusCode;
        }

        public AmazonServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.errorCode = info.GetString("ErrorCode");
            this.errorType = (ErrorType) info.GetValue("ErrorType", typeof(ErrorType));
            this.requestId = info.GetString("RequestId");
            this.statusCode = (HttpStatusCode) info.GetValue("StatusCode", typeof(HttpStatusCode));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ErrorCode", this.errorCode);
            info.AddValue("ErrorType", this.ErrorType);
            info.AddValue("RequestId", this.RequestId);
            info.AddValue("StatusCode", this.statusCode);
        }

        static string BuildGenericErrorMessage(string errorCode, HttpStatusCode statusCode)
        {
            return string.Format(CultureInfo.InvariantCulture,  
                "Error making request with Error Code {0} and Http Status Code {1}. No further error information was returned by the service.", errorCode, statusCode);
        }

        /// <summary>
        /// Whether the error was attributable to <c>Sender</c> or <c>Reciever</c>.
        /// </summary>
        public ErrorType ErrorType
        {
            get { return this.errorType; }
            set { this.errorType = value; }
        }

        /// <summary>
        /// The error code returned by the service
        /// </summary>
        public string ErrorCode
        {
            get { return this.errorCode; }
            set { this.errorCode = value; }
        }

        /// <summary>
        /// The id of the request which generated the exception.
        /// </summary>
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        /// <summary>
        /// The HTTP status code from the service response
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
            set { this.statusCode = value; }
        }
    }
}
