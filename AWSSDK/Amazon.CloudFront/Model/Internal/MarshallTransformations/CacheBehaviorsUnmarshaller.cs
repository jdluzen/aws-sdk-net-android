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
     ///   CacheBehaviors Unmarshaller
     /// </summary>
    internal class CacheBehaviorsUnmarshaller : IUnmarshaller<CacheBehaviors, XmlUnmarshallerContext>, IUnmarshaller<CacheBehaviors, JsonUnmarshallerContext> 
    {
        public CacheBehaviors Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheBehaviors cacheBehaviors = new CacheBehaviors();
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
                        cacheBehaviors.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Items/CacheBehavior", targetDepth))
                    {
                        cacheBehaviors.Items.Add(CacheBehaviorUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheBehaviors;
                }
            }
                        


            return cacheBehaviors;
        }

        public CacheBehaviors Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheBehaviorsUnmarshaller instance;

        public static CacheBehaviorsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheBehaviorsUnmarshaller();

            return instance;
        }
    }
}
    
