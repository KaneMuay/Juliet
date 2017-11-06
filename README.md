# README #

Juliet is a Unity3D plugin for connect to API Server.

## Support Device ##
* Android
* iOS
* PC Standalone

## How do I get set up? ##
* Pull the project
* Open by IDE(such as Microsoft Visual Studio)

## Unity Version Support ##
* 5.xx and above version

## How To Use ##

### Create Juliet instance ###
```csharp
  _juliet = new Juliet(DebugMode.Enable);
```

### Set optional header request ###
```csharp
  JulietConfigure.Instance.SetOptionalKeyHeader("X-Access-Token", "X-User");
  JulietConfigure.Instance.SetOptionalValueHeader(accessToken, id);
  JulietConfigure.Instance.UpdateHeader();
```

### Calling API Login ###
```csharp
   _juliet.Request.LoginRequest()
     .SetURL("https://api-server.com/auth/login", MethodType.POST)
     .SetUsername(request.username)
     .SetPassword(request.password)
     .SetRefreshToken(request.refreshToken)
     .Send(OnLogin, OnLoginFailed);
```

### Calling API Request Data ###
```csharp
   _juliet.Request.CommonRequest()
     .SetURL("https://api-server.com/characters/{0}", MethodType.GET, characterId)
     .Send(OnRequestCharacter, FailCallback ?? OnRequestFailed);
```

### Checking Response ###

Data will return json string format, you can serialize json format to object class.
```csharp
   public void OnRequestFailed(string result)
    {
        ResponseMessage response = JsonUtility.FromJson<ResponseMessage>(result);
    }
```

## License
Juliet-Unity-Web-Request-API is licensed under the MIT license:
www.opensource.org/licenses/MIT

## Copyright
Copyright (c) 2017 Garvil Villadiego.