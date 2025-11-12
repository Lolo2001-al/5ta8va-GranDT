CALL altaEquipo("Boca Juniors", @idBoca);

-- Tipos de jugador
CALL altaTipo("Arquero", @idTipo1);
CALL altaTipo("Defensor", @idTipo2);
CALL altaTipo("Mediocampista", @idTipo3);
CALL altaTipo("Delantero", @idTipo4);

-- Jugadores
CALL altaFutbolista("Sergio", "Romero", NULL, "1987-02-22", 8500000, @idTipo1, @idBoca, @idFut1);
CALL altaFutbolista("Luis", "Advincula", NULL, "1990-03-02", 7200000, @idTipo2, @idBoca, @idFut2);
CALL altaFutbolista("Marcos", "Rojo", NULL, "1990-03-20", 8900000, @idTipo2, @idBoca, @idFut3);
CALL altaFutbolista("Frank", "Fabra", NULL, "1991-02-22", 8000000, @idTipo2, @idBoca, @idFut4);
CALL altaFutbolista("Cristian", "Lema", NULL, "1990-03-24", 7600000, @idTipo2, @idBoca, @idFut5);
CALL altaFutbolista("Pol", "Fernandez", NULL, "1991-10-11", 9500000, @idTipo3, @idBoca, @idFut6);
CALL altaFutbolista("Equi", "Fernandez", NULL, "2002-05-04", 7800000, @idTipo3, @idBoca, @idFut7);
CALL altaFutbolista("Cristian", "Medina", NULL, "2002-06-23", 7300000, @idTipo3, @idBoca, @idFut8);
CALL altaFutbolista("Kevin", "Zenon", NULL, "2001-03-19", 7200000, @idTipo3, @idBoca, @idFut9);
CALL altaFutbolista("Luca", "Langoni", NULL, "2002-09-09", 7700000, @idTipo4, @idBoca, @idFut10);
CALL altaFutbolista("Miguel", "Merentiel", NULL, "1996-02-24", 8700000, @idTipo4, @idBoca, @idFut11);
CALL altaFutbolista("Edinson", "Cavani", NULL, "1987-02-14", 9700000, @idTipo4, @idBoca, @idFut12);
CALL altaFutbolista("Aaron", "Anselmino", NULL, "2005-03-29", 7000000, @idTipo2, @idBoca, @idFut13);
CALL altaFutbolista("Marcelo", "Saracchi", NULL, "1998-04-23", 6800000, @idTipo2, @idBoca, @idFut14);
CALL altaFutbolista("Norberto", "Briasco", NULL, "1996-03-29", 7100000, @idTipo4, @idBoca, @idFut15);
CALL altaFutbolista("Leandro", "Brey", NULL, "2002-09-05", 6400000, @idTipo1, @idBoca, @idFut16);

CALL altaEquipo('River Plate', @idRiver);

CALL altaFutbolista('Franco','Armani',NULL,'1986-10-16',8500000,@idTipo1,@idRiver,@idFut17);
CALL altaFutbolista('Milton','Casco',NULL,'1988-04-29',6800000,@idTipo2,@idRiver,@idFut18);
CALL altaFutbolista('Leandro','Gonzalez Pirez',NULL,'1992-02-26',7500000,@idTipo2,@idRiver,@idFut19);
CALL altaFutbolista('Paulo','Diaz',NULL,'1994-08-25',8000000,@idTipo2,@idRiver,@idFut20);
CALL altaFutbolista('Enzo','Diaz',NULL,'1995-12-07',7300000,@idTipo2,@idRiver,@idFut21);
CALL altaFutbolista('Rodrigo','Aliendro',NULL,'1991-02-16',8700000,@idTipo3,@idRiver,@idFut22);
CALL altaFutbolista('Ignacio','Fernandez',NULL,'1990-01-12',8800000,@idTipo3,@idRiver,@idFut23);
CALL altaFutbolista('Claudio','Echeverri',NULL,'2006-01-02',9500000,@idTipo3,@idRiver,@idFut24);
CALL altaFutbolista('Esequiel','Barco',NULL,'1999-03-29',9100000,@idTipo3,@idRiver,@idFut25);
CALL altaFutbolista('Facundo','Colidio',NULL,'2000-01-04',8600000,@idTipo4,@idRiver,@idFut26);
CALL altaFutbolista('Miguel','Borja',NULL,'1993-01-26',8900000,@idTipo4,@idRiver,@idFut27);
CALL altaFutbolista('Pablo','Solari',NULL,'2001-03-22',8200000,@idTipo4,@idRiver,@idFut28);
CALL altaFutbolista('Agustin','Palavecino',NULL,'1996-11-09',7800000,@idTipo3,@idRiver,@idFut29);
CALL altaFutbolista('Santiago','Simón',NULL,'2002-06-13',7400000,@idTipo3,@idRiver,@idFut30);
CALL altaFutbolista('Gonzalo','Martinez',NULL,'1993-06-13',8000000,@idTipo3,@idRiver,@idFut31);
CALL altaFutbolista('Elias','Gomez',NULL,'1994-06-09',7100000,@idTipo2,@idRiver,@idFut32);

