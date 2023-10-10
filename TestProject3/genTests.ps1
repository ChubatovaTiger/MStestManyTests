for (($i = 0); $i -lt 20; $i++)
{
 $m='MstestMstestTwoRoadDivergedAndICouldNotTravelBothMtestTestMethod0' + $i;
 (Get-Content .\Mstest.cs) -Replace 'TestMethod0', $m | Set-Content .\Mstest$i.cs
}