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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribeTableResultUnmarshaller
      /// </summary>
      internal class DescribeTableResultUnmarshaller : IUnmarshaller<DescribeTableResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTableResult, JsonUnmarshallerContext>
      {
        DescribeTableResult IUnmarshaller<DescribeTableResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeTableResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DescribeTableResult describeTableResult = new DescribeTableResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Table", targetDepth))
              {
                describeTableResult.Table = TableDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeTableResult;
                }
            }
          

            return describeTableResult;
        }

        private static DescribeTableResultUnmarshaller instance;
        public static DescribeTableResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeTableResultUnmarshaller();
            return instance;
        }
    }
}
  
