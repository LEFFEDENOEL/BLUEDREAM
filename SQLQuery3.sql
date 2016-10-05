if object_id('BUILDSUJETBYIDSUJET', 'p') is not null
drop procedure BUILDSUJETBYIDSUJET
go

create procedure BUILDSUJETBYIDSUJET

@idsujet int

as

begin

select ID_UTILISATEUR, ID_SUJET, ID_RUBRIQUE, TITRE_SUJET, DESCRIPTION_SUJET, DATE_CREATION
from SUJETS where ID_SUJET = @idsujet

end
go