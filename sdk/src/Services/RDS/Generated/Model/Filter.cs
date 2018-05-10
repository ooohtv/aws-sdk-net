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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A filter name and value pair that is used to return a more specific list of results
    /// from a describe operation. Filters can be used to match a set of resources by specific
    /// criteria, such as IDs. The filters supported by a describe operation are documented
    /// with the describe operation.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, wildcards are not supported in filters.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following actions can be filtered:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeDBClusterBacktracks</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDBClusters</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDBInstances</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePendingMaintenanceActions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter. Filter names are case-sensitive.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// One or more filter values. Filter values are case-sensitive.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}