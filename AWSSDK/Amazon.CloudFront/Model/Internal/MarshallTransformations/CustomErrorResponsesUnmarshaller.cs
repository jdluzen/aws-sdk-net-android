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
     ///   CustomErrorResponses Unmarshaller
     /// </summary>
    internal class CustomErrorResponsesUnmarshaller : IUnmarshaller<CustomErrorResponses, XmlUnmarshallerContext>, IUnmarshaller<CustomErrorResponses, JsonUnmarshallerContext> 
    {
        public CustomErrorResponses Unmarshall(XmlUnmarshallerContext context) 
        {
            CustomErrorResponses customErrorResponses = new CustomErrorResponses();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        customErrorResponses.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Items/CustomErrorResponse", targetDepth))
                    {
                        customErrorResponses.Items.Add(CustomErrorResponseUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return customErrorResponses;
                }
            }
                        


            return customErrorResponses;
        }

        public CustomErrorResponses Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CustomErrorResponsesUnmarshaller instance;

        public static CustomErrorResponsesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CustomErrorResponsesUnmarshaller();

            return instance;
        }
    }
}
    
