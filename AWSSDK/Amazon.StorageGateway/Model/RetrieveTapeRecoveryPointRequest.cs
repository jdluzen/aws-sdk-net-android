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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the RetrieveTapeRecoveryPoint operation.
    /// <para>Retrieves the recovery point for the specified virtual tape.</para> <para>A recovery point is a point in time view of a virtual tape
    /// at which all the data on the tape is consistent. If your gateway crashes, virtual tapes that have recovery points can be recovered to a new
    /// gateway.</para> <para><b>NOTE:</b>The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only. The virtual tape
    /// can be retrieved to only a gateway-VTL. There is no charge for retrieving recovery points.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.RetrieveTapeRecoveryPoint"/>
    public class RetrieveTapeRecoveryPointRequest : AmazonWebServiceRequest
    {
        private string tapeARN;
        private string gatewayARN;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the virtual tape for which you want to retrieve the recovery point.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TapeARN
        {
            get { return this.tapeARN; }
            set { this.tapeARN = value; }
        }

        /// <summary>
        /// Sets the TapeARN property
        /// </summary>
        /// <param name="tapeARN">The value to set for the TapeARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RetrieveTapeRecoveryPointRequest WithTapeARN(string tapeARN)
        {
            this.tapeARN = tapeARN;
            return this;
        }
            

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this.tapeARN != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RetrieveTapeRecoveryPointRequest WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
    }
}
    
