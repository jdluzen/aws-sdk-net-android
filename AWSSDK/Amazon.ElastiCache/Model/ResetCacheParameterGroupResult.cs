/*
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of one of the following operations:</para>
    /// <ul>
    /// <li> <i>ModifyCacheParameterGroup</i> </li>
    /// <li> <i>ResetCacheParameterGroup</i> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class ResetCacheParameterGroupResult
    {
        
        private string cacheParameterGroupName;

        /// <summary>
        /// The name of the cache parameter group.
        ///  
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this.cacheParameterGroupName; }
            set { this.cacheParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheParameterGroupName property
        /// </summary>
        /// <param name="cacheParameterGroupName">The value to set for the CacheParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResetCacheParameterGroupResult WithCacheParameterGroupName(string cacheParameterGroupName)
        {
            this.cacheParameterGroupName = cacheParameterGroupName;
            return this;
        }
            

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this.cacheParameterGroupName != null;
        }
    }
}
