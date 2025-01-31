/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.HealthLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFHIRDatastore Request Marshaller
    /// </summary>       
    public class CreateFHIRDatastoreRequestMarshaller : IMarshaller<IRequest, CreateFHIRDatastoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFHIRDatastoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFHIRDatastoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.HealthLake");
            string target = "HealthLake.CreateFHIRDatastore";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDatastoreName())
                {
                    context.Writer.WritePropertyName("DatastoreName");
                    context.Writer.Write(publicRequest.DatastoreName);
                }

                if(publicRequest.IsSetDatastoreTypeVersion())
                {
                    context.Writer.WritePropertyName("DatastoreTypeVersion");
                    context.Writer.Write(publicRequest.DatastoreTypeVersion);
                }

                if(publicRequest.IsSetPreloadDataConfig())
                {
                    context.Writer.WritePropertyName("PreloadDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PreloadDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PreloadDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSseConfiguration())
                {
                    context.Writer.WritePropertyName("SseConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SseConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SseConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateFHIRDatastoreRequestMarshaller _instance = new CreateFHIRDatastoreRequestMarshaller();        

        internal static CreateFHIRDatastoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFHIRDatastoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}