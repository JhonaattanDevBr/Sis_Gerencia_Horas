use Bd_GerenciaHoras;

create table Controle(
	idCont int identity(100,1) not null,
	dia date not null,
	horaIni time not null,
	horaFin time not null,
	primary key (idCont)
)

create table Projetos(
	idproj int identity(100,1) not null,
	nomeProj varchar(40) not null,
	inicioProj date not null,
	finalProj date,
	idControle int,
	primary key (idProj),
	foreign key (idControle) references Controle (idCont)
)