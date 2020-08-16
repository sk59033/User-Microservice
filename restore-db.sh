#!/bin/bash

# TODO: investigate how we can check that the DB is up and improve this quick workaround
echo "Waiting for the SQL Server to come up"
sleep 90s

echo "Restoring the VF_DEV_DSO database from the backup"
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P sa -Q 'RESTORE DATABASE VF_DEV_DSO FROM DISK = "/var/opt/mssql/backup/VF_DEV_DSO.Bak" WITH MOVE "VF_DEV_DSO" TO "/var/opt/mssql/CLEANUP_DB_DEV.mdf", MOVE "VF_DEV_DSO_log" TO "/var/opt/mssql/CLEANUP_DB_DEV.ldf"'
