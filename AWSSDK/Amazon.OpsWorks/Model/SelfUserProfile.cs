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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a user's SSH information.</para>
    /// </summary>
    public partial class SelfUserProfile
    {
        
        private string iamUserArn;
        private string name;
        private string sshUsername;
        private string sshPublicKey;

        /// <summary>
        /// The user's IAM ARN.
        ///  
        /// </summary>
        public string IamUserArn
        {
            get { return this.iamUserArn; }
            set { this.iamUserArn = value; }
        }

        /// <summary>
        /// Sets the IamUserArn property
        /// </summary>
        /// <param name="iamUserArn">The value to set for the IamUserArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelfUserProfile WithIamUserArn(string iamUserArn)
        {
            this.iamUserArn = iamUserArn;
            return this;
        }
            

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this.iamUserArn != null;
        }

        /// <summary>
        /// The user's name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelfUserProfile WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The user's SSH user name.
        ///  
        /// </summary>
        public string SshUsername
        {
            get { return this.sshUsername; }
            set { this.sshUsername = value; }
        }

        /// <summary>
        /// Sets the SshUsername property
        /// </summary>
        /// <param name="sshUsername">The value to set for the SshUsername property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelfUserProfile WithSshUsername(string sshUsername)
        {
            this.sshUsername = sshUsername;
            return this;
        }
            

        // Check to see if SshUsername property is set
        internal bool IsSetSshUsername()
        {
            return this.sshUsername != null;
        }

        /// <summary>
        /// The user's SSH public key.
        ///  
        /// </summary>
        public string SshPublicKey
        {
            get { return this.sshPublicKey; }
            set { this.sshPublicKey = value; }
        }

        /// <summary>
        /// Sets the SshPublicKey property
        /// </summary>
        /// <param name="sshPublicKey">The value to set for the SshPublicKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelfUserProfile WithSshPublicKey(string sshPublicKey)
        {
            this.sshPublicKey = sshPublicKey;
            return this;
        }
            

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this.sshPublicKey != null;
        }
    }
}
