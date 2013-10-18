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
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Cloud Front Origin Access Identities Request Marshaller
    /// </summary>       
    public class ListCloudFrontOriginAccessIdentitiesRequestMarshaller : IMarshaller<IRequest, ListCloudFrontOriginAccessIdentitiesRequest>
    {
        
    
        public IRequest Marshall(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest)
        {
            IRequest request = new DefaultRequest(listCloudFrontOriginAccessIdentitiesRequest, "AmazonCloudFront");



            request.HttpMethod = "GET";
              
            string uriResourcePath = "2013-09-27/origin-access-identity/cloudfront?Marker={Marker}&MaxItems={MaxItems}"; 
            uriResourcePath = uriResourcePath.Replace("{Marker}", listCloudFrontOriginAccessIdentitiesRequest.Marker ?? "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxItems}", listCloudFrontOriginAccessIdentitiesRequest.MaxItems ?? "" ); 
            
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
            
        
            request.UseQueryString = true;
        
            
            return request;
        }
    }
}
    
