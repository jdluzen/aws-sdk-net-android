/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkflowExecution operation.
    /// <para> Returns information about the specified workflow execution including its type and some statistics. </para> <para><b>NOTE:</b> This
    /// operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and changes. </para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.DescribeWorkflowExecution"/>
    public class DescribeWorkflowExecutionRequest : AmazonWebServiceRequest
    {
        private string domain;
        private WorkflowExecution execution;

        /// <summary>
        /// The name of the domain containing the workflow execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        public DescribeWorkflowExecutionRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;       
        }

        /// <summary>
        /// The workflow execution to describe.
        ///  
        /// </summary>
        public WorkflowExecution Execution
        {
            get { return this.execution; }
            set { this.execution = value; }
        }

        /// <summary>
        /// Sets the Execution property
        /// </summary>
        /// <param name="execution">The value to set for the Execution property </param>
        /// <returns>this instance</returns>
        public DescribeWorkflowExecutionRequest WithExecution(WorkflowExecution execution)
        {
            this.execution = execution;
            return this;
        }
            

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this.execution != null;       
        }
    }
}
    
