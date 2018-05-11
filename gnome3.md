# Gnome 3

## Desktop files

### Add Firefox Quantum (private mode) on Debian Stretch (for a user)

1. Download and unzip Firefox Quantum.
2. Add ```.desktop``` file, for example:

Add   ```firefox59.desktop``` file to ```~/.local/share/applications```


Here is the file content **:

```
[Desktop Entry]
Name=Firefox 59
Comment=Web Browser
GenericName=Web Browser
X-GNOME-FullName=Firefox 59 Web Browser
Exec=/home/<username>/.local/share/applications/firefox-59.0.2/firefox/firefox -private %u
Terminal=false
X-MultipleArgs=false
Type=Application
Icon=/home/<username>/.local/share/applications/firefox-59.0.2/firefox/browser/chrome/icons/default/default128.png
Categories=Network;WebBrowser;
MimeType=text/html;text/xml;application/xhtml+xml;application/xml;application/vnd.mozilla.xul+xml;application/rss+xml;application/rdf+xml;image/gif;image/jpeg;image/png;x-scheme-handler/http;x-scheme-handler/https;
StartupWMClass=Firefox
StartupNotify=true
```

** Replace <username> with the user's home directory

