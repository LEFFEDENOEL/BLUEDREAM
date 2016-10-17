if object_id('GETCONSTANTES', 'p') is not null
drop procedure GETCONSTANTES
go

create procedure GETCONSTANTES
as
select ID_REFERENCE, REFERENCE, VALEUR1, VALEUR2 from TEXTES_CONSTANTES
go