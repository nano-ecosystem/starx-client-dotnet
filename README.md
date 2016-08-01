# Starx .Net client library

## Usage

```
StarXClient client = new StarXClient();
client.Init("127.0.0.1", 3250, () =>
{
  	Debug.Log("init client callback");
  	client.Connect((data) =>
  	{
    		Debug.Log("connect client callback");

    		// 服务器主动推送消息
    		client.On("OnServerNotify", (m) =>
    		{
    			Debug.Log("OnServerNotify: " + Encoding.UTF8.GetString(m));
    		});

    		// 服务器主动推送消息
    		client.On("OnServerNotify2", (m) =>
    		{
    			Debug.Log("OnServerNotify2: " + Encoding.UTF8.GetString(m));
    		});

    		// 请求gate服务器，LoginHandler.Login服务
    		client.Request("gate.LoginHandler.Login", Encoding.UTF8.GetBytes("login handler request test message"), (resp) =>
    		{
    			Debug.Log("gate.LoginHandler.Login response: " + Encoding.UTF8.GetString(resp));
    		});
    		// 通知gate服务器，LoginHandler.NotifyTest服务
    		client.Notify("gate.LoginHandler.NotifyTest", Encoding.UTF8.GetBytes("login handler notify test message"));

    		// 请求gate服务器，LoginHandler.TestRpc服务
    		client.Request("gate.LoginHandler.TestRpc", Encoding.UTF8.GetBytes("login handler TestRpc request test message"), (resp) =>
    		{
    			Debug.Log("gate.LoginHandler.TestRpc response: " + Encoding.UTF8.GetString(resp));
    		});

    		// 请求chat服务器，ChatHandler.Chating服务
    		client.Request("chat.ChatHandler.Chating", Encoding.UTF8.GetBytes("login handler request test message"), (resp) =>
    		{
    			Debug.Log("chat.ChatHandler.Chating response: " + Encoding.UTF8.GetString(resp));
    		});
    		// 通知chat服务器，ChatHandler.UserIsInputing服务
    		client.Notify("chat.ChatHandler.UserIsInputing", Encoding.UTF8.GetBytes("someone is inputing"));
  	});
});
```
