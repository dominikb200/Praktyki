$taskName = $args[0]
$taskDate = $args[1]

Write-Host "Rozpoczeto zadanie: $taskName o $taskDate"

Start-Sleep -Seconds 5

Write-Host "Zakonczono zadanie: $taskName"

exit 0