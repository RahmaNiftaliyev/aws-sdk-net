﻿/*
 * Copyright 2011-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime
{
    /// <summary>
    /// State class passed on callback to demand user credentials when authentication
    /// needs to be performed using a non-default identity.
    /// </summary>
    public class CredentialRequestCallbackArgs
    {
        /// <summary>
        /// Contains the name of the credential profile we are authenticating
        /// for. Use in display prompts to give the user some context as to
        /// why their credentials are being requested.
        /// </summary>
        public string ProfileName { get; internal set; }
        /// <summary>
        /// Contains the user identity that the user should supply a password
        /// for. The user can ignore if they choose and return credentials for
        /// an alternate account.
        /// </summary>
        public string UserIdentity { get; internal set; }

        /// <summary>
        /// Any custom state that was registered with the callback.
        /// </summary>
        public object CustomState { get; internal set; }

        /// <summary>
        /// Set if the callback was due to a failed authentication attempt.
        /// If false we are beginning to obtain or refresh credentials.
        /// </summary>
        public bool PreviousAuthenticationFailed { get; internal set; }
    }
}
