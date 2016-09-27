create procedure DECHIFFREMENT 

@mdpfromclient varchar(32), 
@login varchar(32), 
@resultat bit output

as

begin 
--10
	declare
		
	@mdpclair as varchar(32),
	@mdpcrypte as varbinary(256)
	
	/* Ouverture de la clé de chiffrement */
    begin try
	
        open SYMMETRIC key CLE_PASS
        DECRYPTION by PASSWORD = 'L..jstp !_x';
--21		
    end try
    begin catch
        -- Handle non-existant key here
    end catch
	
	/* Déchiffrement du mot de passe dans la colonne MDP_UTILISATEUR */
	set @mdpcrypte = (select MDP_UTILISATEUR from UTILISATEURS where LOGIN_UTILISATEUR = @login)	
	set @mdpclair = (select cast(DECRYPTBYKEY(MDP_UTILISATEUR) as varchar(32))from UTILISATEURS where LOGIN_UTILISATEUR = @login)
--30		
	/* Test de correspondance des mots de passe */
	if @mdpclair != @mdpfromclient 
	set @resultat = 0
	else 
	set @resultat = 1;
		
	return @resultat;
--38	
	/* Fermeture de la clé de chiffrement */
	close SYMMETRIC key CLE_PASS;
			
end


declare
@resultat as bit
execute dbo.dechiffrement 'fau', 'FAURELAU', @resultat output
print @resultat

if exists (select 1
            from  sys.procedures
            where  name ='DECHIFFREMENT'
           )
drop procedure dbo.DECHIFFREMENT
go


insert into UTILISATEURS (NOM_UTILISATEUR, PRENOM_UTILISATEUR, EST_MODERATEUR, MAIL_UTILISATEUR, LOGIN_UTILISATEUR, MDP_UTILISATEUR, PSEUDO_UTILISATEUR, DATE_INSCRIPTION)
values ('DUSSEUX','Loïc','TRUE','loic.dusseux@2isa,org','DUSSEUXLOI', CONVERT(varbinary(max), HASHBYTES('SHA1','duss')),'vivelaleffe','20160703 15:15:31');
go


insert into UTILISATEURS (NOM_UTILISATEUR, PRENOM_UTILISATEUR, EST_MODERATEUR, MAIL_UTILISATEUR, LOGIN_UTILISATEUR, MDP_UTILISATEUR, PSEUDO_UTILISATEUR, DATE_INSCRIPTION)
values ('KECHAI','Valérie','FALSE','vk@2isa.com','KECHAIVAL', CONVERT(varbinary(max), HASHBYTES('SHA1','kech')),'ibiforever','20160703 15:15:37');
go


insert into UTILISATEURS (NOM_UTILISATEUR, PRENOM_UTILISATEUR, EST_MODERATEUR, MAIL_UTILISATEUR, LOGIN_UTILISATEUR, MDP_UTILISATEUR, PSEUDO_UTILISATEUR, DATE_INSCRIPTION)
values ('MAZAUD','Catherine','FALSE','cmz@2isa.com','MAZAUDCAT', CONVERT(varbinary(max), HASHBYTES('SHA1','maza')),'duchesse','20160703 15:15:38');
go


insert into UTILISATEURS (NOM_UTILISATEUR, PRENOM_UTILISATEUR, EST_MODERATEUR, MAIL_UTILISATEUR, LOGIN_UTILISATEUR, MDP_UTILISATEUR, PSEUDO_UTILISATEUR, DATE_INSCRIPTION)
values ('COIFFARD','Régis','FALSE','rc@2isa.com','COIFFARD', CONVERT(varbinary(max), HASHBYTES('SHA1','coif')),'credo2isa','20160703 15:15:39');
go
