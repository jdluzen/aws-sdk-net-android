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
using System.Collections.Generic;

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeHsmConfigurationsResult Unmarshaller
     /// </summary>
    internal class DescribeHsmConfigurationsResultUnmarshaller : IUnmarshaller<DescribeHsmConfigurationsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeHsmConfigurationsResult, JsonUnmarshallerContext> 
    {
        public DescribeHsmConfigurationsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeHsmConfigurationsResult describeHsmConfigurationsResult = new DescribeHsmConfigurationsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeHsmConfigurationsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HsmConfigurations/HsmConfiguration", targetDepth))
                    {
                        describeHsmConfigurationsResult.HsmConfigurations.Add(HsmConfigurationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeHsmConfigurationsResult;
                }
            }
                        


            return describeHsmConfigurationsResult;
        }

        public DescribeHsmConfigurationsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeHsmConfigurationsResultUnmarshaller instance;

        public static DescribeHsmConfigurationsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeHsmConfigurationsResultUnmarshaller();

            return instance;
        }
    }
}
    
