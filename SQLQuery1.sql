if exists (select 1
            from  sys.procedures
            where  name ='GETIDENTIFICATIONUTILISATEUR'
           )
drop procedure dbo.GETIDENTIFICATIONUTILISATEUR 
go


create procedure GETIDENTIFICATIONUTILISATEUR 

@empreinteSha varchar(60), 
@login varchar(32)

as

begin

	declare
		
	@mdpbase as varchar(60)
	
	begin try
		
	    /* Ouverture de la clé de chiffrement */
        open SYMMETRIC key CLE_PASS
        DECRYPTION by PASSWORD = 'L..jstp !_x';
						
	    /* Déchiffrement du mot de passe dans la colonne MDP_UTILISATEUR */	
	    set @mdpbase = (select cast(DECRYPTBYKEY(MDP_UTILISATEUR) as varchar(60))
	    from UTILISATEURS 
	    where LOGIN_UTILISATEUR = @login)
	
	    /* Fermeture de la clé de chiffrement */
	    close SYMMETRIC key CLE_PASS
	
	    /* Test de correspondance des mots de passe */	
	    select ID_UTILISATEUR, NOM_UTILISATEUR, PRENOM_UTILISATEUR, MAIL_UTILISATEUR, 
	           LOGIN_UTILISATEUR, EST_MODERATEUR, PSEUDO_UTILISATEUR, DATE_INSCRIPTION
	    from UTILISATEURS 
	    where @empreinteSha is not null and @empreinteSha = @mdpbase and LOGIN_UTILISATEUR = @login
	
    end try

	begin catch
        
		RAISERROR ('Erreur lors de l''identification', -- Message text.
               16, -- Severity.
               1 -- State.
               );  
	end catch	
	
end