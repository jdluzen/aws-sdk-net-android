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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListRolePoliciesResult Unmarshaller
     /// </summary>
    internal class ListRolePoliciesResultUnmarshaller : IUnmarshaller<ListRolePoliciesResult, XmlUnmarshallerContext>, IUnmarshaller<ListRolePoliciesResult, JsonUnmarshallerContext> 
    {
        public ListRolePoliciesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListRolePoliciesResult listRolePoliciesResult = new ListRolePoliciesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("PolicyNames/member", targetDepth))
                    {
                        listRolePoliciesResult.PolicyNames.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        listRolePoliciesResult.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        listRolePoliciesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listRolePoliciesResult;
                }
            }
                        


            return listRolePoliciesResult;
        }

        public ListRolePoliciesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListRolePoliciesResultUnmarshaller instance;

        public static ListRolePoliciesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListRolePoliciesResultUnmarshaller();

            return instance;
        }
    }
}
    
