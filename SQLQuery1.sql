execute dbo.GETSUJETSBYRUBRIQUE "développement"


if object_id('GETSUJETSBYRUBRIQUE', 'p') is not null
drop procedure GETSUJETSBYRUBRIQUE
go

create procedure GETSUJETSBYRUBRIQUE

@nomrubrique varchar(50)

as

begin

select NOMUTILISATEUR, PSEUDO, DTESUJET, NOMRUBRIQUE, IDSUJET, TITRESUJET, DESCSUJET from GESTION_MESSAGES_VUE where NOMRUBRIQUE = @nomrubrique

end
go