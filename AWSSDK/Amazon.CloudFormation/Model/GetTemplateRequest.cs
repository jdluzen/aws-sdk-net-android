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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemplate operation.
    /// <para>Returns the template body for a specified stack. You can get the template for running or deleted stacks.</para> <para>For deleted
    /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted.</para> <para><b>NOTE:</b> If the template does
    /// not exist, a ValidationError is returned. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.GetTemplate"/>
    public class GetTemplateRequest : AmazonWebServiceRequest
    {
        private string stackName;

        /// <summary>
        /// The name or the unique identifier associated with the stack, which are not always interchangeable: <ul> <li>Running stacks: You can specify
        /// either the stack's name or its unique stack ID.</li> <li>Deleted stacks: You must specify the unique stack ID.</li> </ul> Default: There is
        /// no default value.
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        /// <summary>
        /// Sets the StackName property
        /// </summary>
        /// <param name="stackName">The value to set for the StackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTemplateRequest WithStackName(string stackName)
        {
            this.stackName = stackName;
            return this;
        }
            

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }
    }
}
    
