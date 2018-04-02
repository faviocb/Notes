# Postgresql

## Postgreqsl 9.6 on Raspbian (stretch)




### Local Postgresql connection

```
sudo -u postgres psql
```


### Find out configuration files folder

```
select name, setting from pg_settings where category = 'File Locations';
```

### Allow postgresql server listen to remote clients:

Set the following setting in /etc/postgresql/9.6/main/postgresql.conf


```
listen_addresses = '*'
```

* This might be insecure, because it listens to all addresses.

### Allow remote clients authenticate with password in server

Add following line as first record of  /etc/postgresql/9.6/main/pg_hba.conf

```
host       all             <postgresql-username>   0.0.0.0/0   password
```

* This might be insecure, because it allows all addresses to authenticate.

### Postgreqsl connection from remote client

```
psql  -h <postgresq-server> -U <postgreqsl-username> -d <database-name>
```

Example:

```
psql  -h mydbserver -U businessuser -d businessdb
```


### SSH connection via remote Emacs to edit postgresql settings files

Note that only the user 'postgres' is the owner of the configuration files by default. That's why we use sudo after the SSH session is established.

```
emacs --find-file "/ssh:<ssh-username>@<ssh-servername>|sudo:postgres:/etc"
```
Example:

```
emacs --find-file "/ssh:johnconnor@myserver|sudo:postgres:/etc"
```
