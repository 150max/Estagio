USE [DW_NSA]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Procedimento3]
as
declare @verificação int = 1,@presencasp int ,@Zonap int,@val1 int = 1
	set @Zonap = (select (zone_id) from L_Zone where zone_id=1)
Begin
    select @presencasp= (select count(presence_id) from F_Presence where datetime_end  IS NULL and zone_id = 1 )
	if @presencasp > @verificação
	BEGIN
	select 'Presenças com um total de '+ cast(@presencasp as varchar) + ' na Zona  ' + cast(@Zonap as  varchar)
			set @val1 = @val1 +1
	
	end
	

end