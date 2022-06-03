SELECT [ICE_name], [ICE_horsepower], [ICE_capacity],
[fuel_name], [type_WD_name] FROM [dbo].[Configuration]
join [dbo].[ICE] ON [dbo].[Configuration].[id_ICE] = [dbo].[ICE].[id_ICE]
join [dbo].[Type_Fuel] ON [dbo].[ICE].[id_type_fuel] = [dbo].[Type_Fuel].[id_type_fuel]
join [dbo].[Type_WD] ON [dbo].[Configuration].[id_type_WD] = [dbo].[Type_WD].[id_type_WD]

SELECT * FROM [dbo].[Configuration]

SELECT * FROM [dbo].[Schedule]

SELECT [id_schedule]
FROM [dbo].[Registration] 
join [dbo].[Employee] ON [dbo].[Employee].[id_employee] = [dbo].[Registration].[id_employee]
WHERE date_service = '2022-05-06' AND [dbo].[Registration].[id_employee] = 5

SELECT [first_name], [last_name], [dbo].[Employee].[id_employee] FROM [dbo].[Employee]
join [dbo].[Login] ON [dbo].[Employee].[id_employee] = [dbo].[Login].[id_employee]
join [dbo].[Position] ON [dbo].[Login].[id_position] = [dbo].[Position].[id_position]
WHERE [role] = 'ewr'

SELECT *
FROM [dbo].[Configuration]
join [dbo].[Model_Conf] ON [dbo].[Model_Conf].[id_conf] = [dbo].[Configuration].[id_configuration]
join [dbo].[Model] ON [dbo].[Model].[id_model] = [dbo].[Model_Conf].[id_model]
WHERE [dbo].[Model].[id_model] = 3

SELECT * FROM [dbo].[Registration]

SELECT * FROM [dbo].[Service_Reg]

SELECT * FROM [dbo].[Promo_Reg]

SELECT [id_promotion], [name_promotion],
[short_description_promotion], [full_description_promotion], [active_status], [sale] 
FROM [dbo].[Promotion]

SELECT [login], [password], [role] FROM [dbo].[Login] 
join [dbo].[Position] ON [dbo].[Login].[id_position] = [dbo].[Position].[id_position]
WHERE [login]= 'cmanager'

SELECT * FROM [dbo].[Registration]
WHERE [dbo].[Registration].[id_employee] = 7 AND [date_service] > GETDATE()-1

SELECT [id_schedule]
FROM [dbo].[Registration]
WHERE date_service = '2022-05-06'
AND [dbo].[Registration].[id_employee] = 7

SELECT [id_reg] FROM [dbo].[Registration]
join [dbo].[Schedule] 
ON [dbo].[Schedule].[id_schedle] = [dbo].[Registration].[id_schedule]
WHERE [date_service] = CAST(GETDATE() AS DATE) 
AND CAST(GETDATE() AS TIME(7))  
BETWEEN [dbo].[Schedule].[time_start] AND [dbo].[Schedule].[time_end]

SELECT [name], [model_name], [id_configuration], [description_service], [dbo].[Registration].[id_reg]
FROM [dbo].[Registration]
join [dbo].[Model] ON [dbo].[Model] .[id_model] = [dbo].[Registration].[id_model]
join [dbo].[Service_Reg] ON [dbo].[Service_Reg].[id_reg] = [dbo].[Registration].[id_reg]
join [dbo].[Service] ON [dbo].[Service].[id_service] = [dbo].[Service_Reg].[id_service]
WHERE [dbo].[Registration].[id_reg] = 40

@idReg

SELECT [id_reg] FROM [dbo].[Registration]
join [dbo].[Schedule] 
ON [dbo].[Schedule].[id_schedle] = [dbo].[Registration].[id_schedule]
WHERE [id_status_work] = 1
AND [date_service] <= CAST(GETDATE()-1 AS DATE)
AND [dbo].[Schedule].[time_start] < CAST(GETDATE() AS TIME(7))

SELECT [id_reg] FROM [dbo].[Registration]
WHERE [date_service] = '2022-05-10'
AND [id_schedule] = 8

UPDATE [dbo].[Registration]
SET [id_status_work] = 2
WHERE [id_reg] = 27

SELECT [first_name], [last_name]
FROM [dbo].[Employee]
WHERE [status] = 1

SELECT [dbo].[Registration].[id_reg] FROM [dbo].[Registration]
WHERE [id_employee] = 11
AND [dbo].[Registration].[id_status_work] = 2

--Active Order
SELECT * FROM [dbo].[Order]
WHERE [dbo].[Order].[active_status] = 1
AND [dbo].[Order].[id_employee] = 11

-- if active order true
-- to do employee status = 0
UPDATE [dbo].[Employee]
SET [dbo].[Employee].[status] = 0
WHERE [dbo].[Employee].[id_employee] = 11

[dbo].[Registration].[id_reg] = 37

DELETE FROM [dbo].[Service_Reg] WHERE [id_reg] = 33

SELECT * FROM [dbo].[Express_status];

CREATE TRIGGER Order_UPDATE
ON [dbo].[Order]
AFTER UPDATE
AS
UPDATE [dbo].[Registration] SET [id_status_work] = 4 FROM [dbo].[Order]
WHERE [dbo].[Order].[id_reg] = [dbo].[Registration].[id_reg]

UPDATE [dbo].[Order] SET [active_status] = 0 WHERE [id_order] = 2

SELECT * FROM [dbo].[Registration]
WHERE [id_employee] = 11
AND ([id_status_work] = 2 OR [id_status_work] = 4)
ORDER BY [id_status_work] DESC

SELECT * FROM [dbo].[Registration]
WHERE [id_employee] = 11
AND [id_status_work] = 4

SELECT [dbo].[Service].[id_service],[dbo].[Service].[description_service],[dbo].[Service].[price] FROM [dbo].[Service]
join [dbo].[Service_Reg]
ON [dbo].[Service_Reg].[id_service] = [dbo].[Service].[id_service]
join [dbo].[Registration]
ON [dbo].[Registration].[id_reg] = [dbo].[Service_Reg].[id_reg] 
WHERE [dbo].[Registration].[id_reg] = 30

SELECT [first_name], [last_name], [id_employee] FROM [dbo].[Employee] WHERE [status] = 1