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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents options that specify how and where DataBrew writes the database output
    /// generated by recipe jobs.
    /// </summary>
    public partial class DatabaseTableOutputOptions
    {
        private string _tableName;
        private S3Location _tempDirectory;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// A prefix for the name of a table DataBrew will create in the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TempDirectory. 
        /// <para>
        /// Represents an Amazon S3 location (bucket name and object key) where DataBrew can store
        /// intermediate results.
        /// </para>
        /// </summary>
        public S3Location TempDirectory
        {
            get { return this._tempDirectory; }
            set { this._tempDirectory = value; }
        }

        // Check to see if TempDirectory property is set
        internal bool IsSetTempDirectory()
        {
            return this._tempDirectory != null;
        }

    }
}