# Nginx

## Debian 9 Stretch

- File: /etc/nginx/nginx.conf
  ```
  include /etc/nginx/conf.d/*.conf;
  ```

- File: /etc/nginx/conf.d/default.conf
  ```
  server {
      listen       80;
      server_name  localhost;

    ```
    ```
      location / {
          root   /usr/share/nginx/html;
          index  index.html index.htm;
      }
  ```


  - File: /etc/nginx/conf.d/nginxdemos.conf
    ```
    server {
           listen           80;
           server_name      nginxdemo.com www.nginxdemo.com;
           root             /home/username/nginxdemos/nginxdemo.com;

           location         /       {
                                            index index.htm index.html;
                                    }
    }

    server {
           listen           80;
           server_name      nginxdemo2.com www.nginxdemo2.com;
           root             /home/username/nginxdemos/nginxdemo2.com;

           location         /       {
                                            index index.htm index.html;
                                    }
    }

    server {
           listen           80;
           server_name      nginxdemo3.com www.nginxdemo3.com;
           root             /home/username/nginxdemos/nginxdemo3.com;

           location         /       {
                                            index index.htm index.html;
                                    }
    }
    ```


## Browser in Windows 10:

  - File: C:\Windows\System32\drivers\etc\hosts
    ```
    192.168.213.9		debian9server
    192.168.213.9		nginxdemo.com
    192.168.213.9		nginxdemo2.com
    192.168.213.9		nginxdemo3.com
    ```

  - Browse:
      ```
      http://debian9server
      ```
      ```
      http://nginxdemo.com
      ```
      ```
      http://nginxdemo2.com
      ```
      ```
      http://nginxdemo3.com
      ```
