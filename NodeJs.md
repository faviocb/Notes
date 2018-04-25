# Node.js v0.12.7

## Ubuntu 15.04
```
$ curl --silent --location https://deb.nodesource.com/setup_0.12 | sudo bash -
$ sudo apt-get install --yes nodejs
```


## Windows 7

Update npm:
```
$ npm install npm -g
```

## Debian testing (Buster)

Install npm
```
sudo apt-get install npm
sudo npm install -g npm@next
```


## Debian Stretch (stable)

```
curl -sL https://deb.nodesource.com/setup_8.x | sudo -E bash -
sudo apt-get install -y nodejs
sudo apt-get install -y build-essential
```

Installer output:

```
## Run `sudo apt-get install -y nodejs` to install Node.js 8.x LTS Carbon and npm
## You may also need development tools to build native addons:
     sudo apt-get install gcc g++ make
## To install the Yarn package manager, run:
     curl -sL https://dl.yarnpkg.com/debian/pubkey.gpg | sudo apt-key add -
     echo "deb https://dl.yarnpkg.com/debian/ stable main" | sudo tee /etc/apt/sources.list.d/yarn.list
     sudo apt-get update && sudo apt-get install yarn

```


### Source
https://github.com/joyent/node/wiki/Installing-Node.js-via-package-manager
https://nodejs.org/en/download/package-manager/#debian-and-ubuntu-based-linux-distributions
https://nodejs.org/en/download/package-manager/
