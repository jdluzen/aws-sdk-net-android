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
     ///   InvalidationList Unmarshaller
     /// </summary>
    internal class InvalidationListUnmarshaller : IUnmarshaller<InvalidationList, XmlUnmarshallerContext>, IUnmarshaller<InvalidationList, JsonUnmarshallerContext> 
    {
        public InvalidationList Unmarshall(XmlUnmarshallerContext context) 
        {
            InvalidationList invalidationList = new InvalidationList();
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
                        invalidationList.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        invalidationList.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        invalidationList.MaxItems = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        invalidationList.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        invalidationList.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Items/InvalidationSummary", targetDepth))
                    {
                        invalidationList.Items.Add(InvalidationSummaryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return invalidationList;
                }
            }
                        


            return invalidationList;
        }

        public InvalidationList Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InvalidationListUnmarshaller instance;

        public static InvalidationListUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InvalidationListUnmarshaller();

            return instance;
        }
    }
}
    
