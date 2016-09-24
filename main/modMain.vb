Module modMain
    Public Const STR_FMT_DATETIME_SHOW$ = "dd-MMM-yyyy HH:mm:ss"
    Public Const STR_FMT_DATE_SHOW$ = "dd-MMM-yyyy"
    Public Const STR_FMT_TIME_SHOW$ = "HH:mm:ss"

    Public Const STR_FILE_INI$ = "setting.ini"
    ''
    Public Const STR_APPID$ = "THL"
    Public Const STR_APPNAME$ = "Temp & Hum Logging"
    Public Const STR_APPVER$ = "1"
    Public Const STR_APPDATE$ = "2016-09-24"
    '
    Public Const STR_COMMAND$ = "ID:1 DATA:GetData7`"
    '
    Public Const INT_KEY% = 6454
    Public Const STR_KEY$ = "lpi"
    '
    'App setting
    Public GMyEnvirontment As DALCore.AppCore.cAppEnvirontment

End Module
