using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using JulietUtil.Master;
using JulietUtil.API;

public class TestJuliet : MonoBehaviour
{
    string TAG = "Test Juliet";
    Juliet _juliet;

    private void Start()
    {
        _juliet = new Juliet(DebugMode.Enable);
    }

    public void AddOptionalHeader()
    {
        JulietConfigure.Instance.SetOptionalKeyHeader("key1", "key2", "key3"); 
        JulietConfigure.Instance.SetOptionalValueHeader("key1-value1", "key2-value2", "key3-value3");
    }

    public void Login()
    {
        _juliet.Request.LoginRequest()
            .SetURL("www.google.co.th", MethodType.POST)
            .SetUsername("username")
            .SetPassword("password")
            .Send(OnLogin, OnLoginFailed);
    }

    public void LoadCharacter()
    {
        _juliet.Request.CommonRequest()
            .SetURL("www.google.co.th", MethodType.GET)
            .Send(OnLoadCharacter, OnRequestFailed);
    }

    private void OnLogin(string result)
    {
        JulietLogger.Info(TAG, result);
    }

    private void OnLoginFailed(string result)
    {
        JulietLogger.Info(TAG, result);
    }

    private void OnLoadCharacter(string result)
    {
        JulietLogger.Info(TAG, result);
    }

    private void OnRequestFailed(string result)
    {
        JulietLogger.Info(TAG, result);
    }
}