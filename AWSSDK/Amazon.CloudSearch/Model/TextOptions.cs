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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Options that define a text field in the search index.</para>
    /// </summary>
    public partial class TextOptions
    {
        
        private string defaultValue;
        private bool? facetEnabled;
        private bool? resultEnabled;
        private string textProcessor;

        /// <summary>
        /// The default value for a text field. Optional.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TextOptions WithDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// Specifies whether facets are enabled for this field. Default: False.
        ///  
        /// </summary>
        public bool FacetEnabled
        {
            get { return this.facetEnabled ?? default(bool); }
            set { this.facetEnabled = value; }
        }

        /// <summary>
        /// Sets the FacetEnabled property
        /// </summary>
        /// <param name="facetEnabled">The value to set for the FacetEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TextOptions WithFacetEnabled(bool facetEnabled)
        {
            this.facetEnabled = facetEnabled;
            return this;
        }
            

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this.facetEnabled.HasValue;
        }

        /// <summary>
        /// Specifies whether values of this field can be returned in search results and used for ranking. Default: False.
        ///  
        /// </summary>
        public bool ResultEnabled
        {
            get { return this.resultEnabled ?? default(bool); }
            set { this.resultEnabled = value; }
        }

        /// <summary>
        /// Sets the ResultEnabled property
        /// </summary>
        /// <param name="resultEnabled">The value to set for the ResultEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TextOptions WithResultEnabled(bool resultEnabled)
        {
            this.resultEnabled = resultEnabled;
            return this;
        }
            

        // Check to see if ResultEnabled property is set
        internal bool IsSetResultEnabled()
        {
            return this.resultEnabled.HasValue;
        }

        /// <summary>
        /// The text processor to apply to this field. Optional. Possible values: <ul> <li><c>cs_text_no_stemming</c>: turns off stemming for the
        /// field.</li> </ul> Default: none
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TextProcessor
        {
            get { return this.textProcessor; }
            set { this.textProcessor = value; }
        }

        /// <summary>
        /// Sets the TextProcessor property
        /// </summary>
        /// <param name="textProcessor">The value to set for the TextProcessor property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TextOptions WithTextProcessor(string textProcessor)
        {
            this.textProcessor = textProcessor;
            return this;
        }
            

        // Check to see if TextProcessor property is set
        internal bool IsSetTextProcessor()
        {
            return this.textProcessor != null;
        }
    }
}
