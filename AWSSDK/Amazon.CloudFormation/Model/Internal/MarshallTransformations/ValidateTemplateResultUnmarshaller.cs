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
using System.Collections.Generic;

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ValidateTemplateResult Unmarshaller
     /// </summary>
    internal class ValidateTemplateResultUnmarshaller : IUnmarshaller<ValidateTemplateResult, XmlUnmarshallerContext> 
    {
        public ValidateTemplateResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ValidateTemplateResult validateTemplateResult = new ValidateTemplateResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        validateTemplateResult.Parameters.Add(TemplateParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        validateTemplateResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Capabilities/member", targetDepth))
                    {
                        validateTemplateResult.Capabilities.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("CapabilitiesReason", targetDepth))
                    {
                        validateTemplateResult.CapabilitiesReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return validateTemplateResult;
                }
            }
                        


            return validateTemplateResult;
        }

        private static ValidateTemplateResultUnmarshaller instance;

        public static ValidateTemplateResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ValidateTemplateResultUnmarshaller();

            return instance;
        }
    }
}
    