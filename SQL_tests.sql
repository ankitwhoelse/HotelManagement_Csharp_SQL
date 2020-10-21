USE BDB56Ankit


SELECT * FROM P01_Assistant
SELECT * FROM P01_AssistantSoin

SELECT * FROM P01_Client
SELECT * FROM P01_Invite

SELECT * FROM P01_Chambre
SELECT * FROM P01_TypeChambre
SELECT * FROM P01_ReservationChambre

SELECT * FROM P01_Soin
SELECT * FROM P01_TypeSoin
SELECT * FROM P01_PlanifSoin

SELECT * FROM P01_TypeUtilisateur
SELECT * FROM P01_Utilisateur

		--	Rapport01
--SELECT CAST(NoClient as varchar) +': '+ C.Prenom +' '+ c.Nom as 'NomComplet_Personne', 
--Description as 'Soin', Ps.DateHeure, A.Prenom + ' ' + A.Nom as 'NomComplet_Assistant', S.prix
--FROM P01_Client C LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoClient
--LEFT JOIN P01_Assistant A on A.NoAssistant=Ps.NoAssistant
--LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null
--UNION
--SELECT CAST(NoInvite as varchar) +': '+ i.NomPrenom as 'NomComplet Pers',
--Description as 'Soin', Ps.DateHeure, A.Prenom + ' ' + A.Nom as 'NomComplet Ass', S.prix
--FROM P01_INVITE I LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoInvite
--LEFT JOIN P01_Assistant A on A.NoAssistant=Ps.NoAssistant
--LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null

--SELECT DISTINCT(NoPersonne), CAST(NoClient as varchar) +': '+ C.Prenom + ' ' + C.Nom as 'NomComplet'
--FROM P01_PlanifSoin Ps LEFT JOIN P01_Client C ON Ps.NoPersonne=C.NoClient WHERE NoClient is not null
--UNION
--SELECT DISTINCT(NoPersonne), CAST(NoInvite as varchar) +': '+ i.NomPrenom as 'NomComplet'
--FROM P01_PlanifSoin Ps LEFT JOIN P01_Invite I ON Ps.NoPersonne=I.NoInvite WHERE NoInvite is not null

--		-- Rapport03
--SELECT CAST(Ps.NoAssistant as varchar) +': '+ A.Prenom + ' ' + A.Nom as 'Assistant', A.NoAssistant,
--CAST(NoClient as varchar) +': '+ C.Prenom +' '+ c.Nom as 'Personne', C.NoClient as 'NoPersonne',
--Description as 'Soin', Ps.NoSoin, Ps.DateHeure
--FROM P01_Client C LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoClient
--LEFT JOIN P01_Assistant A on A.NoAssistant=Ps.NoAssistant
--LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null
--UNION
--SELECT CAST(Ps.NoAssistant as varchar) +': '+ A.Prenom + ' ' + A.Nom as 'Assistant', A.NoAssistant,
--CAST(NoInvite as varchar) +': '+ i.NomPrenom as 'Personne', I.NoInvite as 'NoPersonne',
--Description as 'Soin', Ps.NoSoin, Ps.DateHeure
--FROM P01_INVITE I LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoInvite
--LEFT JOIN P01_Assistant A on A.NoAssistant=Ps.NoAssistant
--LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null

SELECT CAST(NoAssistant as varchar) +': '+ Prenom + ' ' + Nom as 'Assistant', NoAssistant
FROM P01_Assistant

SELECT CONVERT(Date, DateHeure) as 'Date', NoAssistant
FROM P01_PlanifSoin

SELECT DISTINCT S.NoSoin, CONVERT(Date, DateHeure) as 'Date', NoAssistant, Description as 'NomSoin'
FROM P01_Soin S 
left join P01_PlanifSoin Ps on S.NoSoin = Ps.NoSoin
WHERE NoAssistant is not null

SELECT CAST(NoClient as varchar) +': '+ C.Prenom +' '+ c.Nom as 'Personne', C.NoClient as 'NoPersonne',
Description as 'Soin', Ps.NoSoin, Ps.DateHeure
FROM P01_Client C LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoClient
LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null
UNION
SELECT CAST(NoInvite as varchar) +': '+ i.NomPrenom as 'Personne', I.NoInvite as 'NoPersonne',
Description as 'Soin', Ps.NoSoin, Ps.DateHeure
FROM P01_INVITE I LEFT JOIN P01_PlanifSoin Ps on NoPersonne=NoInvite
LEFT JOIN P01_Soin S on S.NoSoin=Ps.NoSoin WHERE Ps.NoSoin is not null




--SELECT Rs.NoClient, CAST(Rs.NoClient as varchar) +': '+ Prenom +' '+ Nom +', Chambre: ' + CAST(NoChambre as varchar) as 'NomComplet'
--FROM P01_ReservationChambre Rs 
--LEFT JOIN P01_Client C on C.NoClient = Rs.NoClient

-- Rapport 03

SELECT DISTINCT Rs.NoClient, Rs.NoChambre ,
'Chambre ' + CAST(Rs.NoChambre AS varchar) + ', ' + C.Emplacement AS 'noEtEmplacementChambre'
FROM P01_ReservationChambre AS Rs 
LEFT OUTER JOIN P01_Chambre AS C ON C.NoChambre = Rs.NoChambre

SELECT Rs.NoClient, NoChambre, DateArrivee, DateDepart, NbPersonnes, Prenom +' '+Nom as 'NomComplet'
FROM P01_ReservationChambre Rs
LEFT JOIN P01_Client C on C.NoClient = Rs.NoClient