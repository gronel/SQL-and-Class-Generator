Dim shell, systempath

set shell = WScript.CreateObject( "WScript.Shell" )

systempath = shell.ExpandEnvironmentStrings("%SystemRoot%")

shell.Run Chr(34) & systempath & "\system32\msiexec.exe" & Chr(34) & "  /x{E4FFE8EF-57D7-4936-8E7F-9AA8F9566209}"

WScript.Quit