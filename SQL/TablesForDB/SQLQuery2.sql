/****** Script for SelectTopNRows command from SSMS  ******/
use School
--SELECT * FROM Students

-- Where Gender = 'man' and Born > 2001
-- order by Born desc
select Born from Students
group by Born