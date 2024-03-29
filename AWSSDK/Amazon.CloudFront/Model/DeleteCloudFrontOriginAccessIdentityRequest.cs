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
    /// Container for the parameters to the DeleteCloudFrontOriginAccessIdentity operation.
    /// <para> Delete an origin access identity. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
    public class DeleteCloudFrontOriginAccessIdentityRequest : AmazonWebServiceRequest
    {
        private string id;
        private string ifMatch;

        /// <summary>
        /// The origin access identity's id.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteCloudFrontOriginAccessIdentityRequest WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The value of the ETag header you received from a previous GET or PUT request. For example: E2QWRUHAPOMQZL.
        ///  
        /// </summary>
        public string IfMatch
        {
            get { return this.ifMatch; }
            set { this.ifMatch = value; }
        }

        /// <summary>
        /// Sets the IfMatch property
        /// </summary>
        /// <param name="ifMatch">The value to set for the IfMatch property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteCloudFrontOriginAccessIdentityRequest WithIfMatch(string ifMatch)
        {
            this.ifMatch = ifMatch;
            return this;
        }
            

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this.ifMatch != null;
        }
    }
}
    