CALL altaEquipo('Racing Club', @idRacing);

CALL altaFutbolista('Gabriel','Arias',NULL,'1987-09-13',8300000,@idTipo1,@idRacing,@idFut33);
CALL altaFutbolista('Leonardo','Sigali',NULL,'1987-05-29',7400000,@idTipo2,@idRacing,@idFut34);
CALL altaFutbolista('Gonzalo','Piovi',NULL,'1994-09-08',7600000,@idTipo2,@idRacing,@idFut35);
CALL altaFutbolista('Facundo','Mura',NULL,'1999-03-24',7200000,@idTipo2,@idRacing,@idFut36);
CALL altaFutbolista('Baltasar','Rodriguez',NULL,'2004-03-13',6500000,@idTipo3,@idRacing,@idFut37);
CALL altaFutbolista('Juan','Quintero',NULL,'1993-01-18',8800000,@idTipo3,@idRacing,@idFut38);
CALL altaFutbolista('Nicolas','Oroz',NULL,'1994-04-01',7200000,@idTipo3,@idRacing,@idFut39);
CALL altaFutbolista('Agustin','Ojeda',NULL,'2003-01-10',7800000,@idTipo3,@idRacing,@idFut40);
CALL altaFutbolista('Roger','Martinez',NULL,'1994-06-23',8600000,@idTipo4,@idRacing,@idFut41);
CALL altaFutbolista('Maximiliano','Romero',NULL,'1999-01-09',7500000,@idTipo4,@idRacing,@idFut42);
CALL altaFutbolista('Gastón','Martirena',NULL,'1999-03-30',7000000,@idTipo2,@idRacing,@idFut43);
CALL altaFutbolista('Agustin','Garre',NULL,'2000-11-13',7200000,@idTipo3,@idRacing,@idFut44);
CALL altaFutbolista('Santiago','Quirós',NULL,'2004-04-15',6700000,@idTipo2,@idRacing,@idFut45);
CALL altaFutbolista('Juan','Ignacio Nardoni',NULL,'2002-07-14',8000000,@idTipo3,@idRacing,@idFut46);
CALL altaFutbolista('Aníbal','Moreno',NULL,'1999-05-13',8700000,@idTipo3,@idRacing,@idFut47);
CALL altaFutbolista('Gabriel','Rojas',NULL,'1997-06-20',7100000,@idTipo2,@idRacing,@idFut48);

CALL altaEquipo('Independiente', @idIndep);

CALL altaFutbolista('Rodrigo','Rey',NULL,'1991-03-08',8100000,@idTipo1,@idIndep,@idFut49);
CALL altaFutbolista('Javier','Bustos',NULL,'1996-04-15',8300000,@idTipo3,@idIndep,@idFut50);
CALL altaFutbolista('Damián','Batallini',NULL,'1996-06-24',8000000,@idTipo4,@idIndep,@idFut51);
CALL altaFutbolista('Lucas','Gonzalez',NULL,'2000-06-25',7500000,@idTipo3,@idIndep,@idFut52);
CALL altaFutbolista('Martín','Cauteruccio',NULL,'1987-04-14',7700000,@idTipo4,@idIndep,@idFut53);
CALL altaFutbolista('Sergio','Ortiz',NULL,'2001-02-04',6900000,@idTipo3,@idIndep,@idFut54);
CALL altaFutbolista('Baltasar','Barcia',NULL,'2001-04-02',6800000,@idTipo4,@idIndep,@idFut55);
CALL altaFutbolista('Iván','Marcone',NULL,'1990-06-03',8400000,@idTipo3,@idIndep,@idFut56);
CALL altaFutbolista('Joaquin','Laso',NULL,'1990-01-31',7200000,@idTipo2,@idIndep,@idFut57);
CALL altaFutbolista('Ayrton','Costa',NULL,'1999-07-12',7100000,@idTipo2,@idIndep,@idFut58);
CALL altaFutbolista('Damian','Perez',NULL,'1988-12-22',6700000,@idTipo2,@idIndep,@idFut59);
CALL altaFutbolista('Mauricio','Isla',NULL,'1988-06-12',8000000,@idTipo2,@idIndep,@idFut60);
CALL altaFutbolista('Federico','Mancuello',NULL,'1989-03-26',8500000,@idTipo3,@idIndep,@idFut61);
CALL altaFutbolista('Julián','Romero',NULL,'2003-01-08',7000000,@idTipo4,@idIndep,@idFut62);
CALL altaFutbolista('Gabriel','Avila',NULL,'2002-05-10',6400000,@idTipo4,@idIndep,@idFut63);
CALL altaFutbolista('Martín','Sarrafiore',NULL,'1998-07-20',7300000,@idTipo3,@idIndep,@idFut64);

