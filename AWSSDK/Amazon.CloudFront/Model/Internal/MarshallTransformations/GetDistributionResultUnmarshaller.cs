/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   GetDistributionResult Unmarshaller
     /// </summary>
    internal class GetDistributionResultUnmarshaller : IUnmarshaller<GetDistributionResult, XmlUnmarshallerContext>, IUnmarshaller<GetDistributionResult, JsonUnmarshallerContext> 
    {
        public GetDistributionResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetDistributionResult getDistributionResult = new GetDistributionResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Distribution", targetDepth))
                    {
                        getDistributionResult.Distribution = DistributionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getDistributionResult;
                }
            }
            

            getDistributionResult.ETag = context.Headers["ETag"];           


            return getDistributionResult;
        }

        public GetDistributionResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetDistributionResultUnmarshaller instance;

        public static GetDistributionResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetDistributionResultUnmarshaller();

            return instance;
        }
    }
}
    
