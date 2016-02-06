# Samba

## Server

```
sudo  apt-get install libcups2 samba samba-common cups
sudo smbpasswd -a <username>
```

## share folder (with authentication)

Add the following at the end of ```/etc/samba/smb.conf```

```
[MY-SHARED-FOLDER]
path = /home/hbk/shared-folder
available = yes
valid users = <username>
read only = no
browsable = yes
public = yes
writable = yes
```

## share folder (without authentication & write permissions)

to make a folder 100% public:

```
mkdir /home/public
chmod -R 777 /home/public
```

```
[public]
    path = /home/public
    public = yes
    guest ok = yes
    writable = yes
    printable = no
```


## test 


```
sudo apt-get install cifs-utils
```

```
sudo testparm
```


## Client Windows


Open shared folder:

```
\\192.168.213.9\shared-folder
```

Provide credentials:
```
username: 192.168.213.9\<username>
password: <password>
```




* * *
### Source

https://www.howtoforge.com/tutorial/debian-samba-server/
http://linux.alanstudio.hk/samba_public.htm