CALL altaEquipo('San Lorenzo', @idSanL);

CALL altaFutbolista('Gastón','Gómez',NULL,'1996-02-27',8200000,@idTipo1,@idSanL,@idFut65);
CALL altaFutbolista('Rafael','Perez',NULL,'1990-01-22',7600000,@idTipo2,@idSanL,@idFut66);
CALL altaFutbolista('Jalil','Elias',NULL,'1996-04-24',8700000,@idTipo3,@idSanL,@idFut67);
CALL altaFutbolista('Adam','Bareiro',NULL,'1996-07-26',9100000,@idTipo4,@idSanL,@idFut68);
CALL altaFutbolista('Augusto','Batalla',NULL,'1996-06-30',8700000,@idTipo1,@idSanL,@idFut69);
CALL altaFutbolista('Agustin','Giay',NULL,'2004-01-16',9400000,@idTipo2,@idSanL,@idFut70);
CALL altaFutbolista('Malcom','Braida',NULL,'1997-05-17',8800000,@idTipo3,@idSanL,@idFut71);
CALL altaFutbolista('Gaston','Hernandez',NULL,'1998-06-19',7800000,@idTipo2,@idSanL,@idFut72);
CALL altaFutbolista('Federico','Girotti',NULL,'1999-06-03',8300000,@idTipo4,@idSanL,@idFut73);
CALL altaFutbolista('Nahuel','Barrios',NULL,'1998-05-07',8700000,@idTipo4,@idSanL,@idFut74);
CALL altaFutbolista('Ezequiel','Cerutti',NULL,'1991-01-17',7700000,@idTipo4,@idSanL,@idFut75);
CALL altaFutbolista('Carlos','Sanchez',NULL,'1984-02-02',6800000,@idTipo3,@idSanL,@idFut76);
CALL altaFutbolista('Ivan','Leguizamon',NULL,'2002-04-04',7500000,@idTipo4,@idSanL,@idFut77);
CALL altaFutbolista('Agustin','Martegani',NULL,'2000-05-20',8000000,@idTipo3,@idSanL,@idFut78);
CALL altaFutbolista('Alexis','Sabella',NULL,'2001-03-10',7200000,@idTipo3,@idSanL,@idFut79);
CALL altaFutbolista('Gastón','Campi',NULL,'1991-04-06',6900000,@idTipo2,@idSanL,@idFut80);

CALL altaEquipo('Estudiantes LP', @idEDLP);

CALL altaFutbolista('Mariano','Andujar',NULL,'1983-07-30',8500000,@idTipo1,@idEDLP,@idFut81);
CALL altaFutbolista('Santiago','Nunez',NULL,'2000-02-14',7000000,@idTipo2,@idEDLP,@idFut82);
CALL altaFutbolista('Zaid','Romero',NULL,'1999-12-15',7400000,@idTipo2,@idEDLP,@idFut83);
CALL altaFutbolista('Jorge','Rodriguez',NULL,'1995-09-07',7800000,@idTipo3,@idEDLP,@idFut84);
CALL altaFutbolista('Fernando','Zucculini',NULL,'1990-09-19',6900000,@idTipo3,@idEDLP,@idFut85);
CALL altaFutbolista('Santiago','Ascacibar',NULL,'1997-02-25',8700000,@idTipo3,@idEDLP,@idFut86);
CALL altaFutbolista('Benjamín','Rollheiser',NULL,'2000-03-31',9800000,@idTipo4,@idEDLP,@idFut87);
CALL altaFutbolista('Mauro','Boselli',NULL,'1985-05-22',9100000,@idTipo4,@idEDLP,@idFut88);
CALL altaFutbolista('Guido','Carrillo',NULL,'1991-05-25',8600000,@idTipo4,@idEDLP,@idFut89);
CALL altaFutbolista('Eros','Mancuso',NULL,'1999-03-14',7500000,@idTipo2,@idEDLP,@idFut90);
CALL altaFutbolista('Nicolas','Palavecino',NULL,'1998-04-22',7200000,@idTipo3,@idEDLP,@idFut91);
CALL altaFutbolista('Tiago','Palacios',NULL,'2001-04-16',8100000,@idTipo3,@idEDLP,@idFut92);

