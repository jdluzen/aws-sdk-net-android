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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeHsmClientCertificatesResult
    {
        
        private string marker;
        private List<HsmClientCertificate> hsmClientCertificates = new List<HsmClientCertificate>();

        /// <summary>
        /// A marker at which to continue listing events in a new request. The response returns a marker if there are more events to list than returned
        /// in the response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmClientCertificatesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of the identifiers for one or more HSM client certificates used by Amazon Redshift clusters to store and retrieve database encryption
        /// keys in an HSM.
        ///  
        /// </summary>
        public List<HsmClientCertificate> HsmClientCertificates
        {
            get { return this.hsmClientCertificates; }
            set { this.hsmClientCertificates = value; }
        }
        /// <summary>
        /// Adds elements to the HsmClientCertificates collection
        /// </summary>
        /// <param name="hsmClientCertificates">The values to add to the HsmClientCertificates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmClientCertificatesResult WithHsmClientCertificates(params HsmClientCertificate[] hsmClientCertificates)
        {
            foreach (HsmClientCertificate element in hsmClientCertificates)
            {
                this.hsmClientCertificates.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the HsmClientCertificates collection
        /// </summary>
        /// <param name="hsmClientCertificates">The values to add to the HsmClientCertificates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmClientCertificatesResult WithHsmClientCertificates(IEnumerable<HsmClientCertificate> hsmClientCertificates)
        {
            foreach (HsmClientCertificate element in hsmClientCertificates)
            {
                this.hsmClientCertificates.Add(element);
            }

            return this;
        }

        // Check to see if HsmClientCertificates property is set
        internal bool IsSetHsmClientCertificates()
        {
            return this.hsmClientCertificates.Count > 0;
        }
    }
}
