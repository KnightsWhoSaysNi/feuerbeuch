# Fit For Business

1. `$ cd web-project`
2. `$ compser install`
3. Edit DB credentials in app/config/config.local.neon
4. `$ php www/index.php migrations:continue`
5. setup cron to run `$ php www/index.php cron:checkUserExpirationsCommand` once a day

## mango-cli, ok?

Yo man, do you have `mango-cli` installed globally?

You should: `npm install -g mango-cli`

## First install dependencies

Do: `mango install`.

Oh, that's it? Run `mango dev` and your browser should start up.


## Administration:

url:	www/admin

mail:	admin@mangoweb.cz

pw:		liq8zr