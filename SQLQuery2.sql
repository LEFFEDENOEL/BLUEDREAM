if object_id('DELETESUJET', 'p') is not null
drop procedure DELETESUJET
go

create procedure DELETESUJET

@idSujet 			    int

as

begin

	begin try
	
	begin transaction

		delete from SUJETS 		
		output DELETED.ID_SUJET
		where ID_SUJET = @idSujet
		
		delete from REPONSES 
		output DELETED.ID_REPONSE
		where ID_SUJET = @idSujet
		
	end try
	
	begin catch
	
		rollback transaction		
		/*RAISERROR ('Erreur lors de la suppression du sujet');*/
		
	end catch
	
	commit transaction
	--execute dbo.DELETEREPONSESBYSUJET
	
end
go