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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsers operation.
    /// Returns a list of all ActiveMQ users.
    /// </summary>
    public partial class ListUsersRequest : AmazonMQRequest
    {
        private string _brokerId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BrokerId. The unique ID that Amazon MQ generates for the
        /// broker.
        /// </summary>
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of ActiveMQ users that can
        /// be returned per page (20 by default). This value must be an integer from 5 to 100.
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
        /// Gets and sets the property NextToken. The token that specifies the next page of results
        /// Amazon MQ should return. To request the first page, leave nextToken empty.
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

    }
}