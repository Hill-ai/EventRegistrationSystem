/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Dui LLP','712-4654 Metus Ave','(897) 416-5834','pharetra@euplacerateget.net','Echo','(753) 126-1651','lectus.convallis.est@Vivamusmolestiedapibus.net','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sed Eu Incorporated','P.O. Box 504, 2293 Vitae Ave','(636) 795-2793','cursus.non.egestas@lorem.org','Bradley Cline','(605) 439-4814','Etiam.gravida.molestie@eratSed.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ornare Lectus Limited','968-233 Blandit St.','(307) 949-2492','volutpat@ametrisus.org','Grady Rhodes','(319) 419-6298','vulputate.eu@Ut.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Fusce Inc.','Ap #148-6760 Nulla St.','(857) 183-9487','venenatis.lacus@duiFuscediam.co.uk','Evan Nguyen','(726) 137-8234','a.dui.Cras@hymenaeosMaurisut.net'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ut Semper Corp.','7532 Natoque St.','(811) 307-7180','vel.convallis.in@a.org','Christopher Fry','(531) 736-7206','auctor.velit.eget@magnisdis.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Fermentum Incorporated','P.O. Box 909, 1503 Nisl. Road','(300) 290-1722','erat@duiCum.ca','Bevis Hall','(463) 373-4532','dignissim.pharetra@est.edu'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Gravida Inc.','Ap #924-8556 Fermentum Rd.','(935) 456-7904','Suspendisse.aliquet@atvelit.edu','Emmanuel Lara','(953) 624-4271','non@nullaDonec.net'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Scelerisque Neque Sed Company','8264 Leo, Road','(175) 149-9132','dignissim.lacus.Aliquam@natoque.net','Bert Gutierrez','(414) 256-3869','interdum.libero.dui@eratEtiamvestibulum.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Vitae Foundation','6497 Ornare Rd.','(898) 595-8881','malesuada.fames@pedePraesenteu.ca','Yardley Olsen','(169) 100-8270','a.magna.Lorem@quam.edu'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Luctus Et Ultrices Company','6659 Porta Street','(945) 127-5016','Nunc.commodo@ultricies.com','Colt Mclaughlin','(588) 127-8492','consectetuer.cursus.et@faucibusorciluctus.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Faucibus Leo Inc.','Ap #611-6967 Iaculis Rd.','(204) 624-8170','ut@ametconsectetuer.ca','Kennedy Kent','(559) 763-1442','Mauris.non@auctor.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Nulla Magna Malesuada LLP','P.O. Box 650, 7866 Pede, Road','(874) 368-7991','id@neque.org','Galvin Rowland','(413) 874-4977','at.velit.Pellentesque@euturpisNulla.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Magna Praesent LLP','P.O. Box 601, 7510 Magna Rd.','(443) 460-0721','lectus@tincidunt.edu','Jin Gallegos','(803) 915-9173','nonummy.ipsum@lorem.net'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sagittis Semper Nam LLC','P.O. Box 975, 3733 Leo. Avenue','(382) 258-5203','erat@iaculislacuspede.ca','Charles Hooper','(832) 948-2492','non.enim.commodo@feugiat.net'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Natoque Ltd','902-6016 Cursus Street','(373) 746-3326','nisi.magna.sed@ultricesDuis.ca','Trevor Harrison','(182) 125-4288','turpis.Nulla@quis.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Non Nisi Aenean PC','1456 Nulla Ave','(591) 954-0716','velit.eget.laoreet@ullamcorper.co.uk','Griffith Bean','(672) 715-5108','luctus@eudolor.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Quis Tristique Ac PC','Ap #702-6224 Nullam Road','(322) 379-8485','egestas.a@nulla.net','Jasper Abbott','(727) 978-7192','Sed@purus.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ligula Eu Industries','P.O. Box 992, 7990 Dictum. Ave','(131) 439-3709','penatibus.et.magnis@molestiesodales.com','Damian Frazier','(919) 880-3631','egestas.nunc@Phaselluselit.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Vivamus Consulting','294-4944 Urna. St.','(363) 566-9835','dui@Crasdictumultricies.co.uk','Burke Wyatt','(580) 334-8500','rutrum@lacus.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Arcu Morbi Sit Corporation','5792 Curae; Avenue','(389) 328-8625','Sed@tortorNunc.co.uk','Alexander Moon','(575) 691-5772','erat.Etiam@malesuada.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Dictum Corporation','5263 Malesuada St.','(796) 379-2828','Nunc@ornarelectusjusto.net','Prescott Moran','(470) 676-4200','eu.nulla@maurissapiencursus.edu');
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Aliquet Metus PC','P.O. Box 654, 7588 Metus. Ave','(971) 797-0553','ipsum.primis.in@nequevenenatis.edu','Damon Rios','(196) 428-3499','est.vitae.sodales@necante.edu'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Mattis Velit Foundation','Ap #858-4397 Sed, Ave','(799) 953-2778','nibh.enim.gravida@Inornaresagittis.ca','Ralph Sanford','(845) 716-1979','ligula.consectetuer.rhoncus@massa.net'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Mauris Ut Mi Incorporated','150-4912 Risus. Rd.','(898) 731-0441','cursus@etmalesuada.com','Emery Frye','(984) 939-9107','Vestibulum.ante@Fuscefeugiat.edu'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Aliquam Foundation','Ap #878-8756 Malesuada St.','(221) 488-8267','a.mi.fringilla@atsemmolestie.org','Oren Armstrong','(445) 705-1684','a@adipiscingenim.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sed Corporation','826-3992 Consequat Rd.','(557) 716-0413','lorem@ultricesVivamus.com','Nissim Puckett','(550) 728-7653','magna@porttitorscelerisqueneque.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sed Ltd','670-4256 Vitae Street','(520) 420-4263','ornare.tortor.at@liberonecligula.org','Thor Stuart','(166) 907-7777','est@pedeNuncsed.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Euismod Et Inc.','Ap #115-2771 Pede, Ave','(634) 864-0584','augue.id.ante@vitaenibhDonec.edu','Price Horne','(764) 812-0339','libero.Morbi@tinciduntadipiscingMauris.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Lorem Semper Industries','1085 In Rd.','(992) 324-6804','hendrerit.id@diamat.co.uk','Jamal Horton','(472) 604-2327','tellus.faucibus@acipsum.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ipsum Curabitur Corp.','Ap #229-437 Sapien. Avenue','(725) 521-4328','nonummy.ipsum@Curabituregestasnunc.ca','Hu Elliott','(386) 280-0587','Suspendisse@lacus.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ipsum Sodales Purus Associates','118-191 Augue Rd.','(719) 963-0610','eget.ipsum.Suspendisse@atfringillapurus.org','Cain Woodard','(725) 528-2792','quis.accumsan.convallis@odio.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Montes Nascetur Ridiculus Limited','P.O. Box 599, 102 Convallis, Ave','(664) 589-9087','leo.Vivamus@ante.com','Igor Kelley','(600) 433-1002','dignissim.lacus@Praesentluctus.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Id Risus Consulting','882-9618 Ligula Rd.','(436) 512-2749','Ut@neceuismodin.net','Barry Vaughan','(155) 233-9425','tempus.eu@arcuVestibulum.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sed Dictum Ltd','6480 Molestie Road','(617) 634-7977','mattis.ornare@nibhQuisque.com','Boris Oneil','(723) 163-5583','porttitor.eros.nec@Phasellusornare.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Aenean Gravida Incorporated','7029 Ut Av.','(538) 905-0209','elit.Etiam@velitegestaslacinia.net','David Thornton','(668) 490-0317','at@at.co.uk'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Vel Venenatis Associates','Ap #559-9126 Cras St.','(578) 378-9720','Fusce.dolor@dolorQuisquetincidunt.org','Ferris Conway','(805) 979-2902','ipsum.Suspendisse.non@eratneque.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Dolor Tempus Corp.','Ap #825-1513 Mauris Avenue','(166) 154-7398','elit@non.org','Zephania Henry','(139) 669-8419','Cum@elitpharetraut.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Sociis Ltd','P.O. Box 309, 9545 Lacus. Rd.','(229) 118-8996','interdum.Curabitur@apurus.edu','Dennis Key','(580) 621-3846','dictum.ultricies.ligula@uterosnon.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Semper Company','7277 Quisque St.','(427) 436-0589','lorem@primisin.net','Macaulay Nichols','(167) 825-6945','habitant.morbi.tristique@suscipit.com'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Velit Cras Lorem LLC','Ap #175-3188 Odio, Rd.','(299) 770-2201','magna.Cras@ligulaconsectetuerrhoncus.org','Hasad Patterson','(370) 562-7418','est.Mauris@duiFuscealiquam.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ipsum Leo Elementum Industries','3942 Elit. Rd.','(923) 613-1416','erat.semper@dictumeleifend.ca','Grant Wright','(723) 160-0932','Donec@orciPhasellus.com');
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Orci Industries','369-3024 Libero. Road','(121) 478-9573','Lorem.ipsum@commodoatlibero.edu','Keane Sykes','(773) 166-2718','erat.neque@nibhAliquamornare.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Et Consulting','P.O. Box 137, 1431 Mollis St.','(227) 314-3695','cursus.vestibulum.Mauris@Crasvulputatevelit.ca','Xenos Mcgee','(834) 947-7293','convallis@tacitisociosquad.ca'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Dignissim Tempor Arcu Company','194-6566 Auctor St.','(697) 526-1639','interdum.Curabitur.dictum@urna.edu','Zahir Perry','(192) 257-4808','dolor.Fusce.feugiat@nequeetnunc.org'),
INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Molestie Tortor Nibh Corporation','P.O. Box 664, 628 Felis St.','(804) 349-3904','sem@semvitae.net','Hayden Joseph','(878) 653-0065','gravida.sagittis@nonlobortisquis.com');