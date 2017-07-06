create sequence lugar_sequence;
create table lugar(
	IDLugar int default nextval('lugar_sequence'),
	Nombre character varying(200) not null,
	Tipo character varying(20) not null,
	FK_Lugar int not null,
	constraint PK_IDLugar primary key(IDLugar),
	constraint FK_Lugar_Lugar foreign key(FK_Lugar) references lugar(IDLugar),
);

create table propietario(
	IDPropietario character varying (8),
	Nombre character varying(200) not null,
	Necesidad  character varying(200),
	constraint PK_IDPropietario primary key(IDPropietario)
);

create sequence correoElectrónico_sequence;
create table correoElectrónico(
	IDCorreo int default nextval('correoElectrónico_sequence'),
	DireccionCorreo character varying(200) not null,
	FK_PropietarioCorreo character varying (8) not null,
	constraint PK_IDCorreo primary key(IDCorreo),
	constraint FK_Propietario_Correo foreign key(FK_PropietarioCorreo) references propietario(IDPropietario)
);

create sequence telefono_sequence
create table telefono(
	IDTelefono int default nextval('telefono_sequence'),
	NumeroTelefonico character varying(15) not null,
	FK_PropietarioTelefono character varying (8) not null,
	constraint PK_IDTelefono primary key(IDTelefono),
	constraint FK_Propietario_Telefono foreign key(FK_PropietarioTelefono) references propietario(IDPropietario)
);

create sequence oficina_sequence;
create table oficina(
	IDOficina int default nextval('oficina_sequence'),
	NumeroTelefonico character varying(15) not null,
	FK_LugarOficina int not null,
	FK_TelefonoOficina int not null,
	FK_CorreoOficina int not null,
	constraint PK_IDOficina primary key(IDOficina),
	constraint FK_Lugar_Oficina foreign key(FK_LugarOficina) references lugar(IDLugar),
	constraint FK_Telefono_Oficina foreign key(FK_TelefonoOficina) references telefono(IDTelefono),
	constraint FK_Correo_Oficina foreign key(FK_CorreoOficina) references correoElectrónico(IDCorreo)
);

create sequence juntaDeCondominio_sequence;
create table juntaDeCondominio(
	IDJuntaCondominio int default nextval('juntaDeCondominio_sequence'),
	constraint PK_IDJuntaCondominio primary key(IDJuntaCondominio)
);

create sequence servicio_sequence;
create table servicio(
	IDServicio int default nextval('servicio_sequence'),
	NumeroCuenta character varying(15) not null,
	EstadoFuncionamiento character varying(20) not null,
	constraint PK_Servicio primary key(IDServicio),
);

create sequence fondo_sequence;
create table fondo(
	IDFondo int default nextval('fondo_sequence'),
	Deduccion character varying(100) not null,
	DisponibilidadReal varchar(1) not null,
	FK_ServicioFondo not null,
	constraint PK_Fondo primary key(IDFondo),
	constraint chek_DisponibilidadRealFondo check(DisponibilidadReal in('1','0')), /*1 true, 0 folse*/
	constraint FK_Servicio_Fondo foreign key(FK_ServicioFondo) references servicio(IDServicio)
);

create sequence servicio_juntaDeCondominio_sequence;
create table servicio_juntaDeCondominio(
	IDServicioJuntaCondominio int default nextval('servicio_juntaDeCondominio_sequence'),
	Aprobacion character varying(1) not null,
	Costo int not null,
	FK_NJunta not null,
	FK_NServicio not null,
	constraint PK_Servicio_juntaDeCondominio primary key(IDServicioJuntaCondominio),
	constraint chek_AprobacionServicioJunta check(Aprobacion in('1','0')), /*1 true, 0 folse*/
	constraint FK_Servicio_N foreign key(FK_NServicio) references servicio(IDServicio),
	constraint FK_Junta_N foreign key(FK_NJunta) references juntaDeCondominio(IDJuntaCondominio)
);

create table residencia(
	RIF character varying(15),
	Tipo_Residencia character varying(30) not null,
	FK_JuntaResidencia int not null,
	constraint PK_Residencia primary key(RIF),
	constraint FK_Junta_Residencia foreign key(FK_JuntaResidencia) references juntaDeCondominio(IDJuntaCondominio)
);

create sequence areaComun_sequence;
create table areaComun(
	IDAreaComun int default nextval('areaComun_sequence'),
	Nombre character varying(200) not null,
	FK_ResidenciaAreaComun character varying(15) not null,
	constraint PK_AreaComun primary key(IDAreaComun),
	constraint FK_Residencia_AreaComun foreign key(FK_ResidenciaAreaComun) references residencia(RIF)
);

create table trabajador(
	IDTrabajador character varying(8),
	Nombre character varying(200) not null,
	FK_JuntaTrabajador int not null,
	FK_ResidenciaTrabajador character varying(15) not null, 
	constraint PK_Trabajador primary key(IDTrabajador),
	constraint FK_Residencia_Trabajador foreign key(FK_ResidenciaTrabajador) references residencia(RIF),
	constraint FK_Junta_Trabajador foreign key(FK_JuntaTrabajador) references juntaDeCondominio(IDJuntaCondominio)
);

create sequence asamblea_sequence;
create table asamblea(
	IDAsamblea int default nextval('asamblea_sequence'),
	Tipo character varying(30) not null,
	Fecha_Creacion date not null,
	FK_LugarAsamblea int not null,
	constraint PK_Asamblea primary key(IDAsamblea),
	constraint FK_Lugar_Asamblea foreign key(FK_LugarAsamblea) references lugar(IDLugar)
)

create sequence apartamento_sequence;
create table apartamento(
	IDAartamento int default nextval('apartamento_sequence'),
	Alicuota int not null,
	Metros_Cuadrados int not null,

)

create sequence apartamentoPropietario_secuence;
create table apartamentoPropietario(
	IDApartamentoPropietario int default nextval('apartamentoPropietario_secuence'),
	FK_NApartamento int not null,
	FK_NPropietario int not null,
	constraint PK_ApartamentoPropietario primary key(primary),
	constraint FK_Apartamento_N foreign key(FK_NApartamento) references apartamento(IDAartamento),
	constraint FK_Propietario_N foreign key(FK_NPropietario) references propietario(IDPropietario)
)