declare 
@compteur as int = 0,
@nombreAleatoire as varchar(4),
@loginCalcule as varchar(50)
execute dbo.CREATEUTILISATEUR 'ESSAI2', 'LAURENT', 'false', 'essai2@2isa.org', '1A8F80D', 'loloessai2', '03/07/2016 15:15:30'
print @logincalcule
go