SELECT TOP 10 * FROM [Register].[User] 
WHERE Email like '%Fba%'

SELECT TOP 10 * FROM [Mobile].[UserMobile] 
WHERE Email like '%Fba%'


SELECT TOP 10 * FROM [Register].[User] 
WHERE Email like '%MAURICIO%'

BEGIN TRANSACTION
DELETE [Register].[User] WHERE Id in ('C060A0C3-6CE0-4682-B4B4-2001539F97E9')
DELETE [Mobile].[UserMobile] WHERE Id in ('C060A0C3-6CE0-4682-B4B4-2001539F97E9')
