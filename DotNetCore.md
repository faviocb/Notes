# DotNetCore

## Disable Telemetry in GNU/Linux for all users

- Edit file ```/etc/environment```

- Add this new  line ``` DOTNET_CLI_TELEMETRY_OPTOUT="true"```

- Reboot

- Confirm by ```echo $DOTNET_CLI_TELEMETRY_OPTOUT```


