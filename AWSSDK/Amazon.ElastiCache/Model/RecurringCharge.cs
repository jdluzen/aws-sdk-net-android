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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Contains the specific price and frequency of a recurring charges for a reserved cache node, or for a reserved cache node
    /// offering.</para>
    /// </summary>
    public partial class RecurringCharge
    {
        
        private double? recurringChargeAmount;
        private string recurringChargeFrequency;

        /// <summary>
        /// The monetary amount of the recurring charge.
        ///  
        /// </summary>
        public double RecurringChargeAmount
        {
            get { return this.recurringChargeAmount ?? default(double); }
            set { this.recurringChargeAmount = value; }
        }

        /// <summary>
        /// Sets the RecurringChargeAmount property
        /// </summary>
        /// <param name="recurringChargeAmount">The value to set for the RecurringChargeAmount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RecurringCharge WithRecurringChargeAmount(double recurringChargeAmount)
        {
            this.recurringChargeAmount = recurringChargeAmount;
            return this;
        }
            

        // Check to see if RecurringChargeAmount property is set
        internal bool IsSetRecurringChargeAmount()
        {
            return this.recurringChargeAmount.HasValue;
        }

        /// <summary>
        /// The frequency of the recurring charge.
        ///  
        /// </summary>
        public string RecurringChargeFrequency
        {
            get { return this.recurringChargeFrequency; }
            set { this.recurringChargeFrequency = value; }
        }

        /// <summary>
        /// Sets the RecurringChargeFrequency property
        /// </summary>
        /// <param name="recurringChargeFrequency">The value to set for the RecurringChargeFrequency property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RecurringCharge WithRecurringChargeFrequency(string recurringChargeFrequency)
        {
            this.recurringChargeFrequency = recurringChargeFrequency;
            return this;
        }
            

        // Check to see if RecurringChargeFrequency property is set
        internal bool IsSetRecurringChargeFrequency()
        {
            return this.recurringChargeFrequency != null;
        }
    }
}
