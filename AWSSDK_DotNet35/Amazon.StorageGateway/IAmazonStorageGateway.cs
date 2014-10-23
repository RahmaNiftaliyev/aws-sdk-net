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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.StorageGateway.Model;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Interface for accessing StorageGateway
    ///
    /// AWS Storage Gateway Service 
    /// <para>
    /// AWS Storage Gateway is the service that connects an on-premises software appliance
    /// with cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and AWS's storage infrastructure. The service enables you
    /// to securely upload data to the AWS cloud for cost effective backup and rapid disaster
    /// recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>AWS Storage Gateway Service API
    /// Reference</i>:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayHTTPRequestsHeaders.html">AWS
    /// Storage Gateway Required Request Headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.</li> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewaySigningRequests.html">Signing
    /// Requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.</li> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/APIErrorResponses.html">Error
    /// Responses</a>: Provides reference information about AWS Storage Gateway errors.</li>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPIOperations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.</li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">AWS
    /// Storage Gateway Regions and Endpoints</a>: Provides a list of each of the regions
    /// and endpoints available for use with AWS Storage Gateway. </li> </ul>
    /// </summary>
    public partial interface IAmazonStorageGateway : IDisposable
    {

        
        #region  ActivateGateway

        /// <summary>
        /// This operation activates the gateway you previously deployed on your host. For more
        /// information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/GettingStartedActivateGateway-common.html">
        /// Activate the AWS Storage Gateway</a>. In the activation process, you specify information
        /// such as the region you want to use for storing snapshots, the time zone for scheduled
        /// snapshots the gateway snapshot schedule window, an activation key, and a name for
        /// your gateway. The activation process also associates your gateway with your account;
        /// for more information, see <a>UpdateGatewayInformation</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateGateway
        ///         operation.</returns>
        IAsyncResult BeginActivateGateway(ActivateGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateGateway.</param>
        /// 
        /// <returns>Returns a  ActivateGatewayResult from StorageGateway.</returns>
        ActivateGatewayResponse EndActivateGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AddCache

        /// <summary>
        /// This operation configures one or more gateway local disks as cache for a cached-volume
        /// gateway. This operation is supported only for the gateway-cached volume architecture
        /// (see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">Storage
        /// Gateway Concepts</a>).
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        AddCacheResponse AddCache(AddCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCache
        ///         operation.</returns>
        IAsyncResult BeginAddCache(AddCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCache.</param>
        /// 
        /// <returns>Returns a  AddCacheResult from StorageGateway.</returns>
        AddCacheResponse EndAddCache(IAsyncResult asyncResult);

        #endregion
        
        #region  AddUploadBuffer

        /// <summary>
        /// This operation configures one or more gateway local disks as upload buffer for a specified
        /// gateway. This operation is supported for both the gateway-stored and gateway-cached
        /// volume architectures. 
        /// 
        ///  
        /// <para>
        ///  In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add upload buffer, and one or more disk IDs that you want to configure as upload
        /// buffer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddUploadBuffer
        ///         operation.</returns>
        IAsyncResult BeginAddUploadBuffer(AddUploadBufferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUploadBuffer.</param>
        /// 
        /// <returns>Returns a  AddUploadBufferResult from StorageGateway.</returns>
        AddUploadBufferResponse EndAddUploadBuffer(IAsyncResult asyncResult);

        #endregion
        
        #region  AddWorkingStorage

        /// <summary>
        /// This operation configures one or more gateway local disks as working storage for a
        /// gateway. This operation is supported only for the gateway-stored volume architecture.
        /// This operation is deprecated method in cached-volumes API version (20120630). Use
        /// AddUploadBuffer instead.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddWorkingStorage
        ///         operation.</returns>
        IAsyncResult BeginAddWorkingStorage(AddWorkingStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddWorkingStorage.</param>
        /// 
        /// <returns>Returns a  AddWorkingStorageResult from StorageGateway.</returns>
        AddWorkingStorageResponse EndAddWorkingStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelArchival

        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CancelArchivalResponse CancelArchival(CancelArchivalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelArchival operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelArchival
        ///         operation.</returns>
        IAsyncResult BeginCancelArchival(CancelArchivalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelArchival operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelArchival.</param>
        /// 
        /// <returns>Returns a  CancelArchivalResult from StorageGateway.</returns>
        CancelArchivalResponse EndCancelArchival(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelRetrieval

        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRetrieval operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelRetrieval
        ///         operation.</returns>
        IAsyncResult BeginCancelRetrieval(CancelRetrievalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelRetrieval operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelRetrieval.</param>
        /// 
        /// <returns>Returns a  CancelRetrievalResult from StorageGateway.</returns>
        CancelRetrievalResponse EndCancelRetrieval(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCachediSCSIVolume

        /// <summary>
        /// This operation creates a cached volume on a specified cached gateway. This operation
        /// is supported only for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
        /// target name, an IP address on which to expose the target, and a unique client token.
        /// In response, AWS Storage Gateway creates the volume and returns information about
        /// it such as the volume Amazon Resource Name (ARN), its size, and the iSCSI target ARN
        /// that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCachediSCSIVolume
        ///         operation.</returns>
        IAsyncResult BeginCreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCachediSCSIVolume.</param>
        /// 
        /// <returns>Returns a  CreateCachediSCSIVolumeResult from StorageGateway.</returns>
        CreateCachediSCSIVolumeResponse EndCreateCachediSCSIVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// This operation initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway provides the ability to back up point-in-time snapshots of your
        /// data to Amazon Simple Storage (S3) for durable off-site recovery, as well as import
        /// the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute Cloud
        /// (EC2). You can take snapshots of your gateway volume on a scheduled or ad-hoc basis.
        /// This API enables you to take ad-hoc snapshot. For more information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
        /// With Snapshots in the AWS Storage Gateway Console</a>.
        /// </para>
        ///  
        /// <para>
        /// In the CreateSnapshot request you identify the volume by providing its Amazon Resource
        /// Name (ARN). You must also provide description for the snapshot. When AWS Storage Gateway
        /// takes the snapshot of specified volume, the snapshot and description appears in the
        /// AWS Storage Gateway Console. In response, AWS Storage Gateway returns you a snapshot
        /// ID. You can use this snapshot ID to check the snapshot progress or later use it when
        /// you want to create a volume from a snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from StorageGateway.</returns>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint

        /// <summary>
        /// This operation initiates a snapshot of a gateway from a volume recovery point. This
        /// operation is supported only for the gateway-cached volume architecture (see ).
        /// 
        ///  
        /// <para>
        /// A volume recovery point is a point in time at which all data of the volume is consistent
        /// and from which you can create a snapshot. To get a list of volume recovery point for
        /// gateway-cached volumes, use <a>ListVolumeRecoveryPoints</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
        /// for the snapshot. When AWS Storage Gateway takes a snapshot of the specified volume,
        /// the snapshot and its description appear in the AWS Storage Gateway console. In response,
        /// AWS Storage Gateway returns you a snapshot ID. You can use this snapshot ID to check
        /// the snapshot progress or later use it when you want to create a volume from a snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshotFromVolumeRecoveryPoint
        ///         operation.</returns>
        IAsyncResult BeginCreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotFromVolumeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotFromVolumeRecoveryPointResult from StorageGateway.</returns>
        CreateSnapshotFromVolumeRecoveryPointResponse EndCreateSnapshotFromVolumeRecoveryPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStorediSCSIVolume

        /// <summary>
        /// This operation creates a volume on a specified gateway. This operation is supported
        /// only for the gateway-stored volume architecture. 
        /// 
        ///  
        /// <para>
        /// The size of the volume to create is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create
        /// an empty volume. If you choose to create an empty gateway volume, then any existing
        /// data on the disk is erased.
        /// </para>
        ///  
        /// <para>
        /// In the request you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, AWS Storage Gateway creates the volume and returns
        /// volume information such as the volume Amazon Resource Name (ARN), its size, and the
        /// iSCSI target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorediSCSIVolume
        ///         operation.</returns>
        IAsyncResult BeginCreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorediSCSIVolume.</param>
        /// 
        /// <returns>Returns a  CreateStorediSCSIVolumeResult from StorageGateway.</returns>
        CreateStorediSCSIVolumeResponse EndCreateStorediSCSIVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTapes

        /// <summary>
        /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
        /// the tapes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method.</param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        CreateTapesResponse CreateTapes(CreateTapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTapes
        ///         operation.</returns>
        IAsyncResult BeginCreateTapes(CreateTapesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTapes.</param>
        /// 
        /// <returns>Returns a  CreateTapesResult from StorageGateway.</returns>
        CreateTapesResponse EndCreateTapes(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBandwidthRateLimit

        /// <summary>
        /// This operation deletes the bandwidth rate limits of a gateway. You can delete either
        /// the upload and download bandwidth rate limit, or you can delete both. If you delete
        /// only one of the limits, the other limit remains unchanged. To specify which gateway
        /// to work with, use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBandwidthRateLimit
        ///         operation.</returns>
        IAsyncResult BeginDeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  DeleteBandwidthRateLimitResult from StorageGateway.</returns>
        DeleteBandwidthRateLimitResponse EndDeleteBandwidthRateLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChapCredentials

        /// <summary>
        /// This operation deletes Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// for a specified iSCSI target and initiator pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChapCredentials
        ///         operation.</returns>
        IAsyncResult BeginDeleteChapCredentials(DeleteChapCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChapCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteChapCredentialsResult from StorageGateway.</returns>
        DeleteChapCredentialsResponse EndDeleteChapCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGateway

        /// <summary>
        /// This operation deletes a gateway. To specify which gateway to delete, use the Amazon
        /// Resource Name (ARN) of the gateway in your request. The operation deletes the gateway;
        /// however, it does not delete the gateway virtual machine (VM) from your host computer.
        /// 
        ///  
        /// <para>
        /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
        /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
        /// not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.
        /// </para>
        ///  <important> 
        /// <para>
        /// You no longer pay software charges after the gateway is deleted; however, your existing
        /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
        /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
        /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">
        /// AWS Storage Gateway Detail Page</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from StorageGateway.</returns>
        DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshotSchedule

        /// <summary>
        /// This operation deletes a snapshot of a volume. 
        /// 
        ///  
        /// <para>
        ///  You can take snapshots of your gateway volumes on a scheduled or ad-hoc basis. This
        /// API enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
        /// with Snapshots</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
        /// the volume by providing its Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshotSchedule
        ///         operation.</returns>
        IAsyncResult BeginDeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotScheduleResult from StorageGateway.</returns>
        DeleteSnapshotScheduleResponse EndDeleteSnapshotSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTape

        /// <summary>
        /// Deletes the specified virtual tape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteTapeResponse DeleteTape(DeleteTapeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTape operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTape
        ///         operation.</returns>
        IAsyncResult BeginDeleteTape(DeleteTapeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTape operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTape.</param>
        /// 
        /// <returns>Returns a  DeleteTapeResult from StorageGateway.</returns>
        DeleteTapeResponse EndDeleteTape(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTapeArchive

        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTapeArchive
        ///         operation.</returns>
        IAsyncResult BeginDeleteTapeArchive(DeleteTapeArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTapeArchive.</param>
        /// 
        /// <returns>Returns a  DeleteTapeArchiveResult from StorageGateway.</returns>
        DeleteTapeArchiveResponse EndDeleteTapeArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVolume

        /// <summary>
        /// This operation delete the specified gateway volume that you previously created using
        /// the <a>CreateStorediSCSIVolume</a> API. For gateway-stored volumes, the local disk
        /// that was configured as the storage volume is not deleted. You can reuse the local
        /// disk to create another storage volume. 
        /// 
        ///  
        /// <para>
        /// Before you delete a gateway volume, make sure there are no iSCSI connections to the
        /// volume you are deleting. You should also make sure there is no snapshot in progress.
        /// You can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on
        /// the volume you are deleting and check the snapshot status. For more information, go
        /// to <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from StorageGateway.</returns>
        DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBandwidthRateLimit

        /// <summary>
        /// This operation returns the bandwidth rate limits of a gateway. By default, these limits
        /// are not set, which means no bandwidth rate limiting is in effect.
        /// 
        ///  
        /// <para>
        /// This operation only returns a value for a bandwidth rate limit only if the limit is
        /// set. If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBandwidthRateLimit
        ///         operation.</returns>
        IAsyncResult BeginDescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  DescribeBandwidthRateLimitResult from StorageGateway.</returns>
        DescribeBandwidthRateLimitResponse EndDescribeBandwidthRateLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCache

        /// <summary>
        /// This operation returns information about the cache of a gateway. This operation is
        /// supported only for the gateway-cached volume architecture. 
        /// 
        ///  
        /// <para>
        ///  The response includes disk IDs that are configured as cache, and it includes the
        /// amount of cache allocated and used. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeCacheResponse DescribeCache(DescribeCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCache
        ///         operation.</returns>
        IAsyncResult BeginDescribeCache(DescribeCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCache.</param>
        /// 
        /// <returns>Returns a  DescribeCacheResult from StorageGateway.</returns>
        DescribeCacheResponse EndDescribeCache(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCachediSCSIVolumes

        /// <summary>
        /// This operation returns a description of the gateway volumes specified in the request.
        /// This operation is supported only for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        ///  The list of gateway volumes in the request must be from one gateway. In the response
        /// Amazon Storage Gateway returns volume information sorted by volume Amazon Resource
        /// Name (ARN). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCachediSCSIVolumes
        ///         operation.</returns>
        IAsyncResult BeginDescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCachediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeCachediSCSIVolumesResult from StorageGateway.</returns>
        DescribeCachediSCSIVolumesResponse EndDescribeCachediSCSIVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChapCredentials

        /// <summary>
        /// This operation returns an array of Challenge-Handshake Authentication Protocol (CHAP)
        /// credentials information for a specified iSCSI target, one for each target-initiator
        /// pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChapCredentials
        ///         operation.</returns>
        IAsyncResult BeginDescribeChapCredentials(DescribeChapCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChapCredentials.</param>
        /// 
        /// <returns>Returns a  DescribeChapCredentialsResult from StorageGateway.</returns>
        DescribeChapCredentialsResponse EndDescribeChapCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGatewayInformation

        /// <summary>
        /// This operation returns metadata about a gateway such as its name, network interfaces,
        /// configured time zone, and the state (whether the gateway is running or not). To specify
        /// which gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGatewayInformation
        ///         operation.</returns>
        IAsyncResult BeginDescribeGatewayInformation(DescribeGatewayInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayInformation.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayInformationResult from StorageGateway.</returns>
        DescribeGatewayInformationResponse EndDescribeGatewayInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMaintenanceStartTime

        /// <summary>
        /// This operation returns your gateway's weekly maintenance start time including the
        /// day and time of the week. Note that values are in terms of the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceStartTime
        ///         operation.</returns>
        IAsyncResult BeginDescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceStartTimeResult from StorageGateway.</returns>
        DescribeMaintenanceStartTimeResponse EndDescribeMaintenanceStartTime(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshotSchedule

        /// <summary>
        /// This operation describes the snapshot schedule for the specified gateway volume. The
        /// snapshot schedule information includes intervals at which snapshots are automatically
        /// initiated on the volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotSchedule
        ///         operation.</returns>
        IAsyncResult BeginDescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotScheduleResult from StorageGateway.</returns>
        DescribeSnapshotScheduleResponse EndDescribeSnapshotSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStorediSCSIVolumes

        /// <summary>
        /// This operation returns description of the gateway volumes specified in the request.
        /// The list of gateway volumes in the request must be from one gateway. In the response
        /// Amazon Storage Gateway returns volume information sorted by volume ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStorediSCSIVolumes
        ///         operation.</returns>
        IAsyncResult BeginDescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeStorediSCSIVolumesResult from StorageGateway.</returns>
        DescribeStorediSCSIVolumesResponse EndDescribeStorediSCSIVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTapeArchives

        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// 
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeTapeArchivesResponse DescribeTapeArchives();

        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// 
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeArchives operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapeArchives
        ///         operation.</returns>
        IAsyncResult BeginDescribeTapeArchives(DescribeTapeArchivesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapeArchives operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapeArchives.</param>
        /// 
        /// <returns>Returns a  DescribeTapeArchivesResult from StorageGateway.</returns>
        DescribeTapeArchivesResponse EndDescribeTapeArchives(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTapeRecoveryPoints

        /// <summary>
        /// Returns a list of virtual tape recovery points that are available for the specified
        /// gateway-VTL.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the virtual tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapeRecoveryPoints
        ///         operation.</returns>
        IAsyncResult BeginDescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapeRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  DescribeTapeRecoveryPointsResult from StorageGateway.</returns>
        DescribeTapeRecoveryPointsResponse EndDescribeTapeRecoveryPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTapes

        /// <summary>
        /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
        /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
        /// associated with the specified gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeTapesResponse DescribeTapes(DescribeTapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapes
        ///         operation.</returns>
        IAsyncResult BeginDescribeTapes(DescribeTapesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapes.</param>
        /// 
        /// <returns>Returns a  DescribeTapesResult from StorageGateway.</returns>
        DescribeTapesResponse EndDescribeTapes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUploadBuffer

        /// <summary>
        /// This operation returns information about the upload buffer of a gateway. This operation
        /// is supported for both the gateway-stored and gateway-cached volume architectures.
        /// 
        /// 
        ///  
        /// <para>
        ///  The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUploadBuffer
        ///         operation.</returns>
        IAsyncResult BeginDescribeUploadBuffer(DescribeUploadBufferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUploadBuffer.</param>
        /// 
        /// <returns>Returns a  DescribeUploadBufferResult from StorageGateway.</returns>
        DescribeUploadBufferResponse EndDescribeUploadBuffer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVTLDevices

        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified gateway.
        /// In the response, AWS Storage Gateway returns VTL device information. 
        /// 
        ///  
        /// <para>
        /// The list of VTL devices must be from one gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVTLDevices operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVTLDevices
        ///         operation.</returns>
        IAsyncResult BeginDescribeVTLDevices(DescribeVTLDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVTLDevices operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVTLDevices.</param>
        /// 
        /// <returns>Returns a  DescribeVTLDevicesResult from StorageGateway.</returns>
        DescribeVTLDevicesResponse EndDescribeVTLDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkingStorage

        /// <summary>
        /// This operation returns information about the working storage of a gateway. This operation
        /// is supported only for the gateway-stored volume architecture. This operation is deprecated
        /// in cached-volumes API version (20120630). Use DescribeUploadBuffer instead.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as working storage, and it includes
        /// the amount of working storage allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkingStorage
        ///         operation.</returns>
        IAsyncResult BeginDescribeWorkingStorage(DescribeWorkingStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkingStorage.</param>
        /// 
        /// <returns>Returns a  DescribeWorkingStorageResult from StorageGateway.</returns>
        DescribeWorkingStorageResponse EndDescribeWorkingStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableGateway

        /// <summary>
        /// Disables a gateway when the gateway is no longer functioning. For example, if your
        /// gateway VM is damaged, you can disable the gateway so you can recover virtual tapes.
        /// 
        /// 
        ///  
        /// <para>
        /// Use this operation for a gateway-VTL that is not reachable or not functioning.
        /// </para>
        ///  <important>Once a gateway is disabled it cannot be enabled.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        DisableGatewayResponse DisableGateway(DisableGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableGateway
        ///         operation.</returns>
        IAsyncResult BeginDisableGateway(DisableGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableGateway.</param>
        /// 
        /// <returns>Returns a  DisableGatewayResult from StorageGateway.</returns>
        DisableGatewayResponse EndDisableGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGateways

        /// <summary>
        /// This operation lists gateways owned by an AWS account in a region specified in the
        /// request. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response-that is, the response returns
        /// only a truncated list of your gateways-the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ListGatewaysResponse ListGateways();

        /// <summary>
        /// This operation lists gateways owned by an AWS account in a region specified in the
        /// request. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response-that is, the response returns
        /// only a truncated list of your gateways-the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ListGatewaysResponse ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from StorageGateway.</returns>
        ListGatewaysResponse EndListGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLocalDisks

        /// <summary>
        /// This operation returns a list of the local disks of a gateway. To specify which gateway
        /// to describe you use the Amazon Resource Name (ARN) of the gateway in the body of the
        /// request.
        /// 
        ///  
        /// <para>
        /// The request returns all disks, specifying which are configured as working storage,
        /// stored volume or not configured at all.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLocalDisks
        ///         operation.</returns>
        IAsyncResult BeginListLocalDisks(ListLocalDisksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLocalDisks.</param>
        /// 
        /// <returns>Returns a  ListLocalDisksResult from StorageGateway.</returns>
        ListLocalDisksResponse EndListLocalDisks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVolumeRecoveryPoints

        /// <summary>
        /// This operation lists the recovery points for a specified gateway. This operation is
        /// supported only for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// Each gateway-cached volume has one recovery point. A volume recovery point is a point
        /// in time at which all data of the volume is consistent and from which you can create
        /// a snapshot. To create a snapshot from a volume recovery point use the <a>CreateSnapshotFromVolumeRecoveryPoint</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumeRecoveryPoints
        ///         operation.</returns>
        IAsyncResult BeginListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumeRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  ListVolumeRecoveryPointsResult from StorageGateway.</returns>
        ListVolumeRecoveryPointsResponse EndListVolumeRecoveryPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVolumes

        /// <summary>
        /// This operation lists the iSCSI stored volumes of a gateway. Results are sorted by
        /// volume ARN. The response includes only the volume ARNs. If you want additional volume
        /// information, use the <a>DescribeStorediSCSIVolumes</a> API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <code>Limit</code> field in the
        /// body to limit the number of volumes in the response. If the number of volumes returned
        /// in the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ListVolumesResponse ListVolumes(ListVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumes
        ///         operation.</returns>
        IAsyncResult BeginListVolumes(ListVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumes.</param>
        /// 
        /// <returns>Returns a  ListVolumesResult from StorageGateway.</returns>
        ListVolumesResponse EndListVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveTapeArchive

        /// <summary>
        /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a gateway-VTL.
        /// Virtual tapes archived in the VTS are not associated with any gateway. However after
        /// a tape is retrieved, it is associated with a gateway, even though it is also listed
        /// in the VTS.
        /// 
        ///  
        /// <para>
        /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
        /// another gateway. You must archive the tape again before you can retrieve it to another
        /// gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveTapeArchive
        ///         operation.</returns>
        IAsyncResult BeginRetrieveTapeArchive(RetrieveTapeArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveTapeArchive.</param>
        /// 
        /// <returns>Returns a  RetrieveTapeArchiveResult from StorageGateway.</returns>
        RetrieveTapeArchiveResponse EndRetrieveTapeArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveTapeRecoveryPoint

        /// <summary>
        /// Retrieves the recovery point for the specified virtual tape.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveTapeRecoveryPoint
        ///         operation.</returns>
        IAsyncResult BeginRetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveTapeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveTapeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  RetrieveTapeRecoveryPointResult from StorageGateway.</returns>
        RetrieveTapeRecoveryPointResponse EndRetrieveTapeRecoveryPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  ShutdownGateway

        /// <summary>
        /// This operation shuts down a gateway. To specify which gateway to shut down, use the
        /// Amazon Resource Name (ARN) of the gateway in the body of your request.
        /// 
        ///  
        /// <para>
        /// The operation shuts down the gateway service component running in the storage gateway's
        /// virtual machine (VM) and not the VM.
        /// </para>
        ///  
        /// <para>
        /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
        /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
        /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
        /// storage volumes, and there are no snapshots taken.
        /// </para>
        ///  
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndShutdownGateway
        ///         operation.</returns>
        IAsyncResult BeginShutdownGateway(ShutdownGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginShutdownGateway.</param>
        /// 
        /// <returns>Returns a  ShutdownGatewayResult from StorageGateway.</returns>
        ShutdownGatewayResponse EndShutdownGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  StartGateway

        /// <summary>
        /// This operation starts a gateway that you previously shut down (see <a>ShutdownGateway</a>).
        /// After the gateway starts, you can then make other API calls, your applications can
        /// read from or write to the gateway's storage volumes and you will be able to take snapshot
        /// backups.
        /// 
        ///  
        /// <para>
        /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        StartGatewayResponse StartGateway(StartGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGateway
        ///         operation.</returns>
        IAsyncResult BeginStartGateway(StartGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGateway.</param>
        /// 
        /// <returns>Returns a  StartGatewayResult from StorageGateway.</returns>
        StartGatewayResponse EndStartGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBandwidthRateLimit

        /// <summary>
        /// This operation updates the bandwidth rate limits of a gateway. You can update both
        /// the upload and download bandwidth rate limit or specify only one of the two. If you
        /// don't set a bandwidth rate limit, the existing rate limit remains.
        /// 
        ///  
        /// <para>
        /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
        /// the gateway does not have any limitations on its bandwidth usage and could potentially
        /// use the maximum available bandwidth.
        /// </para>
        ///  
        /// <para>
        /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBandwidthRateLimit
        ///         operation.</returns>
        IAsyncResult BeginUpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  UpdateBandwidthRateLimitResult from StorageGateway.</returns>
        UpdateBandwidthRateLimitResponse EndUpdateBandwidthRateLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChapCredentials

        /// <summary>
        /// This operation updates the Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// for a specified iSCSI target. By default, a gateway does not have CHAP enabled; however,
        /// for added security, you might use it.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChapCredentials
        ///         operation.</returns>
        IAsyncResult BeginUpdateChapCredentials(UpdateChapCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChapCredentials.</param>
        /// 
        /// <returns>Returns a  UpdateChapCredentialsResult from StorageGateway.</returns>
        UpdateChapCredentialsResponse EndUpdateChapCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGatewayInformation

        /// <summary>
        /// This operation updates a gateway's metadata, which includes the gateway's name and
        /// time zone. To specify which gateway to update, use the Amazon Resource Name (ARN)
        /// of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayInformation
        ///         operation.</returns>
        IAsyncResult BeginUpdateGatewayInformation(UpdateGatewayInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayInformation.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayInformationResult from StorageGateway.</returns>
        UpdateGatewayInformationResponse EndUpdateGatewayInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGatewaySoftwareNow

        /// <summary>
        /// This operation updates the gateway virtual machine (VM) software. The request immediately
        /// triggers the software update. 
        /// 
        ///  <important>A software update forces a system restart of your gateway. You can minimize
        /// the chance of any disruption to your applications by increasing your iSCSI Initiators'
        /// timeouts. For more information about increasing iSCSI Initiator timeouts for Windows
        /// and Linux, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// Your Windows iSCSI Settings</a> and <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// Your Linux iSCSI Settings</a>, respectively.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewaySoftwareNow
        ///         operation.</returns>
        IAsyncResult BeginUpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewaySoftwareNow.</param>
        /// 
        /// <returns>Returns a  UpdateGatewaySoftwareNowResult from StorageGateway.</returns>
        UpdateGatewaySoftwareNowResponse EndUpdateGatewaySoftwareNow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMaintenanceStartTime

        /// <summary>
        /// This operation updates a gateway's weekly maintenance start time information, including
        /// day and time of the week. The maintenance time is the time in your gateway's time
        /// zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceStartTime
        ///         operation.</returns>
        IAsyncResult BeginUpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceStartTimeResult from StorageGateway.</returns>
        UpdateMaintenanceStartTimeResponse EndUpdateMaintenanceStartTime(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSnapshotSchedule

        /// <summary>
        /// This operation updates a snapshot schedule configured for a gateway volume.
        /// 
        ///  
        /// <para>
        /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
        /// time of the volume. You can use this API to change the snapshot schedule configured
        /// for the volume.
        /// </para>
        ///  
        /// <para>
        /// In the request you must identify the gateway volume whose snapshot schedule you want
        /// to update, and the schedule information, including when you want the snapshot to begin
        /// on a day and the frequency (in hours) of snapshots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error has occurred during the request. See the error and message
        /// fields for more information.
        /// </exception>
        /// <exception cref="InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// See the error and message fields for more information.
        /// </exception>
        UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshotSchedule
        ///         operation.</returns>
        IAsyncResult BeginUpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotScheduleResult from StorageGateway.</returns>
        UpdateSnapshotScheduleResponse EndUpdateSnapshotSchedule(IAsyncResult asyncResult);

        #endregion
        
    }
}