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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribePipelinesResultUnmarshaller
      /// </summary>
      internal class DescribePipelinesResultUnmarshaller : IUnmarshaller<DescribePipelinesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribePipelinesResult, JsonUnmarshallerContext>
      {
        DescribePipelinesResult IUnmarshaller<DescribePipelinesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribePipelinesResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribePipelinesResult describePipelinesResult = new DescribePipelinesResult();
          describePipelinesResult.PipelineDescriptionList = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("PipelineDescriptionList", targetDepth))
              {
                describePipelinesResult.PipelineDescriptionList = new List<PipelineDescription>();
                        PipelineDescriptionUnmarshaller unmarshaller = PipelineDescriptionUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describePipelinesResult.PipelineDescriptionList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describePipelinesResult;
                }
            }
          

            return describePipelinesResult;
        }

        private static DescribePipelinesResultUnmarshaller instance;
        public static DescribePipelinesResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribePipelinesResultUnmarshaller();
            return instance;
        }
    }
}
  
