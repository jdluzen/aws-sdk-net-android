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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApp operation.
    /// <para>Deletes a specified app.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
    public class DeleteAppRequest : AmazonWebServiceRequest
    {
        private string appId;

        /// <summary>
        /// The app ID.
        ///  
        /// </summary>
        public string AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }

        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAppRequest WithAppId(string appId)
        {
            this.appId = appId;
            return this;
        }
            

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this.appId != null;
        }
    }
}
    
