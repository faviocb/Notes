## Android studio on Debian Strecth


### Fix Emulator issue "unable to load driver: i965_dri.so"


Start the emulator from command line and use the system libs:

```
cd /home/<username>/Android/Sdk/emulator

./emulator -avd Nexus_5X_API_24 -use-system-libs
``` 
 

 * ```Nexus_5X_API_24```  is an example of the emulator name. 
 You can find it in Android Studio -> Tools -> AVD Manager.
 Then right click the device, and select "View Details".
 The name is displayed there.




Sources:

https://www.tompurl.com/Fixing_Android_libgl_Errors.html

https://bbs.archlinux.org/viewtopic.php?pid=1646115#p1646115
