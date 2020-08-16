#!/usr/bin/env bash
set -e
trap : TERM INT

if [ "$1" = 'sqlservr' ]; then
    echo "Starting SQL server and restoring database..."
    exec /opt/mssql/bin/sqlservr & /restore-db.sh

    exec tail -f /dev/null & wait # Do not exit
else
    exec "$@"
fi 