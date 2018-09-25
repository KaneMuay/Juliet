# README #

## Core API ##
https://github.com/KaneMuay/Juliet-Unity-Web-Request-Core

## Juliet-Unity-Web-Request-API
*Juliet-Unity-Web-Request-API is a Unity3D plugin for request API data with supporting REST API

## Support Platofrm ##
* Android
* iOS
* PC Standalone

## How do I get set up? ##
1. Add a DLL file to Unity Project

## Unity Version Support ##
* 5.xx and above version
* Run on .NET 4.6

## How To Use ##

### Create Juliet instance ###
```csharp
  _juliet = new Juliet(DebugMode.Enable);
```
### Set header request ###
![Screenshot](https://www.picz.in.th/images/2018/09/25/fFX0ja.png)

### Set optional header request ###
```csharp
  JulietConfigure.Instance.SetOptionalKeyHeader("Access-Token", "User-Token");
  JulietConfigure.Instance.SetOptionalValueHeader(accessToken, id);
  JulietConfigure.Instance.UpdateHeader();
```

### Calling API Login ###
```csharp
   _juliet.Request.Login()
     .SetURL("https://api-server.com/auth/login", MethodType.POST)
     .SetUsername("username", request.username)
     .SetPassword("password", request.password)
     .SetEventAttribute("refreshToken", request.refreshToken)
     .Send(OnLogin, OnLoginFailed);
```

### Calling API Request Data ###
```csharp
   _juliet.Request.Common()
     .SetURL("https://api-server.com/characters/{0}", MethodType.GET, characterId)
     .Send(OnRequestCharacter, FailCallback ?? OnRequestFailed);
```

### Calling API Request Texture
```csharp
    _juliet.Request.Texture()
      .SetURL("https://s1.postimg.org/9dmeg5tyf3/image.png")
      .Send(OnGetTexture, OnRequestFailed);
```

### Checking Response ###

Data will return json string format, you can serialize json format to object class or return Texture
```csharp
   public void OnRequestFailed(string result)
    {
        ResponseMessage response = JsonUtility.FromJson<ResponseMessage>(result);
    }
```

```csharp
   public void OnGetTexture(Texture texture)
    {
        // TODO somthing on texture
    }
```

### Warning ###
at currently still not support PATCH method, it will be update on next version.

## License
Juliet-Unity-Web-Request-API is licensed under the MIT license:
www.opensource.org/licenses/MIT

## Copyright
Copyright (c) 2017 Garvil Villadiego.
