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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QuickSight.Model;

namespace Amazon.QuickSight
{
    /// <summary>
    /// Interface for accessing QuickSight
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless, cloud business intelligence service
    /// that makes it easy to extend data and insights to every user in your organization.
    /// This API interface reference contains documentation for a programming interface that
    /// you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial interface IAmazonQuickSight : IAmazonService, IDisposable
    {

        
        #region  CreateGroup


        /// <summary>
        /// Creates an Amazon QuickSight group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group --aws-account-id=111122223333 --namespace=default
        /// --group-name="Sales-Management" --description="Sales Management - Forecasting" </code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates an Amazon QuickSight group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group --aws-account-id=111122223333 --namespace=default
        /// --group-name="Sales-Management" --description="Sales Management - Forecasting" </code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGroupMembership


        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group member object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --member-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request);



        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group member object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --member-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Removes a user group from Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-group-name=Sales-Management </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);



        /// <summary>
        /// Removes a user group from Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-group-name=Sales-Management </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroupMembership


        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales-Management --member-name=Charlie </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request);



        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales-Management --member-name=Charlie </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the AWS
        /// Identity and Access Management (IAM) user or role that's making the call. The IAM
        /// user isn't deleted as a result of this call. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;
        /// </i> </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the AWS
        /// Identity and Access Management (IAM) user or role that's making the call. The IAM
        /// user isn't deleted as a result of this call. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;
        /// </i> </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserByPrincipalId


        /// <summary>
        /// Deletes a user after locating the user by its principal ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        DeleteUserByPrincipalIdResponse DeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request);



        /// <summary>
        /// Deletes a user after locating the user by its principal ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        Task<DeleteUserByPrincipalIdResponse> DeleteUserByPrincipalIdAsync(DeleteUserByPrincipalIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-group -\-aws-account-id=11112222333 -\-namespace=default
        /// -\-group-name=Sales </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);



        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-group -\-aws-account-id=11112222333 -\-namespace=default
        /// -\-group-name=Sales </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about a user, given the user name. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon Resource Name (ARN),
        /// AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);



        /// <summary>
        /// Returns information about a user, given the user name. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon Resource Name (ARN),
        /// AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDashboardEmbedUrl


        /// <summary>
        /// Generates a server-side embeddable URL and authorization code. Before this can work
        /// properly, first you need to configure the dashboards and user permissions. For more
        /// information, see <a href="https://docs.aws.amazon.com/en_us/quicksight/latest/user/embedding.html">
        /// Embedding Amazon QuickSight Dashboards</a>.
        /// 
        ///  
        /// <para>
        /// Currently, you can use <code>GetDashboardEmbedURL</code> only from the server, not
        /// from the user’s browser.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        /// Assume the role with permissions enabled for actions: <code>quickSight:RegisterUser</code>
        /// and <code>quicksight:GetDashboardEmbedURL</code>. You can use assume-role, assume-role-with-web-identity,
        /// or assume-role-with-saml. 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sts assume-role --role-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --role-session-name embeddingsession</code> 
        /// </para>
        ///  
        /// <para>
        /// If the user does not exist in QuickSight, register the user:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user --aws-account-id 111122223333 --namespace default
        /// --identity-type IAM --iam-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --user-role READER --session-name "embeddingsession" --email user123@example.com --region
        /// us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type IAM</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified is not on the allowlist. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified is not supported. Supported identity types include IAM
        /// and QUICKSIGHT.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user is not found. This error can happen in any operation that requires finding
        /// a user based on a provided user name, such as <code>DeleteUser</code>, <code>DescribeUser</code>,
        /// and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session is not valid. The session
        /// lifetime must be from 15 to 600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request);



        /// <summary>
        /// Generates a server-side embeddable URL and authorization code. Before this can work
        /// properly, first you need to configure the dashboards and user permissions. For more
        /// information, see <a href="https://docs.aws.amazon.com/en_us/quicksight/latest/user/embedding.html">
        /// Embedding Amazon QuickSight Dashboards</a>.
        /// 
        ///  
        /// <para>
        /// Currently, you can use <code>GetDashboardEmbedURL</code> only from the server, not
        /// from the user’s browser.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        /// Assume the role with permissions enabled for actions: <code>quickSight:RegisterUser</code>
        /// and <code>quicksight:GetDashboardEmbedURL</code>. You can use assume-role, assume-role-with-web-identity,
        /// or assume-role-with-saml. 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sts assume-role --role-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --role-session-name embeddingsession</code> 
        /// </para>
        ///  
        /// <para>
        /// If the user does not exist in QuickSight, register the user:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user --aws-account-id 111122223333 --namespace default
        /// --identity-type IAM --iam-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --user-role READER --session-name "embeddingsession" --email user123@example.com --region
        /// us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type IAM</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified is not on the allowlist. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified is not supported. Supported identity types include IAM
        /// and QUICKSIGHT.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user is not found. This error can happen in any operation that requires finding
        /// a user based on a provided user name, such as <code>DeleteUser</code>, <code>DescribeUser</code>,
        /// and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session is not valid. The session
        /// lifetime must be from 15 to 600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        Task<GetDashboardEmbedUrlResponse> GetDashboardEmbedUrlAsync(GetDashboardEmbedUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupMemberships


        /// <summary>
        /// Lists member users in a group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group member objects.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-group-memberships -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request);



        /// <summary>
        /// Lists member users in a group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group member objects.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-group-memberships -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists all user groups in Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/*</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-groups -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);



        /// <summary>
        /// Lists all user groups in Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/*</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-groups -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserGroups


        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a one or more group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-user-groups -\-user-name=Pat -\-aws-account-id=111122223333
        /// -\-namespace=default -\-region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request);



        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a one or more group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-user-groups -\-user-name=Pat -\-aws-account-id=111122223333
        /// -\-namespace=default -\-region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>*</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of user objects, containing each user's Amazon Resource Name
        /// (ARN), AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-users --aws-account-id=111122223333 --namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>*</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of user objects, containing each user's Amazon Resource Name
        /// (ARN), AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-users --aws-account-id=111122223333 --namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterUser


        /// <summary>
        /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
        /// and Access Management (IAM) identity or role specified in the request. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the Amazon Resource Name (ARN) for the IAM user or role,
        /// and the session name. 
        /// </para>
        ///  
        /// <para>
        /// The condition keys are <code>quicksight:IamArn</code> and <code>quicksight:SessionName</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-email=pat@example.com -\-identity-type=IAM -\-user-role=AUTHOR -\-iam-arn=arn:aws:iam::111122223333:user/Pat
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        RegisterUserResponse RegisterUser(RegisterUserRequest request);



        /// <summary>
        /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
        /// and Access Management (IAM) identity or role specified in the request. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the Amazon Resource Name (ARN) for the IAM user or role,
        /// and the session name. 
        /// </para>
        ///  
        /// <para>
        /// The condition keys are <code>quicksight:IamArn</code> and <code>quicksight:SessionName</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-email=pat@example.com -\-identity-type=IAM -\-user-role=AUTHOR -\-iam-arn=arn:aws:iam::111122223333:user/Pat
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Changes a group description. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-group --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --description="Sales BI Dashboards" </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);



        /// <summary>
        /// Changes a group description. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-group --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --description="Sales BI Dashboards" </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon QuickSight user name,
        /// email address, active or inactive status in Amazon QuickSight, Amazon QuickSight role,
        /// and Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-user --user-name=Pat --role=ADMIN --email=new_address@amazon.com
        /// --aws-account-id=111122223333 --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);



        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon QuickSight user name,
        /// email address, active or inactive status in Amazon QuickSight, Amazon QuickSight role,
        /// and Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-user --user-name=Pat --role=ADMIN --email=new_address@amazon.com
        /// --aws-account-id=111122223333 --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}