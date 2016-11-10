if object_id('GETREPONSESBYSUJET', 'p') is not null
drop procedure GETREPONSESBYSUJET
go

create procedure GETREPONSESBYSUJET

@titresujet varchar(256)

as

begin

	select u.ID_UTILISATEUR, u.NOM_UTILISATEUR, u.PSEUDO_UTILISATEUR, s.ID_SUJET, 
           r.ID_REPONSE, r.DATE_REPONSE, r.TEXTE_REPONSE 
	from REPONSES r 
	join UTILISATEURS u on u.ID_UTILISATEUR = r.ID_UTILISATEUR
	join SUJETS s on s.ID_SUJET = r.ID_SUJET
	where TITRE_SUJET = @titresujet
	order by DATE_REPONSE

end
go