if object_id('GETLOGIN', 'p') is not null
drop procedure GETLOGIN
go

create procedure GETLOGIN

@pseudo  varchar(30)

as

begin

select LOGIN_UTILISATEUR
from UTILISATEURS
where PSEUDO_UTILISATEUR = @pseudo

end
go