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
     ///   LoadBalancerDescription Unmarshaller
     /// </summary>
    internal class LoadBalancerDescriptionUnmarshaller : IUnmarshaller<LoadBalancerDescription, XmlUnmarshallerContext>, IUnmarshaller<LoadBalancerDescription, JsonUnmarshallerContext> 
    {
        public LoadBalancerDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            LoadBalancerDescription loadBalancerDescription = new LoadBalancerDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("LoadBalancerName", targetDepth))
                    {
                        loadBalancerDescription.LoadBalancerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Domain", targetDepth))
                    {
                        loadBalancerDescription.Domain = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Listeners/member", targetDepth))
                    {
                        loadBalancerDescription.Listeners.Add(ListenerUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return loadBalancerDescription;
                }
            }
                        


            return loadBalancerDescription;
        }

        public LoadBalancerDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LoadBalancerDescriptionUnmarshaller instance;

        public static LoadBalancerDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LoadBalancerDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
