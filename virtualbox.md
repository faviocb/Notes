# Virtualbox

## Ubuntu 15.04

### Problem 1:
Error when running ```VBoxManage hostonlyif create```

```
WARNING: The vboxdrv kernel module is not loaded. Either there is no module
         available for the current kernel (3.19.0-23-generic) or it failed to
         load. Please recompile the kernel module and install it by

           sudo /etc/init.d/vboxdrv setup

         You will not be able to start VMs until this problem is fixed.
0%...
Progress state: NS_ERROR_FAILURE
```

Solution:

```
sudo /etc/init.d/vboxdrv setup
```


### Problem 2:
Error when trying to install guest operating system (ubuntu server 15.04)
```This kernel requires the following feature not present on the CPU: pae```
Solution:

Select menu:
```
settings - system - processor
```
Tick checkbox:
```
Enable PAE/NX
```



