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
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EnableAvailabilityZonesForLoadBalancerResult Unmarshaller
     /// </summary>
    internal class EnableAvailabilityZonesForLoadBalancerResultUnmarshaller : IUnmarshaller<EnableAvailabilityZonesForLoadBalancerResult, XmlUnmarshallerContext>, IUnmarshaller<EnableAvailabilityZonesForLoadBalancerResult, JsonUnmarshallerContext> 
    {
        public EnableAvailabilityZonesForLoadBalancerResult Unmarshall(XmlUnmarshallerContext context) 
        {
            EnableAvailabilityZonesForLoadBalancerResult enableAvailabilityZonesForLoadBalancerResult = new EnableAvailabilityZonesForLoadBalancerResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        enableAvailabilityZonesForLoadBalancerResult.AvailabilityZones.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return enableAvailabilityZonesForLoadBalancerResult;
                }
            }
                        


            return enableAvailabilityZonesForLoadBalancerResult;
        }

        public EnableAvailabilityZonesForLoadBalancerResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EnableAvailabilityZonesForLoadBalancerResultUnmarshaller instance;

        public static EnableAvailabilityZonesForLoadBalancerResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EnableAvailabilityZonesForLoadBalancerResultUnmarshaller();

            return instance;
        }
    }
}
    
