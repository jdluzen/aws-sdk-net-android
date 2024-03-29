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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ConfigurationSettingsDescription Unmarshaller
     /// </summary>
    internal class ConfigurationSettingsDescriptionUnmarshaller : IUnmarshaller<ConfigurationSettingsDescription, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationSettingsDescription, JsonUnmarshallerContext> 
    {
        public ConfigurationSettingsDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            ConfigurationSettingsDescription configurationSettingsDescription = new ConfigurationSettingsDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        configurationSettingsDescription.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        configurationSettingsDescription.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        configurationSettingsDescription.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        configurationSettingsDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        configurationSettingsDescription.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DeploymentStatus", targetDepth))
                    {
                        configurationSettingsDescription.DeploymentStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        configurationSettingsDescription.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        configurationSettingsDescription.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionSettings/member", targetDepth))
                    {
                        configurationSettingsDescription.OptionSettings.Add(ConfigurationOptionSettingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return configurationSettingsDescription;
                }
            }
                        


            return configurationSettingsDescription;
        }

        public ConfigurationSettingsDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ConfigurationSettingsDescriptionUnmarshaller instance;

        public static ConfigurationSettingsDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ConfigurationSettingsDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
