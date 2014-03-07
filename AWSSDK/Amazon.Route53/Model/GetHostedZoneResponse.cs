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

using Amazon.Runtime;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Returns information about the  GetHostedZoneResult response and response metadata.
    /// </summary>
    public class GetHostedZoneResponse : AmazonWebServiceResponse
    {
        private GetHostedZoneResult getHostedZoneResult;

        /// <summary>
        /// Gets and sets the GetHostedZoneResult property.
        /// A complex type containing information about the specified hosted zone.
        /// </summary>
        public GetHostedZoneResult GetHostedZoneResult
        {
            get
            {
                if(this.getHostedZoneResult == null)
                {
                    this.getHostedZoneResult = new GetHostedZoneResult();
                }

                return this.getHostedZoneResult;
            }
            set { this.getHostedZoneResult = value; }
        }
    }
}
    
