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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Result message containing a list of environment descriptions.</para>
    /// </summary>
    public partial class DescribeEnvironmentsResult
    {
        
        private List<EnvironmentDescription> environments = new List<EnvironmentDescription>();

        /// <summary>
        /// Returns an <a>EnvironmentDescription</a> list.
        ///  
        /// </summary>
        public List<EnvironmentDescription> Environments
        {
            get { return this.environments; }
            set { this.environments = value; }
        }
        /// <summary>
        /// Adds elements to the Environments collection
        /// </summary>
        /// <param name="environments">The values to add to the Environments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsResult WithEnvironments(params EnvironmentDescription[] environments)
        {
            foreach (EnvironmentDescription element in environments)
            {
                this.environments.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Environments collection
        /// </summary>
        /// <param name="environments">The values to add to the Environments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsResult WithEnvironments(IEnumerable<EnvironmentDescription> environments)
        {
            foreach (EnvironmentDescription element in environments)
            {
                this.environments.Add(element);
            }

            return this;
        }

        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this.environments.Count > 0;
        }
    }
}
