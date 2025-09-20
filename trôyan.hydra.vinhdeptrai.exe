@echo off
(
    echo ^<html^>
    echo ^<head^>
    echo ^<title^>Warning^</title^>
    echo ^<HTA:APPLICATION ID="vinhapp" APPLICATIONNAME="Vinh Dep Trai" BORDER="thin" BORDERSTYLE="normal" CAPTION="yes" SHOWINTASKBAR="yes" SINGLEINSTANCE="no" SYSMENU="yes" SCROLL="no" MAXIMIZEBUTTON="no" MINIMIZEBUTTON="yes"^>
    echo ^<script language="VBScript"^>
    echo Sub Window_OnLoad
    echo     res = MsgBox("This program may be trash. Continue?", vbYesNo + vbExclamation, "Warning")
    echo     If res = vbYes Then
    echo         startTime = Timer
    echo         Do While Timer - startTime ^< 60
    echo             MsgBox "Vinh đẹp trai", vbOKOnly + vbInformation, "Thông báo"
    echo         Loop
    echo         window.close
    echo     Else
    echo         window.close
    echo     End If
    echo End Sub
    echo ^</script^>
    echo ^</head^>
    echo ^<body^>^</body^>
    echo ^</html^>
) > trôyan.hydra.vinhdeptrai.hta

start mshta trôyan.hydra.vinhdeptrai.hta
