# .NET Foundation Project Application

## 🧩 Project Name

**RealTimeToolkit.NET**

---

## 📘 Project Description

**RealTimeToolkit.NET** is a high-performance, real-time communication toolkit built on **.NET**.
It provides an extensible foundation for **real-time messaging, live data synchronization, and distributed event handling** between servers and clients.

The toolkit is designed for developers building applications such as:

* Dashboards with live metrics
* Real-time monitoring tools
* Collaborative or streaming applications
* IoT message relays and server push architectures

---

## 🌐 Project Repository

**GitHub:** [https://github.com/khujrat17/RealTimeToolkit](https://github.com/khujrat17/RealTimeToolkit)

---

## ⚙️ Technical Overview

* **Framework:** .NET 8+
* **Languages:** C#
* **Core Features:**

  * SignalR integration for real-time messaging
  * Lightweight event dispatch system
  * Plug-in support for different transports (WebSockets, gRPC, etc.)
  * Thread-safe async operations
  * Extendable for cloud scalability
* **License:** MIT License (`LICENSE` file in repository root)

---

## 👥 Committers

| Full Name             | GitHub ID                                  | Employer / Affiliation | Role                       |
| --------------------- | ------------------------------------------ | ---------------------- | -------------------------- |
| **Khujrat S. Shaikh** | [@khujrat17](https://github.com/khujrat17) | Independent Developer  | Project Owner / Maintainer |

---

## ✍️ Project Transfer Signatories

| Full Name             | Email                                                       | Role                     |
| --------------------- | ----------------------------------------------------------- | ------------------------ |
| **Khujrat S. Shaikh** | *[[your.email@example.com](mailto:khujratshaikh1284@example.com)]* | Sole Author & Maintainer |

> **Note:** As the sole author and maintainer of this code, my single signature is sufficient for the transfer agreement.

---

## ⚖️ Selected Project Transfer Agreement Model

**Model:** Contribution Model

**Reason:**
The project is independently developed and maintained by **Khujrat S. Shaikh**.
The **Contribution Model** allows the author to retain copyright while granting the .NET Foundation full rights to use, distribute, and support the project under open-source governance.

---

## 🧑‍💻 Governance Model

* **Code Change Process:**
  Contributors propose changes through GitHub Pull Requests (PRs).
  Each PR is reviewed by the project maintainer(s) for code quality, architecture alignment, and adherence to contribution guidelines.

* **Review Process:**
  Reviews include code validation, discussion via GitHub comments, and, when necessary, minor revisions before merging.

* **Decision Making:**
  Acceptance decisions are made by the project maintainer (currently the owner).
  In the future, governance may expand to include trusted contributors.

* **New Committers:**
  Frequent, high-quality contributors who consistently add value to the project may be invited as committers after review and consensus by existing maintainers.

---

## 🪪 License

**MIT License** (located in `/LICENSE` file)

---

## 🧠 Project Status

* Active development
* Accepting contributions
* Actively maintained and open for .NET community adoption

---

## 📨 Contact

**Name:** Khujrat S. Shaikh
**GitHub:** [@khujrat17](https://github.com/khujrat17)
**Email:** *[[khujratshaikh1284@example.com](mailto:khujratshaikh1284@example.com)]*
**Affiliation:** Independent Developer


🗂 Repository Layout

The RealTimeToolkit.NET repository already follows a clean and modular structure compatible with .NET Foundation guidance.

Current structure:

/RealTimeToolkit.NET
│
├── /src/                  # Source code for main library
│   ├── RealTimeToolkit/   # Core SignalR toolkit
│   └── RealTimeToolkit.Tests/  # Unit and integration tests
│
├── /samples/              # Example projects demonstrating usage
│   ├── AspNetCoreDemo/
│   └── FrameworkDemo/
│
├── /docs/                 # API and setup documentation
│
├── /build/                # Build scripts and CI/CD configurations
│
├── LICENSE                # MIT License
├── README.md              # Project overview and setup guide
└── CONTRIBUTING.md        # Contribution and PR guidelines

Planned adjustments for .NET Foundation alignment:

Add a CODE_OF_CONDUCT.md file referencing the .NET Foundation Code of Conduct.

Add a GOVERNANCE.md to formalize maintainer and contributor roles.

Integrate .NET Foundation CLA automation for contributor license agreements.

Update build scripts to support GitHub Actions with Foundation-recommended workflows.

Once transferred, the repository will remain the master source, with all development, bug fixes, and releases performed through GitHub Pull Requests (PRs), consistent with the .NET Foundation open-source governance model.

🧩 5. Eligibility Criteria

✅ The project meets all eligibility requirements of the .NET Foundation:

Criteria	Status	Notes
Built on the .NET platform / creates value in the .NET ecosystem	✅	Designed for real-time SignalR integration across .NET 8 / 7 / Framework
Produces open-source code for free public use	✅	Published under MIT License
Publicly accessible repository	✅	https://github.com/khujrat17/RealTimeToolkit
Contains build scripts for reproducible builds	✅	build/ folder includes scripts for packaging via dotnet pack
Uses reproducible build settings	✅	Uses deterministic compilation in project settings
Uses Source Link	✅	Configured in .csproj for NuGet package debugging
Uses embedded PDBs or publishes symbol packages	✅	Configured to include portable PDBs for NuGet
Code signing setup	⚙️ Planned	Will integrate with .NET Foundation OSS signing service
2FA for committers	✅	GitHub account secured with 2FA
Dependencies under permissive open source licenses	✅	Only depends on Microsoft’s official SignalR packages
Committers bound by CLA / willing to adopt Foundation CLA	✅	Will adopt .NET Foundation CLA on acceptance
Copyright ownership clearly defined	✅	Owned by Khujrat S. Shaikh, documented in LICENSE
Public issue tracker	✅	GitHub Issues enabled and actively maintained
Published Security Policy	⚙️ Planned	Will add SECURITY.md following Foundation template
Home page / README provided	✅	Detailed README with examples and installation
Public communication channel	✅	GitHub Discussions (to be activated post-acceptance)
Public documentation access	✅	/docs folder and README available for contributors
💡 6. Why are you applying to add your project to the Foundation?

I am applying to add RealTimeToolkit.NET to the .NET Foundation because I want the project to become part of the official open-source ecosystem that strengthens real-time development in .NET.

The goals of joining are:

To ensure long-term sustainability and community-driven governance.

To increase visibility and encourage collaboration from other .NET developers.

To benefit from the .NET Foundation’s build and signing infrastructure for secure NuGet releases.

To align the project with best practices in open-source governance, transparency, and contribution standards.

In short: joining the .NET Foundation will help RealTimeToolkit.NET grow from an independent developer tool into a trusted, community-maintained part of the .NET ecosystem.

🖥️ 7. Infrastructure Requirements
Requirement	Description
Build Servers	Currently uses GitHub Actions for automated CI/CD builds and NuGet packaging. Will integrate with .NET Foundation’s build services upon onboarding.
Hosting	No web hosting needed; source and releases are hosted on GitHub and NuGet.org.
SSL Certificates	Not required. The project does not serve web traffic directly.
Code Signing	Will integrate with .NET Foundation’s Authenticode and OSS signing services for NuGet package verification.
Other Requirements	None. The project’s existing infrastructure is fully compatible with Foundation workflows.
📝 8. Additional Notes

RealTimeToolkit.NET fills a unique role within the .NET ecosystem by providing a cross-version SignalR abstraction layer that unifies real-time communication across .NET 8, .NET 7, and legacy .NET Framework (4.7.2 / 4.5.2).

While other libraries (such as the official Microsoft.AspNetCore.SignalR and SignalR.Client) focus primarily on a single runtime generation, RealTimeToolkit.NET is designed to bridge compatibility between modern and legacy applications—allowing hybrid systems and enterprises to gradually migrate without losing real-time capabilities.

🔍 Differentiation

Unified API – same MessageBus interface for both ASP.NET Core and classic MVC.

Backward Compatibility – supports organizations still maintaining .NET Framework systems.

Lightweight & Extensible – small footprint with optional dependency injection integration.

Community-Friendly – easy for contributors to extend transport layers or add middleware.

⚙️ Potential Early-Stage Support Areas

NuGet Code Signing – assistance integrating with the .NET Foundation’s OSS signing pipeline.

Documentation & Samples – guidance on best practices for multi-targeted SDK documentation.

Community Growth – mentoring and visibility to attract contributors and testers across .NET versions.

The project aligns strongly with the .NET Foundation’s mission to advance open-source development, interoperability, and modernization within the .NET platform.


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