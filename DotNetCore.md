# DotNetCore

## Disable Telemetry in GNU/Linux for all users

- Edit file ```/etc/environment```

- Add this new  line ``` DOTNET_CLI_TELEMETRY_OPTOUT="true"```

- Reboot

- Confirm by ```echo $DOTNET_CLI_TELEMETRY_OPTOUT```


## Installer output

```
This software may collect information about you and your use of the software, and send that to Microsoft.
Please visit http://aka.ms/dotnet-cli-eula for more information.
Welcome to .NET Core!
---------------------
Learn more about .NET Core @ https://aka.ms/dotnet-docs. Use dotnet --help to see available commands or go to https://aka.ms/dotnet-cli-docs.

.NET Core Tools Telemetry
--------------
The .NET Core Tools include a telemetry feature that collects usage information. It is important that the .NET Team understands how the tools are being used so that we can improve them.

The data collected is anonymous and will be published in an aggregated form for use by both Microsoft and community engineers under the Creative Commons Attribution License.

The .NET Core Tools telemetry feature is enabled by default. You can opt-out of the telemetry feature by setting an environment variable DOTNET_CLI_TELEMETRY_OPTOUT (for example, 'export' on macOS/Linux, 'set' on Windows) to true (for example, 'true', 1). You can read more about .NET Core tools telemetry at https://aka.ms/dotnet-cli-telemetry.

Installation Note
--------------
A command will be run during the install process that will improve project restore speed and enable offline access. It will take up to a minute to complete.
Processing triggers for libc-bin (2.27-3) ...

```