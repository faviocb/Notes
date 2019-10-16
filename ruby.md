# Ruby

## Ubuntu 15.04

### RVM

```
$ gpg --keyserver hkp://keys.gnupg.net --recv-keys 409B6B1796C275462A1703113804BB82D39DC0E3

$ \curl -sSL https://get.rvm.io | bash -s stable --ruby

$ source /home/undertaker/.rvm/scripts/rvm

$ rvm install 2.1

```

In gnome-terminal menu:

- Select ```Edit - Profile Preferences - Command```
- Tick ```Run command as a login shell```

- Close gnome-terminal and open a new one.

```
$ rvm use 2.1

$ ruby --version
```

## Source

http://rvm.io/rvm/install

https://rvm.io/integration/gnome-terminal
