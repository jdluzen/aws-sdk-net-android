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
     ///   LaunchConfiguration Unmarshaller
     /// </summary>
    internal class LaunchConfigurationUnmarshaller : IUnmarshaller<LaunchConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LaunchConfiguration, JsonUnmarshallerContext> 
    {
        public LaunchConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            LaunchConfiguration launchConfiguration = new LaunchConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Name", targetDepth))
                    {
                        launchConfiguration.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return launchConfiguration;
                }
            }
                        


            return launchConfiguration;
        }

        public LaunchConfiguration Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LaunchConfigurationUnmarshaller instance;

        public static LaunchConfigurationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LaunchConfigurationUnmarshaller();

            return instance;
        }
    }
}
    
