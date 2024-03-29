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

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Ebs Unmarshaller
     /// </summary>
    internal class EbsUnmarshaller : IUnmarshaller<Ebs, XmlUnmarshallerContext>, IUnmarshaller<Ebs, JsonUnmarshallerContext> 
    {
        public Ebs Unmarshall(XmlUnmarshallerContext context) 
        {
            Ebs ebs = new Ebs();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SnapshotId", targetDepth))
                    {
                        ebs.SnapshotId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VolumeSize", targetDepth))
                    {
                        ebs.VolumeSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VolumeType", targetDepth))
                    {
                        ebs.VolumeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DeleteOnTermination", targetDepth))
                    {
                        ebs.DeleteOnTermination = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Iops", targetDepth))
                    {
                        ebs.Iops = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return ebs;
                }
            }
                        


            return ebs;
        }

        public Ebs Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EbsUnmarshaller instance;

        public static EbsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EbsUnmarshaller();

            return instance;
        }
    }
}
    
