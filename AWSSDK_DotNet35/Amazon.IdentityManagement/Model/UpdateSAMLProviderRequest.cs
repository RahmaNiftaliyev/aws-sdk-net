/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSAMLProvider operation.
    /// Updates the metadata document for an existing SAML provider.
    /// </summary>
    public partial class UpdateSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _sAMLMetadataDocument;
        private string _sAMLProviderArn;

        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        ///  An XML document generated by an identity provider (IdP) that supports SAML 2.0. The
        /// document includes the issuer's name, expiration information, and keys that can be
        /// used to validate the SAML authentication response (assertions) that are received from
        /// the IdP. You must generate the metadata document using the identity management software
        /// that is used as your organization's IdP. 
        /// </para>
        /// </summary>
        public string SAMLMetadataDocument
        {
            get { return this._sAMLMetadataDocument; }
            set { this._sAMLMetadataDocument = value; }
        }

        // Check to see if SAMLMetadataDocument property is set
        internal bool IsSetSAMLMetadataDocument()
        {
            return this._sAMLMetadataDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider to update.
        /// </para>
        /// </summary>
        public string SAMLProviderArn
        {
            get { return this._sAMLProviderArn; }
            set { this._sAMLProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this._sAMLProviderArn != null;
        }

    }
}