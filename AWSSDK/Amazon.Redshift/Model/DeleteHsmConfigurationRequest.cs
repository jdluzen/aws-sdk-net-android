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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHsmConfiguration operation.
    /// <para>Deletes the specified Amazon Redshift HSM configuration.</para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DeleteHsmConfiguration"/>
    public class DeleteHsmConfigurationRequest : AmazonWebServiceRequest
    {
        private string hsmConfigurationIdentifier;

        /// <summary>
        /// The identifier of the Amazon Redshift HSM configuration to be deleted.
        ///  
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this.hsmConfigurationIdentifier; }
            set { this.hsmConfigurationIdentifier = value; }
        }

        /// <summary>
        /// Sets the HsmConfigurationIdentifier property
        /// </summary>
        /// <param name="hsmConfigurationIdentifier">The value to set for the HsmConfigurationIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteHsmConfigurationRequest WithHsmConfigurationIdentifier(string hsmConfigurationIdentifier)
        {
            this.hsmConfigurationIdentifier = hsmConfigurationIdentifier;
            return this;
        }
            

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this.hsmConfigurationIdentifier != null;
        }
    }
}
    
