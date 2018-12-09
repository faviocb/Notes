# Filepath:

```
/home/<username>/.local/share/applications/icecat.desktop
```

# Content

```
[Desktop Entry]
Version=1.0
Name=Icecar
Comment=Web Browser
GenericName=Web Browser
X-GNOME-FullName=Icecat
Exec=/home/<username>/.local/share/applications/icecat/icecat -private %u
Terminal=false
X-MultipleArgs=false
Type=Application
Icon=/home/<username>/.local/share/applications/icecat/browser/chrome/icons/default/default128.png
Categories=Network;WebBrowser;
MimeType=text/html;text/xml;application/xhtml+xml;application/xml;application/vnd.mozilla.xul+xml;application/rss+xml;application/rdf+xml;image/gif;image/jpeg;image/png;x-scheme-handler/http;x-scheme-handler/https;
StartupWMClass=Icecat
StartupNotify=true
Name[en_AU]=icecat
Actions=new-window;new-private-window;

[Desktop Action new-window]
Name=New Window
Exec=/home/<username>/.local/share/applications/icecat/icecat --new-window %u

[Desktop Action new-private-window]
Name=New Private Windows
Exec=/home/<username>/.local/share/applications/icecat/icecat --private-window %u
```
