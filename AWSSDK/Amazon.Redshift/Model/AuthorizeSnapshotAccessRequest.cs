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
    /// Container for the parameters to the AuthorizeSnapshotAccess operation.
    /// <para> Authorizes the specified AWS customer account to restore the specified snapshot. </para> <para> For more information about working
    /// with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift Snapshots</a>
    /// in the <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.AuthorizeSnapshotAccess"/>
    public class AuthorizeSnapshotAccessRequest : AmazonWebServiceRequest
    {
        private string snapshotIdentifier;
        private string snapshotClusterIdentifier;
        private string accountWithRestoreAccess;

        /// <summary>
        /// The identifier of the snapshot the account is authorized to restore.
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the SnapshotIdentifier property
        /// </summary>
        /// <param name="snapshotIdentifier">The value to set for the SnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSnapshotAccessRequest WithSnapshotIdentifier(string snapshotIdentifier)
        {
            this.snapshotIdentifier = snapshotIdentifier;
            return this;
        }
            

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this.snapshotIdentifier != null;
        }

        /// <summary>
        /// The identifier of the cluster the snapshot was created from. This parameter is required if your IAM user has a policy containing a snapshot
        /// resource element that specifies anything other than * for the cluster name.
        ///  
        /// </summary>
        public string SnapshotClusterIdentifier
        {
            get { return this.snapshotClusterIdentifier; }
            set { this.snapshotClusterIdentifier = value; }
        }

        /// <summary>
        /// Sets the SnapshotClusterIdentifier property
        /// </summary>
        /// <param name="snapshotClusterIdentifier">The value to set for the SnapshotClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSnapshotAccessRequest WithSnapshotClusterIdentifier(string snapshotClusterIdentifier)
        {
            this.snapshotClusterIdentifier = snapshotClusterIdentifier;
            return this;
        }
            

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this.snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// The identifier of the AWS customer account authorized to restore the specified snapshot.
        ///  
        /// </summary>
        public string AccountWithRestoreAccess
        {
            get { return this.accountWithRestoreAccess; }
            set { this.accountWithRestoreAccess = value; }
        }

        /// <summary>
        /// Sets the AccountWithRestoreAccess property
        /// </summary>
        /// <param name="accountWithRestoreAccess">The value to set for the AccountWithRestoreAccess property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSnapshotAccessRequest WithAccountWithRestoreAccess(string accountWithRestoreAccess)
        {
            this.accountWithRestoreAccess = accountWithRestoreAccess;
            return this;
        }
            

        // Check to see if AccountWithRestoreAccess property is set
        internal bool IsSetAccountWithRestoreAccess()
        {
            return this.accountWithRestoreAccess != null;
        }
    }
}
    
