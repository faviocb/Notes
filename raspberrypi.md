# Raspberry pi

## rename hostname

Edit last line of  /etc/hosts

```
127.0.0.1	<new-hostname>

```

Edit /etc/hostname

```
<new-hostname>
```


then, commit changes

```
$ sudo /etc/init.d/hostname.sh
```

and reboot:

```
sudo reboot
```


* * *
### Source

http://www.howtogeek.com/167195/how-to-change-your-raspberry-pi-or-other-linux-devices-hostname/
