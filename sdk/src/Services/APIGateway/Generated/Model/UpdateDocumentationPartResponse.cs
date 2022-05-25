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
    /// A documentation part for a targeted API entity.
    /// </summary>
    public partial class UpdateDocumentationPartResponse : AmazonWebServiceResponse
    {
        private string _id;
        private DocumentationPartLocation _location;
        private string _properties;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The DocumentationPart identifier, generated by API Gateway when the <code>DocumentationPart</code>
        /// is created.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the API entity to which the documentation applies. Valid fields depend
        /// on the targeted API entity type. All the valid location fields are not required. If
        /// not explicitly specified, a valid location field is treated as a wildcard and associated
        /// documentation content may be inherited by matching entities, unless overridden.
        /// </para>
        /// </summary>
        public DocumentationPartLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A content map of API-specific key-value pairs describing the targeted API entity.
        /// The map must be encoded as a JSON string, e.g., <code>"{ \"description\": \"The API
        /// does ...\" }"</code>. Only OpenAPI-compliant documentation-related fields from the
        /// properties map are exported and, hence, published as part of the API entity definitions,
        /// while the original documentation parts are exported in a OpenAPI extension of <code>x-amazon-apigateway-documentation</code>.
        /// </para>
        /// </summary>
        public string Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

    }
}