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
     ///   GetRolePolicyResult Unmarshaller
     /// </summary>
    internal class GetRolePolicyResultUnmarshaller : IUnmarshaller<GetRolePolicyResult, XmlUnmarshallerContext>, IUnmarshaller<GetRolePolicyResult, JsonUnmarshallerContext> 
    {
        public GetRolePolicyResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetRolePolicyResult getRolePolicyResult = new GetRolePolicyResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("RoleName", targetDepth))
                    {
                        getRolePolicyResult.RoleName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        getRolePolicyResult.PolicyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PolicyDocument", targetDepth))
                    {
                        getRolePolicyResult.PolicyDocument = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getRolePolicyResult;
                }
            }
                        


            return getRolePolicyResult;
        }

        public GetRolePolicyResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetRolePolicyResultUnmarshaller instance;

        public static GetRolePolicyResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetRolePolicyResultUnmarshaller();

            return instance;
        }
    }
}
    
