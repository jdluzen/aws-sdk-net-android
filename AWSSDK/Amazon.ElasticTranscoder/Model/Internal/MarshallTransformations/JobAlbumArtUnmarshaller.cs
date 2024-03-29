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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobAlbumArtUnmarshaller
      /// </summary>
      internal class JobAlbumArtUnmarshaller : IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>, IUnmarshaller<JobAlbumArt, JsonUnmarshallerContext>
      {
        JobAlbumArt IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobAlbumArt Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            JobAlbumArt jobAlbumArt = new JobAlbumArt();
          jobAlbumArt.Artwork = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("MergePolicy", targetDepth))
              {
                jobAlbumArt.MergePolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Artwork", targetDepth))
              {
                
                  if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                  {
                      jobAlbumArt.Artwork = null;
                      continue;
                  }              
                  jobAlbumArt.Artwork = new List<Artwork>();
                  ArtworkUnmarshaller unmarshaller = ArtworkUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     jobAlbumArt.Artwork.Add(unmarshaller.Unmarshall(context));
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
                    return jobAlbumArt;
                }
            }
          

            return jobAlbumArt;
        }

        private static JobAlbumArtUnmarshaller instance;
        public static JobAlbumArtUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobAlbumArtUnmarshaller();
            return instance;
        }
    }
}
  
