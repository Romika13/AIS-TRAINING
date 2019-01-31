#function declaration
function Division(){       
try{
$num3 = $num1/$num2
Write-Host $num3
}
catch [DivideByZeroException]
{
Write-Host "exception"
}
}

try{
Write-Host "enter number 1"  
[INT]$num1 = Read-Host            #user input            
Write-Host "enter number 2"  
[INT]$num2 = Read-Host           #user input          
}
catch{
Write-Host "Exception occured"
Write-Host $_.Exception.Message
}

Division $num1 $num2      #function call
