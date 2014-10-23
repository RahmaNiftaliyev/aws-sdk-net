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
    /// Contains the result of a successful invocation of the <a>GetLoginProfile</a> action.
    /// </summary>
    public partial class GetLoginProfileResult : AmazonWebServiceResponse
    {
        private LoginProfile _loginProfile;

        /// <summary>
        /// Gets and sets the property LoginProfile. 
        /// <para>
        /// The user name and password create date for the user.
        /// </para>
        /// </summary>
        public LoginProfile LoginProfile
        {
            get { return this._loginProfile; }
            set { this._loginProfile = value; }
        }

        // Check to see if LoginProfile property is set
        internal bool IsSetLoginProfile()
        {
            return this._loginProfile != null;
        }

    }
}