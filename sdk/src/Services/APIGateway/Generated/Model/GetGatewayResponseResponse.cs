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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A gateway response of a given response type and status code, with optional response
    /// parameters and mapping templates.
    /// </summary>
    public partial class GetGatewayResponseResponse : AmazonWebServiceResponse
    {
        private bool? _defaultResponse;
        private Dictionary<string, string> _responseParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _responseTemplates = new Dictionary<string, string>();
        private GatewayResponseType _responseType;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property DefaultResponse. 
        /// <para>
        /// A Boolean flag to indicate whether this GatewayResponse is the default gateway response
        /// (<code>true</code>) or not (<code>false</code>). A default gateway response is one
        /// generated by API Gateway without any customization by an API developer. 
        /// </para>
        /// </summary>
        public bool DefaultResponse
        {
            get { return this._defaultResponse.GetValueOrDefault(); }
            set { this._defaultResponse = value; }
        }

        // Check to see if DefaultResponse property is set
        internal bool IsSetDefaultResponse()
        {
            return this._defaultResponse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Response parameters (paths, query strings and headers) of the GatewayResponse as a
        /// string-to-string map of key-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && this._responseParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTemplates. 
        /// <para>
        /// Response templates of the GatewayResponse as a string-to-string map of key-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseTemplates
        {
            get { return this._responseTemplates; }
            set { this._responseTemplates = value; }
        }

        // Check to see if ResponseTemplates property is set
        internal bool IsSetResponseTemplates()
        {
            return this._responseTemplates != null && this._responseTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseType. 
        /// <para>
        /// The response type of the associated GatewayResponse.
        /// </para>
        /// </summary>
        public GatewayResponseType ResponseType
        {
            get { return this._responseType; }
            set { this._responseType = value; }
        }

        // Check to see if ResponseType property is set
        internal bool IsSetResponseType()
        {
            return this._responseType != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code for this GatewayResponse.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}