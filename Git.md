# Git configuration

## Common

```
$ git config --global user.name "gitusername"
$ git config --global user.email git@email.com
```
## GNU
```
$ git config --global core.autocrlf input
```

## Windows (cross-platform)
```
$ git config --global core.autocrlf true
```

### Windows only
```
$ git config --global core.autocrlf false
```

# Check settings
```
$ git config --list
```

# Cheat sheet (Thanks to Anatoly)

#### initialize local repo
```$ git init```

#### Connect to Remote Repo
```$ git remote add origin https://github.com/orgname/reponame.git```

#### Verify Maping Remote Repo
```$ git remote -v```

#### Clone Repo
```$ git clone https://github.com/orgname/reponame.git```

#### Add file from local folder
```$ git add Readme.txt```

#### Add all files from local folder
```$ git add .```

#### Add changes with a message 
```$ git commit -m "add text readme"```

#### Upload all changes to repo (TFVC Check-in) 
```$ git push```

#### Delete the last 2 Commits   
```$ git reset --hard  HEAD^^```

#### Refresh 
```$ git push -f origin master```

#### update all changes to local repo 
```$ git pull```


