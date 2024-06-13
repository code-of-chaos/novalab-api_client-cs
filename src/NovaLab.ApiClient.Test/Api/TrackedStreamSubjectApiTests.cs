/*
 * NovaLab.API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using NovaLab.ApiClient.Api;
using System;
using Xunit;

// uncomment below to import models
//using NovaLab.ApiClient.Model;

namespace NovaLab.ApiClient.Test.Api;

/// <summary>
///     Class for testing TrackedStreamSubjectApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class TrackedStreamSubjectApiTests : IDisposable {
    private TrackedStreamSubjectApi _instance;

    public TrackedStreamSubjectApiTests() {
        _instance = new TrackedStreamSubjectApi();
    }

    public void Dispose() {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of TrackedStreamSubjectApi
    /// </summary>
    [Fact]
    public void InstanceTest() {
        // TODO uncomment below to test 'IsType' TrackedStreamSubjectApi
        //Assert.IsType<TrackedStreamSubjectApi>(instance);
    }

    /// <summary>
    ///     Test ApiTwitchTrackedStreamSubjectGet
    /// </summary>
    [Fact]
    public void ApiTwitchTrackedStreamSubjectGetTest() {
        // TODO uncomment below to test the method and replace null with proper value
        //Guid? userId = null;
        //var response = instance.ApiTwitchTrackedStreamSubjectGet(userId);
        //Assert.IsType<TrackedStreamSubjectDtoIApiResult>(response);
    }

    /// <summary>
    ///     Test ApiTwitchTrackedStreamSubjectPost
    /// </summary>
    [Fact]
    public void ApiTwitchTrackedStreamSubjectPostTest() {
        // TODO uncomment below to test the method and replace null with proper value
        //TrackedStreamSubjectDtoPost? trackedStreamSubjectDtoPost = null;
        //var response = instance.ApiTwitchTrackedStreamSubjectPost(trackedStreamSubjectDtoPost);
        //Assert.IsType<TrackedStreamSubjectDtoIApiResult>(response);
    }
}