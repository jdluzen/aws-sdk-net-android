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
using System.Net;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ModifyEventSubscription operation
    /// </summary>
    internal class ModifyEventSubscriptionResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            ModifyEventSubscriptionResponse response = new ModifyEventSubscriptionResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    
                    if(context.TestExpression("ModifyEventSubscriptionResult", 2))
                    {
                        response.ModifyEventSubscriptionResult = ModifyEventSubscriptionResultUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }
                

            return response;
        }
        
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("SubscriptionCategoryNotFound"))
            {
                return new SubscriptionCategoryNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SubscriptionEventIdNotFound"))
            {
                return new SubscriptionEventIdNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SubscriptionSeverityNotFound"))
            {
                return new SubscriptionSeverityNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SourceNotFound"))
            {
                return new SourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SNSNoAuthorization"))
            {
                return new SNSNoAuthorizationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SNSTopicArnNotFound"))
            {
                return new SNSTopicArnNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SubscriptionNotFound"))
            {
                return new SubscriptionNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("SNSInvalidTopic"))
            {
                return new SNSInvalidTopicException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static ModifyEventSubscriptionResponseUnmarshaller instance;

        public static ModifyEventSubscriptionResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new ModifyEventSubscriptionResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
