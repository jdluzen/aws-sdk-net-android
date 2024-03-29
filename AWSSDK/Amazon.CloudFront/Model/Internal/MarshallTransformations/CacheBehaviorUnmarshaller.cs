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
     ///   CacheBehavior Unmarshaller
     /// </summary>
    internal class CacheBehaviorUnmarshaller : IUnmarshaller<CacheBehavior, XmlUnmarshallerContext>, IUnmarshaller<CacheBehavior, JsonUnmarshallerContext> 
    {
        public CacheBehavior Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheBehavior cacheBehavior = new CacheBehavior();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("PathPattern", targetDepth))
                    {
                        cacheBehavior.PathPattern = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TargetOriginId", targetDepth))
                    {
                        cacheBehavior.TargetOriginId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ForwardedValues", targetDepth))
                    {
                        cacheBehavior.ForwardedValues = ForwardedValuesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TrustedSigners", targetDepth))
                    {
                        cacheBehavior.TrustedSigners = TrustedSignersUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ViewerProtocolPolicy", targetDepth))
                    {
                        cacheBehavior.ViewerProtocolPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinTTL", targetDepth))
                    {
                        cacheBehavior.MinTTL = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AllowedMethods", targetDepth))
                    {
                        cacheBehavior.AllowedMethods = AllowedMethodsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SmoothStreaming", targetDepth))
                    {
                        cacheBehavior.SmoothStreaming = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheBehavior;
                }
            }
                        


            return cacheBehavior;
        }

        public CacheBehavior Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheBehaviorUnmarshaller instance;

        public static CacheBehaviorUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheBehaviorUnmarshaller();

            return instance;
        }
    }
}
    
