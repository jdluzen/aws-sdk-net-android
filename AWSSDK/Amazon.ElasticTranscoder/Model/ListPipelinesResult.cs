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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>A list of the pipelines associated with the current AWS account.</para>
    /// </summary>
    public partial class ListPipelinesResult
    {
        
        private List<Pipeline> pipelines = new List<Pipeline>();
        private string nextPageToken;

        /// <summary>
        /// An array of <c>Pipeline</c> objects.
        ///  
        /// </summary>
        public List<Pipeline> Pipelines
        {
            get { return this.pipelines; }
            set { this.pipelines = value; }
        }
        /// <summary>
        /// Adds elements to the Pipelines collection
        /// </summary>
        /// <param name="pipelines">The values to add to the Pipelines collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithPipelines(params Pipeline[] pipelines)
        {
            foreach (Pipeline element in pipelines)
            {
                this.pipelines.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Pipelines collection
        /// </summary>
        /// <param name="pipelines">The values to add to the Pipelines collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithPipelines(IEnumerable<Pipeline> pipelines)
        {
            foreach (Pipeline element in pipelines)
            {
                this.pipelines.Add(element);
            }

            return this;
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this.pipelines.Count > 0;
        }

        /// <summary>
        /// A value that you use to access the second and subsequent pages of results, if any. When the pipelines fit on one page or when you've reached
        /// the last page of results, the value of <c>NextPageToken</c> is <c>null</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
