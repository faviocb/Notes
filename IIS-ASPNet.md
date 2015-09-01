# Encrytp Web.config


## To encrypt  connectionStrings

```
aspnet_regiis -pe "connectionStrings" -app "/MyWebApplication" -prov "RsaProtectedConfigurationProvider"
```

## To encrypt  mailSettings

```
aspnet_regiis -pe "system.net/mailSettings/smtp" -app "/MyWebApplication" -prov "RsaProtectedConfigurationProvider"
```


### Source

https://msdn.microsoft.com/en-us/library/zhhddkxy.aspx