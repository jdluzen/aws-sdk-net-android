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
    /// <para>Represents the output of a <i>DescribeCacheClusters</i> operation.</para>
    /// </summary>
    public partial class DescribeCacheClustersResult
    {
        
        private string marker;
        private List<CacheCluster> cacheClusters = new List<CacheCluster>();

        /// <summary>
        /// Provides an identifier to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheClustersResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of cache clusters. Each item in the list contains detailed information about one cache cluster.
        ///  
        /// </summary>
        public List<CacheCluster> CacheClusters
        {
            get { return this.cacheClusters; }
            set { this.cacheClusters = value; }
        }
        /// <summary>
        /// Adds elements to the CacheClusters collection
        /// </summary>
        /// <param name="cacheClusters">The values to add to the CacheClusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheClustersResult WithCacheClusters(params CacheCluster[] cacheClusters)
        {
            foreach (CacheCluster element in cacheClusters)
            {
                this.cacheClusters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheClusters collection
        /// </summary>
        /// <param name="cacheClusters">The values to add to the CacheClusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheClustersResult WithCacheClusters(IEnumerable<CacheCluster> cacheClusters)
        {
            foreach (CacheCluster element in cacheClusters)
            {
                this.cacheClusters.Add(element);
            }

            return this;
        }

        // Check to see if CacheClusters property is set
        internal bool IsSetCacheClusters()
        {
            return this.cacheClusters.Count > 0;
        }
    }
}
