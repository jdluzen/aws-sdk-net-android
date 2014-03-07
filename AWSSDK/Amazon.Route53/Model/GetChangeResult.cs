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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains the <c>ChangeInfo</c> element.</para>
    /// </summary>
    public partial class GetChangeResult
    {
        
        private ChangeInfo changeInfo;

        /// <summary>
        /// A complex type that contains information about the specified change batch, including the change batch ID, the status of the change, and the
        /// date and time of the request.
        ///  
        /// </summary>
        public ChangeInfo ChangeInfo
        {
            get { return this.changeInfo; }
            set { this.changeInfo = value; }
        }

        /// <summary>
        /// Sets the ChangeInfo property
        /// </summary>
        /// <param name="changeInfo">The value to set for the ChangeInfo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetChangeResult WithChangeInfo(ChangeInfo changeInfo)
        {
            this.changeInfo = changeInfo;
            return this;
        }
            

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this.changeInfo != null;
        }
    }
}
