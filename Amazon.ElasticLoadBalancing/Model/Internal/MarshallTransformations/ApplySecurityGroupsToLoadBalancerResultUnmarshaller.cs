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
     ///   ApplySecurityGroupsToLoadBalancerResult Unmarshaller
     /// </summary>
    internal class ApplySecurityGroupsToLoadBalancerResultUnmarshaller : IUnmarshaller<ApplySecurityGroupsToLoadBalancerResult, XmlUnmarshallerContext> 
    {
        public ApplySecurityGroupsToLoadBalancerResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ApplySecurityGroupsToLoadBalancerResult applySecurityGroupsToLoadBalancerResult = new ApplySecurityGroupsToLoadBalancerResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SecurityGroups/member", targetDepth))
                    {
                        applySecurityGroupsToLoadBalancerResult.SecurityGroups.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return applySecurityGroupsToLoadBalancerResult;
                }
            }
                        


            return applySecurityGroupsToLoadBalancerResult;
        }

        private static ApplySecurityGroupsToLoadBalancerResultUnmarshaller instance;

        public static ApplySecurityGroupsToLoadBalancerResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ApplySecurityGroupsToLoadBalancerResultUnmarshaller();

            return instance;
        }
    }
}
    
