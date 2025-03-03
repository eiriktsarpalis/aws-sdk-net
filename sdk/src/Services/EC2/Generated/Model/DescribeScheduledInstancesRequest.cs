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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScheduledInstances operation.
    /// Describes one or more of your Scheduled Instances.
    /// </summary>
    public partial class DescribeScheduledInstancesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _scheduledInstanceIds = new List<string>();
        private SlotStartTimeRangeRequest _slotStartTimeRange;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>availability-zone</code> - The Availability Zone (for example, <code>us-west-2a</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-type</code> - The instance type (for example, <code>c4.large</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>network-platform</code> - The network platform (<code>EC2-Classic</code> or
        /// <code>EC2-VPC</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>platform</code> - The platform (<code>Linux/UNIX</code> or <code>Windows</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>NextToken</code> value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledInstanceIds. 
        /// <para>
        /// One or more Scheduled Instance IDs.
        /// </para>
        /// </summary>
        public List<string> ScheduledInstanceIds
        {
            get { return this._scheduledInstanceIds; }
            set { this._scheduledInstanceIds = value; }
        }

        // Check to see if ScheduledInstanceIds property is set
        internal bool IsSetScheduledInstanceIds()
        {
            return this._scheduledInstanceIds != null && this._scheduledInstanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SlotStartTimeRange. 
        /// <para>
        /// The time period for the first schedule to start.
        /// </para>
        /// </summary>
        public SlotStartTimeRangeRequest SlotStartTimeRange
        {
            get { return this._slotStartTimeRange; }
            set { this._slotStartTimeRange = value; }
        }

        // Check to see if SlotStartTimeRange property is set
        internal bool IsSetSlotStartTimeRange()
        {
            return this._slotStartTimeRange != null;
        }

    }
}