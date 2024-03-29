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

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Parameter Unmarshaller
     /// </summary>
    internal class ParameterUnmarshaller : IUnmarshaller<Parameter, XmlUnmarshallerContext>, IUnmarshaller<Parameter, JsonUnmarshallerContext> 
    {
        public Parameter Unmarshall(XmlUnmarshallerContext context) 
        {
            Parameter parameter = new Parameter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ParameterKey", targetDepth))
                    {
                        parameter.ParameterKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ParameterValue", targetDepth))
                    {
                        parameter.ParameterValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return parameter;
                }
            }
                        


            return parameter;
        }

        public Parameter Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ParameterUnmarshaller instance;

        public static ParameterUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ParameterUnmarshaller();

            return instance;
        }
    }
}
    
