for (($i = 0); $i -lt 20; $i++)
{
 $m='MstestMstestTwoRoadDivergedAndICouldNotTravelBothMtestTestMethod0' + $i;
 $n='MstestMstestTwoRoadDivergedAndICouldNotTravelBothMtestUnitTestClass_0' + $i;
 (Get-Content .\Mstest.cs) -Replace 'TestMethod0', $m -Replace 'UnitTestClass_0', $n | Set-Content .\Mstest$i.cs 
}