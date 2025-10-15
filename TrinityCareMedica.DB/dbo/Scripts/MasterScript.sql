/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\UserScript.sql
:r .\PatientScript.sql
:r .\RoomsScript.sql
:r .\RoomAssignmentsScript.sql
:r .\DepartmentsScript.sql
:r .\StaffScript.sql
:r .\MedicalRecordsScript.sql
:r .\StaffAssignmentsScript.sql
:r .\TreatmentsScript.sql
:r .\MedicationsScript.sql