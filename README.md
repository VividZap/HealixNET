# Healix.NET - Self-Healing SDK for .NET Apps

<img src="https://github.com/VividZap/HealixNET/files/Logo.svg" width="180" alt="Healix.NET Logo"/>
<img width="1280" height="1280" alt="Logo" src="https://github.com/user-attachments/assets/694890ac-da11-4d43-bd9b-6ae66025bba5" />


> **Healix.NET** empowers your .NET applications with automatic error recovery and resilience.  
> Plug-and-play SDK to detect, log, and heal from runtime failures.

---

## Features

- **Self-Healing SDK:** Recover from exceptions and service failures automatically.
- **Custom Healing Policies:** Retry, fallback, backup restore, and more.
- **Live Dashboard:** Monitor healing events, statistics, and manage policies in a WPF app.
- **Smart Logging:** Complete log of all healing attempts, with analytics.
- **Extensible:** Add new healing policies or integrate with external monitoring tools.
- **Open API:** Ready for any .NET platform.

---

## Getting Started

### 1. Install

```sh
dotnet add package HealixNET
```

### 2. Usage Example

```csharp
var manager = new SelfHealingManager();
manager.RegisterPolicy(new RetryPolicy(3));

int result = await manager.ExecuteWithHealing<int>(async () => {
    // Risky operation
    return 10 / 0;
}, "Division Test");
```

### 3. Dashboard

Use the WPF app to visualize healing events, manage policies, and see analytics.
<img width="884" height="594" alt="image" src="https://github.com/user-attachments/assets/8e8b85e9-7491-4200-aa60-d13b22d8f9d2" />

---

## License

MIT License (see LICENSE file for full details).

---

## Author

[VividZap](https://github.com/VividZap)
