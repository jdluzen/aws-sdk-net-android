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
    /// Container for the parameters to the CreateStreamingDistribution operation.
    /// <para> Create a new streaming distribution. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
    public class CreateStreamingDistributionRequest : AmazonWebServiceRequest
    {
        private StreamingDistributionConfig streamingDistributionConfig;

        /// <summary>
        /// The streaming distribution's configuration information.
        ///  
        /// </summary>
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this.streamingDistributionConfig; }
            set { this.streamingDistributionConfig = value; }
        }

        /// <summary>
        /// Sets the StreamingDistributionConfig property
        /// </summary>
        /// <param name="streamingDistributionConfig">The value to set for the StreamingDistributionConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStreamingDistributionRequest WithStreamingDistributionConfig(StreamingDistributionConfig streamingDistributionConfig)
        {
            this.streamingDistributionConfig = streamingDistributionConfig;
            return this;
        }
            

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this.streamingDistributionConfig != null;
        }
    }
}
    
