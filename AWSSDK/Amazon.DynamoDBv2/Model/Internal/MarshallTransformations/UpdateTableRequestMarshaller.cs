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
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Table Request Marshaller
    /// </summary>       
    internal class UpdateTableRequestMarshaller : IMarshaller<IRequest, UpdateTableRequest> 
    {
        

        public IRequest Marshall(UpdateTableRequest updateTableRequest) 
        {

            IRequest request = new DefaultRequest(updateTableRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.UpdateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (updateTableRequest != null && updateTableRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(updateTableRequest.TableName);
                }

                if (updateTableRequest != null) 
                {
                    ProvisionedThroughput provisionedThroughput = updateTableRequest.ProvisionedThroughput;
                    if (provisionedThroughput != null)
                    {
                        writer.WritePropertyName("ProvisionedThroughput");
                        writer.WriteObjectStart();
                        if (provisionedThroughput != null && provisionedThroughput.IsSetReadCapacityUnits()) 
                        {
                            writer.WritePropertyName("ReadCapacityUnits");
                            writer.Write(provisionedThroughput.ReadCapacityUnits);
                        }
                        if (provisionedThroughput != null && provisionedThroughput.IsSetWriteCapacityUnits()) 
                        {
                            writer.WritePropertyName("WriteCapacityUnits");
                            writer.Write(provisionedThroughput.WriteCapacityUnits);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (updateTableRequest != null && updateTableRequest.GlobalSecondaryIndexUpdates != null && updateTableRequest.GlobalSecondaryIndexUpdates.Count > 0)
                {
                    List<GlobalSecondaryIndexUpdate> globalSecondaryIndexUpdatesList = updateTableRequest.GlobalSecondaryIndexUpdates;
                    writer.WritePropertyName("GlobalSecondaryIndexUpdates");
                    writer.WriteArrayStart();

                    foreach (GlobalSecondaryIndexUpdate globalSecondaryIndexUpdatesListValue in globalSecondaryIndexUpdatesList) 
                    {
                        writer.WriteObjectStart();

                        if (globalSecondaryIndexUpdatesListValue != null) 
                        {
                            UpdateGlobalSecondaryIndexAction update = globalSecondaryIndexUpdatesListValue.Update;
                            if (update != null)
                            {
                                writer.WritePropertyName("Update");
                                writer.WriteObjectStart();
                                if (update != null && update.IsSetIndexName()) 
                                {
                                    writer.WritePropertyName("IndexName");
                                    writer.Write(update.IndexName);
                                }

                                if (update != null) 
                                {
                                    ProvisionedThroughput provisionedThroughput = update.ProvisionedThroughput;
                                    if (provisionedThroughput != null)
                                    {
                                        writer.WritePropertyName("ProvisionedThroughput");
                                        writer.WriteObjectStart();
                                        if (provisionedThroughput != null && provisionedThroughput.IsSetReadCapacityUnits()) 
                                        {
                                            writer.WritePropertyName("ReadCapacityUnits");
                                            writer.Write(provisionedThroughput.ReadCapacityUnits);
                                        }
                                        if (provisionedThroughput != null && provisionedThroughput.IsSetWriteCapacityUnits()) 
                                        {
                                            writer.WritePropertyName("WriteCapacityUnits");
                                            writer.Write(provisionedThroughput.WriteCapacityUnits);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
