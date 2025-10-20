# RealTimeToolkit.NET

**Cross-version SignalR Toolkit** — one NuGet package to enable real-time communication in **.NET 8, .NET 7, and .NET Framework (4.7.2 / 4.5.2)**.

## ✨ Features
- Broadcast, user, and group messaging
- Works in both ASP.NET Core & ASP.NET MVC
- Connection tracking per user
- Easy dependency injection support
- Unified API for modern and legacy SignalR

---

## 🚀 Installation

```bash
dotnet add package RealTimeToolkit.NET


🧩 Setup (for .NET 8 / .NET 7)

Program.cs

builder.Services.AddSignalR();
builder.Services.AddRealTimeToolkit();

var app = builder.Build();
app.MapHub<NotificationHub>("/hub/notify");
app.Run();


Usage

public class NotifyController : ControllerBase
{
    private readonly MessageBus _bus;

    public NotifyController(MessageBus bus)
    {
        _bus = bus;
    }

    [HttpPost("broadcast")]
    public async Task<IActionResult> Broadcast([FromBody] string message)
    {
        await _bus.BroadcastAsync("receiveMessage", message);
        return Ok();
    }
}


Client (JavaScript)

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub/notify")
    .build();

connection.on("receiveMessage", msg => console.log("📡", msg));
connection.start();

🧩 Setup (for .NET Framework 4.7.2 / 4.5.2)

Startup.cs

using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(MyApp.Startup))]
namespace MyApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}


Usage

var bus = new MessageBus();
bus.Broadcast("receiveMessage", "Hello from .NET Framework!");