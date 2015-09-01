# Encrytp Web.config

Run as administrator.


## To encrypt  connectionStrings

```
aspnet_regiis -pe "connectionStrings" -app "/MyWebApplication" -prov "RsaProtectedConfigurationProvider"
```

## To encrypt  mailSettings

For applications under the Default website

```
aspnet_regiis -pe "system.net/mailSettings/smtp" -app "/MyWebApplication" -prov "RsaProtectedConfigurationProvider"
```

For applications under other websites:

```
aspnet_regiis.exe -pe "system.net/mailSettings/smtp" -app "/OtherWebApplication" -site "5"   -prov "RsaProtectedConfigurationProvider"
```

To find out Site ID:

* Open IIS manager
* Right click website
* Select "Manage Website"
* Select "Advanced Settings ..."
* The ID property value is the Site ID

### Source

https://msdn.microsoft.com/en-us/library/zhhddkxy.aspx
