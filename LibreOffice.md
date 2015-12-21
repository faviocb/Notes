# LibreOffice Calc

## Ubuntu 14.04


### Problem 1: Sheet name font size on LibreOffice Calc is too small



#### Solution:
```
$ cd /usr/share/themes/Ambiance/gtk-2.0/
$ sudo emacs gtkrc
```

Change

FROM:
```
GtkScrollbar::slider-width = 13
```

TO:
```
GtkScrollbar::slider-width = 25
```


## Source

http://askubuntu.com/questions/431723/libre-office-calc-small-sheet-toolbar
