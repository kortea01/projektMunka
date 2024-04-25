clone the repository
`git clone ...`

go to Backend folder
`cd Backend`

init the composer project
`composer install`

localize: 
create a `.env` file with database credentials :

** ADMIN_EMAIL is important a default administrator will be seeded with this email address and the password 'Passw0rd'

```
...
APP_NAME=BellaItalia
APP_ENV=local
APP_KEY=base64:f7eoTC+cmAv/83TD24KZkTVdf8Oy4STMlNsn8Lyow8g=
APP_DEBUG=true
APP_URL=http://localhost
ADMIN_EMAIL=admin@bellaitalia.com


LOG_CHANNEL=stack
LOG_DEPRECATIONS_CHANNEL=null
LOG_LEVEL=debug

DB_CONNECTION=mysql
DB_HOST=127.0.0.1
DB_PORT=3306
DB_DATABASE=bellaitalia
DB_USERNAME=bellaitalia
DB_PASSWORD=Passw0rd
...
```

`php artisan migrate:fresh --seed`
