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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Returns information about the  DecodeAuthorizationMessageResult response and response metadata.
    /// </summary>
    public class DecodeAuthorizationMessageResponse : AmazonWebServiceResponse
    {
        private DecodeAuthorizationMessageResult decodeAuthorizationMessageResult;

        /// <summary>
        /// Gets and sets the DecodeAuthorizationMessageResult property.
        /// A document that contains additional information about the authorization status of a request from an encoded message that is returned in
        /// response to an AWS request.
        /// </summary>
        public DecodeAuthorizationMessageResult DecodeAuthorizationMessageResult
        {
            get
            {
                if(this.decodeAuthorizationMessageResult == null)
                {
                    this.decodeAuthorizationMessageResult = new DecodeAuthorizationMessageResult();
                }

                return this.decodeAuthorizationMessageResult;
            }
            set { this.decodeAuthorizationMessageResult = value; }
        }
    }
}
    
