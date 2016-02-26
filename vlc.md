# VLC CLI

Play mp3 file

```
vlc --intf  dummy  file:///home/musicfolder/my\ song.mp3
```

Play only audio mp4 file 

```
vlc --vout none --intf  dummy  file:///home/musicfolder/my\ video\ song.mp4
```

Play  m3u playlist  

```
vlc --vout none --intf  dummy  file:///home/musicfolder/myplaylist.m3u
```



Play  m3u playlist  randomly forever

```
vlc --vout none --intf  dummy -Z file:///home/musicfolder/myplaylist.m3u
```

Example playlist file "myplaylist.m3u"  (whole folder)

```
./rock/
```

Example playlist file "myplaylist.m3u"  (specific files)

```
./rock/my-song.mp4
./rock/other-song.mp4
```



## Source

http://www.wumpus-cave.net/2013/11/06/running-vlc-automatically-on-a-headless-raspberry-pi/

