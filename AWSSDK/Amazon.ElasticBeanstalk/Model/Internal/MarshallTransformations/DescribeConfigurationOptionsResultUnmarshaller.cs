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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeConfigurationOptionsResult Unmarshaller
     /// </summary>
    internal class DescribeConfigurationOptionsResultUnmarshaller : IUnmarshaller<DescribeConfigurationOptionsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeConfigurationOptionsResult, JsonUnmarshallerContext> 
    {
        public DescribeConfigurationOptionsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeConfigurationOptionsResult describeConfigurationOptionsResult = new DescribeConfigurationOptionsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        describeConfigurationOptionsResult.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Options/member", targetDepth))
                    {
                        describeConfigurationOptionsResult.Options.Add(ConfigurationOptionDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeConfigurationOptionsResult;
                }
            }
                        


            return describeConfigurationOptionsResult;
        }

        public DescribeConfigurationOptionsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeConfigurationOptionsResultUnmarshaller instance;

        public static DescribeConfigurationOptionsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeConfigurationOptionsResultUnmarshaller();

            return instance;
        }
    }
}
    
