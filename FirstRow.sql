create database firstrow_;
go
use firstrow_;
go

create table [firstrow_].[dbo].[Categorias]
(
    id          int identity
        constraint PK_Categorias_id
            primary key clustered,
    nombre      varchar(45)  not null,
    descripcion varchar(max) not null,
    slug        varchar(100)
);

create table [firstrow_].[dbo].[Imagenes]
(
    id   int identity
        constraint PK_Imagenes_id
            primary key clustered,
    name varchar(100) not null,
    mode int
        constraint DF__Imagenes__mode__25869641 default NULL
);

create table [firstrow_].[dbo].[Incluidos]
(
    id     int         not null
        constraint PK_Incluidos_id
            primary key clustered,
    titulo varchar(50) not null
);

create table [firstrow_].[dbo].[Paises]
(
    id   int not null
        constraint PK_Paises_id
            primary key clustered,
    name varchar(100)
        constraint DF__Paises__name__2A4B4B5E default NULL
);

create table [firstrow_].[dbo].[Ciudades]
(
    id          int          not null,
    id_pais     int          not null
        constraint [Ciudades$ciudad-pais]
            references [firstrow_].[dbo].[Paises] (id)
            on update cascade on delete cascade,
    nombre      varchar(45)  not null,
    descripcion varchar(100) not null,
    image       varchar(100)
        constraint DF__Ciudades__image__2E1BDC42 default NULL,
    constraint PK_Ciudades_id
        primary key clustered (id asc, id_pais asc)
);

create index [ciudad-pais_idx]
    on [firstrow_].[dbo].[Ciudades] (id_pais);

create table [firstrow_].[dbo].[Usuarios]
(
    nickname         varchar(20)  not null
        constraint PK_Usuarios_nickname
            primary key clustered,
    email            varchar(50)  not null
        constraint Usuarios$email_UNIQUE
            unique nonclustered,
    password         varchar(100) not null,
    image            varchar(100)
        constraint DF__Usuarios__image__31EC6D26 default NULL,
    background_image varchar(100)
        constraint DF__Usuarios__backgr__32E0915F default NULL,
    name             varchar(100) not null,
    firstname        varchar(100) not null,
    secondname       varchar(100) not null,
    facebook         varchar(100)
        constraint DF__Usuarios__facebo__33D4B598 default NULL,
    twitter          varchar(100)
        constraint DF__Usuarios__twitte__34C8D9D1 default NULL
);

create table [firstrow_].[dbo].[Blogs]
(
    id               int          not null
        constraint PK_Blogs_id
            primary key clustered,
    imagen_principal varchar(100) not null,
    titulo           varchar(50)  not null,
    descripcion      varchar(100) not null,
    text_1           varchar(max) not null,
    text_2           varchar(max),
    text_3           varchar(max),
    citacion         varchar(100)
        constraint DF__Blogs__citacion__37A5467C default NULL,
    slug             varchar(100) not null,
    usuario          varchar(20)  not null
        constraint [Blogs$usuario-blog]
            references [firstrow_].[dbo].[Usuarios] (nickname)
            on update cascade on delete cascade,
    categoria        int          not null
        constraint [Blogs$categoria-blog]
            references [firstrow_].[dbo].[Categorias] (id)
            on update cascade on delete cascade,
    pais             int          not null
        constraint [Blogs$pais-blog]
            references [firstrow_].[dbo].[Paises] (id)
            on update cascade on delete cascade
);

create table [firstrow_].[dbo].[Blog_Imagenes]
(
    id_Blog   int not null
        constraint [Blog_Imagenes$imagen-blog]
            references [firstrow_].[dbo].[Blogs] (id)
            on update cascade on delete cascade,
    id_Imagen int not null
        constraint [Blog_Imagenes$blog-imagen]
            references [firstrow_].[dbo].[Imagenes] (id),
    constraint PK_Blog_Imagenes_id_Blog
        primary key clustered (id_Blog asc, id_Imagen asc)
);

create index [blog-imagen_idx]
    on [firstrow_].[dbo].[Blog_Imagenes] (id_Imagen);

create index [categoria-blog_idx]
    on [firstrow_].[dbo].[Blogs] (categoria);

create index [pais-blog_idx]
    on [firstrow_].[dbo].[Blogs] (pais);

create index [usuario-blog_idx]
    on [firstrow_].[dbo].[Blogs] (usuario);

create table [firstrow_].[dbo].[Comentarios]
(
    id        int identity
        constraint PK_Comentarios_id
            primary key clustered,
    texto     varchar(45) not null,
    estrellas varchar(45)
        constraint DF__Comentari__estre__412EB0B6 default NULL,
    nickname  varchar(20) not null
        constraint Comentarios$nickname_comentarios
            references [firstrow_].[dbo].[Usuarios] (nickname)
);

create table [firstrow_].[dbo].[Blog_Comentarios]
(
    id_Blog       int not null
        constraint [Blog_Comentarios$blog-comentario]
            references Blogs (id),
    id_Comentario int not null
        constraint [Blog_Comentarios$comentario-blog]
            references [firstrow_].[dbo].[Comentarios] (id)
            on update cascade on delete cascade,
    constraint PK_Blog_Comentarios_id_Blog
        primary key clustered (id_Blog asc, id_Comentario asc)
);

create index [comentario-blog_idx]
    on [firstrow_].[dbo].[Blog_Comentarios] (id_Comentario);

create index nickname_idx
    on [firstrow_].[dbo].[Comentarios] (nickname);

create table [firstrow_].[dbo].[Empresas]
(
    nickname      varchar(20)  not null
        constraint PK_Empresas_nickname
            primary key clustered
        constraint Empresas$nickname
            references [firstrow_].[dbo].[Usuarios] (nickname)
            on update cascade on delete cascade,
    cif           varchar(20)  not null,
    direccion     varchar(45)  not null,
    fechaCreacion datetime2(0) not null,
    pais          int          not null
        constraint Empresas$pais
            references [firstrow_].[dbo].[Paises] (id)
);

create index pais_idx
    on [firstrow_].[dbo].[Empresas] (pais);

create table [firstrow_].[dbo].[Experiencias]
(
    id          int identity
        constraint PK_Experiencias_id
            primary key clustered,
    nombre      varchar(45)  not null,
    titulo      varchar(45)  not null,
    descripcion varchar(45)  not null,
    slug        varchar(100) not null,
    pais        int          not null
        constraint Experiencias$experiencia_pais
            references [firstrow_].[dbo].[Paises] (id),
    empresa     varchar(20)  not null
        constraint Experiencias$experiencia_empresa
            references [firstrow_].[dbo].[Empresas] (nickname),
    precio      float
);

create table [firstrow_].[dbo].[Dias]
(
    id             int          not null,
    id_experiencia int          not null
        constraint [Dias$dia-experiencia]
            references [firstrow_].[dbo].[Experiencias] (id)
            on update cascade on delete cascade,
    nombre_dia     varchar(45)  not null,
    titulo         varchar(45)  not null,
    descipcion     varchar(max) not null,
    imagen         varchar(50)
        constraint DF__Dias__imagen__5165187F default NULL,
    constraint PK_Dias_id
        primary key clustered (id asc, id_experiencia asc)
);

create index [dia-experiencia_idx]
    on [firstrow_].[dbo].[Dias] (id_experiencia);

create table [firstrow_].[dbo].[Experiencia_Comentarios]
(
    id_Experiencia int not null
        constraint [Experiencia_Comentarios$experiencia-comentario]
            references [firstrow_].[dbo].[Experiencias] (id),
    id_Comentario  int not null
        constraint [Experiencia_Comentarios$comentario-experiencia]
            references [firstrow_].[dbo].[Comentarios] (id),
    constraint PK_Experiencia_Comentarios_id_Experiencia
        primary key clustered (id_Experiencia asc, id_Comentario asc)
);

create index [comentario-experiencia_idx]
    on [firstrow_].[dbo].[Experiencia_Comentarios] (id_Comentario);

create table [firstrow_].[dbo].[Experiencia_Imagenes]
(
    id_Experiencia int not null
        constraint Experiencia_Imagenes$id_experiencia
            references [firstrow_].[dbo].[Experiencias] (id)
            on update cascade on delete cascade,
    id_Imagen      int not null
        constraint Experiencia_Imagenes$id_imagen
            references [firstrow_].[dbo].[Imagenes] (id)
            on update cascade on delete cascade,
    constraint PK_Experiencia_Imagenes_id_Experiencia
        primary key clustered (id_Experiencia asc, id_Imagen asc)
);

create index id_imagen_idx
    on [firstrow_].[dbo].[Experiencia_Imagenes] (id_Imagen);

create table [firstrow_].[dbo].[Experiencia_Incluido]
(
    id_experiencia int not null
        constraint [Experiencia_Incluido$id-experiencia]
            references [firstrow_].[dbo].[Experiencias] (id),
    id_incluido    int not null
        constraint [Experiencia_Incluido$id-incluido]
            references [firstrow_].[dbo].[Incluidos] (id),
    constraint PK_Experiencia_Incluido_id_experiencia
        primary key clustered (id_experiencia asc, id_incluido asc)
);

create index [id-incluido_idx]
    on [firstrow_].[dbo].[Experiencia_Incluido] (id_incluido);

create index experiencia_empresa_idx
    on [firstrow_].[dbo].[Experiencias] (empresa);

create index experiencia_pais_idx
    on [firstrow_].[dbo].[Experiencias] (pais);

create table [firstrow_].[dbo].[Propuestas]
(
    id      int identity
        constraint PK_Propuestas_id
            primary key clustered,
    titulo  varchar(100) not null,
    texto   varchar(45)  not null,
    imagen  varchar(100)
        constraint DF__Propuesta__image__5FB337D6 default NULL,
    usuario varchar(20)  not null
        constraint Propuestas$propuesta_usuario
            references [firstrow_].[dbo].[Usuarios] (nickname),
    empresa varchar(20)  not null
        constraint Propuestas$propuesta_empresa
            references [firstrow_].[dbo].[Empresas] (nickname),
    slug    varchar(100)
);

create index propuesta_empresa_idx
    on [firstrow_].[dbo].[Propuestas] (empresa);

create index propuesta_usuario_idx
    on [firstrow_].[dbo].[Propuestas] (usuario);

create table [firstrow_].[dbo].[Reservas]
(
    id              int          not null
        constraint PK_Reservas_id
            primary key clustered,
    nombre          varchar(45)  not null,
    descripcion     varchar(100)
        constraint DF__Reservas__descri__6477ECF3 default NULL,
    experiencia     int          not null
        constraint [Reservas$reserva-experiencia]
            references [firstrow_].[dbo].[Experiencias] (id)
            on update cascade on delete cascade,
    fechaEntrada    datetime2(0) not null,
    fechaSalida     datetime2(0) not null,
    usuario         varchar(20)  not null
        constraint [Reservas$reserva-usuario]
            references [firstrow_].[dbo].[Usuarios] (nickname)
            on update cascade on delete cascade,
    precio_asignado float,
    personas        int
);

create index [reserva-experiencia_idx]
    on [firstrow_].[dbo].[Reservas] (experiencia);

create index [reserva-usuario_idx]
    on [firstrow_].[dbo].[Reservas] (usuario);













create table [firstrow_].[dbo].[Sorteos]
(
    id          int          not null
        constraint PK_Sorteos_id
            primary key clustered,
    titulo      varchar(45)  not null,
    descripcion varchar(100) not null,
    slug        varchar(100) not null,
    imagen      varchar(100) not null,
    experiencia int          not null
        constraint [Sorteos$experiencia-sorteo]
            references [firstrow_].[dbo].[Experiencias] (id),
    fechaInicio datetime2(0) not null,
    fechafINAL  datetime2(0) not null,
    empresa     varchar(20)  not null
        constraint [Sorteos&empresa]
            references [firstrow_].[dbo].[Empresas] (nickname)
            on update cascade on delete cascade
);

create table [firstrow_].[dbo].[Sorteo_Usuarios]
(
    id_Sorteo  int         not null
        constraint [Sorteo_Usuarios$id-sorteo]
            references Sorteos (id),
    id_Usuario varchar(20) not null
        constraint [Sorteo_Usuarios$id-sorteo-usuario]
            references Usuarios (nickname),
    constraint PK_Sorteo_Usuarios_id_Sorteo
        primary key clustered (id_Sorteo asc, id_Usuario asc)
);

create index [id-sorteo-usuario_idx]
    on [firstrow_].[dbo].[Sorteo_Usuarios] (id_Usuario);

create index [experiencia-sorteos_idx]
    on [firstrow_].[dbo].[Sorteos] (experiencia);

create unique index Sorteos_empresa_uindex
    on [firstrow_].[dbo].[Sorteos] (empresa);

create table [firstrow_].[dbo].[Stories]
(
    id          int                                                           not null
        constraint PK_Stories_id
            primary key clustered,
    titulo      varchar(50)                                                   not null,
    descripcion varchar(100)                                                  not null,
    fecha       datetime2(0)                                                  not null,
    pais        int                                                           not null
        constraint Stories$storie_pais
            references [firstrow_].[dbo].[Paises] (id),
    usuario     varchar(20)                                                   not null
        constraint Stories$storie_usuario
            references [firstrow_].[dbo].[Usuarios] (nickname),
    imagen      varchar(100)
        constraint DF__Stories__imagen__71D1E811 default 'default_storie.png' not null
);

create table [firstrow_].[dbo].[Blog_Stories]
(
    id_Blog   int not null
        constraint [Blog_Stories$blog-storie]
            references [firstrow_].[dbo].[Blogs] (id),
    id_Storie int not null
        constraint [Blog_Stories$storie-blog]
            references [firstrow_].[dbo].[Stories] (id)
            on update cascade on delete cascade,
    constraint PK_Blog_Stories_id_Blog
        primary key clustered (id_Blog asc, id_Storie asc)
);

create index [storie-blog_idx]
    on [firstrow_].[dbo].[Blog_Stories] (id_Storie);

create table [firstrow_].[dbo].[Experiencia_Stories]
(
    id_experiencia int not null
        constraint Experiencia_Stories$id_experiencia_storie
            references [firstrow_].[dbo].[Experiencias] (id)
            on update cascade on delete cascade,
    id_storie      int not null
        constraint Experiencia_Stories$id_storie_experiencia
            references [firstrow_].[dbo].[Stories] (id)
            on update cascade on delete cascade,
    constraint PK_Experiencia_Stories_id_experiencia
        primary key clustered (id_experiencia asc, id_storie asc)
);

create index id_storie_experiencia_idx
    on [firstrow_].[dbo].[Experiencia_Stories] (id_storie);

create index storie_pais_idx
    on [firstrow_].[dbo].[Stories] (pais);

create index storie_usuario_idx
    on [firstrow_].[dbo].[Stories] (usuario);

create table [firstrow_].[dbo].[Wearing]
(
    id          int          not null
        constraint PK_Wearing_id
            primary key clustered,
    titulo      varchar(50)  not null,
    descripcion varchar(100) not null,
    texto       varchar(255) not null,
    experiencia int          not null
        constraint [Wearing$wearing-experiencia]
            references [firstrow_].[dbo].[Experiencias] (id),
    slug        varchar(100) not null
);

create index [wearing-experiencia_idx]
    on [firstrow_].[dbo].[Wearing] (experiencia);

create table [firstrow_].[dbo].[Wearing_Imagenes]
(
    id_Wearing int not null
        constraint [Wearing_Imagenes$wearing-imagen]
            references [firstrow_].[dbo].[Wearing] (id),
    id_Imagen  int not null
        constraint [Wearing_Imagenes$imagen-wearing]
            references [firstrow_].[dbo].[Imagenes] (id),
    constraint PK_Wearing_Imagenes_id_Wearing
        primary key clustered (id_Wearing asc, id_Imagen asc)
);

create index [imagen-wearing_idx]
    on [firstrow_].[dbo].[Wearing_Imagenes] (id_Imagen);


SET IDENTITY_INSERT firstrow_.dbo.Categorias ON;
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (1, N'Sierra', N'Experiencias por montaña', N'sierra');
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (2, N'Playa', N'Experiencias en las mejores playas', N'playa');
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (3, N'Costa', N'Experiencias en las mejores costas', N'costa');
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (4, N'Interior', N'Experiencias por climas de interior', N'interior');
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (5, N'Invierno', N'Experiencias en climas extremos', N'invierno');
INSERT INTO firstrow_.dbo.Categorias (id, nombre, descripcion, slug) VALUES (6, N'Verano', N'Experiencias por climas tropicales', N'verano');

INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (1, N'España');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (2, N'Francia');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (3, N'Italia');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (4, N'Japon');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (5, N'Indonesia');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (6, N'EEUU');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (7, N'Noruega');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (8, N'Islandia');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (9, N'Suecia');
INSERT INTO firstrow_.dbo.Paises (id, name) VALUES (10, N'Andorra');

INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'admino', N'carloss2@carlos.es', N'1234', N'~/Media/Users/pepe.png', N'bg_default.png', N'asd', N'asdasd', N'adsasd', N'', N'');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'carlos233', N'dsa5ads@dsa.es', N'1234', N'default.png', N'bg_default.png', N'empresa', N'empresa', N'qweqwe', N'', N'');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'carlos3', N'carlos10@carlos.es', N'1234', N'~/Media/Users/carlos3_ejemplo3.png', N'bg_default.png', N'Carlos', N'Robles', N'Robles', N'Facebook', N'Twitter');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'carlos9', N'carlos9@carlos.es', N'1234', N'~/Media/Users/carlos9_perfil.jfif', N'bg_default.png', N'ewqewqe', N'qwewqe', N'qweqwe', N'', N'');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'carlosr', N'carlosq@carlos.es', N'1234', N'~/Media/Users/perfil.jfif', N'bg_default.png', N'feds', N'dfdsf', N'dsf', N'', N'');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'empresa', N'emp@emp2.com', N'1234', N'~/Media/Users/empresa_google.jpg', N'bg_default.png', N'Enterprise', N'empresa', N'empresa', N'9', N'uiuiiu');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'empresaw33', N'dsaads@dsa.es', N'1234', N'default.png', N'bg_default.png', N'empresa', N'empresa', N'rwe', N'', N'');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'pepe', N'carlos@carlos.es', N'1234', N'~/Media/Users/pepe.png', N'bg_default.png', N'eee', N'eeee', N'hhhh', N'face', N'twitt');
INSERT INTO firstrow_.dbo.Usuarios (nickname, email, password, image, background_image, name, firstname, secondname, facebook, twitter) VALUES (N'qweqweqwe', N'carlo2s@carlos.es', N'1234', N'pepe.png', N'bg_default.png', N'ewqeqwe', N'qweqwe', N'qweqe', N'', N'');

INSERT INTO firstrow_.dbo.Empresas (nickname, cif, direccion, fechaCreacion, pais) VALUES (N'carlos233', N'20097870X', N'444', N'2022-05-03 09:03:46', 4);
INSERT INTO firstrow_.dbo.Empresas (nickname, cif, direccion, fechaCreacion, pais) VALUES (N'empresa', N'20097870A', N'Calle 13', N'2022-04-25 11:04:01', 3);
INSERT INTO firstrow_.dbo.Empresas (nickname, cif, direccion, fechaCreacion, pais) VALUES (N'empresaw33', N'20097870X', N'Calle 104', N'2022-05-03 09:01:28', 3);


INSERT INTO firstrow_.dbo.Stories (id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES (1, N'tit', N'desc', N'2020-04-01 00:00:00', 3, N'carlos3', N'https://noticiasbancarias.com/wp-content/uploads/2015/05/Italia-2.jpg');
INSERT INTO firstrow_.dbo.Stories (id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES (2, N'viaje canarias', N'decripcion viaje', N'2021-12-04 00:00:00', 1, N'carlosr', N'https://viajes.nationalgeographic.com.es/medio/2020/02/13/fuerteventura_f9cff96a_1280x720.jpg');
INSERT INTO firstrow_.dbo.Stories (id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES (3, N'viaje tokio', N'descripcion tokio', N'2019-02-25 00:00:00', 4, N'pepe', N'https://japonismo.com/wp-content/uploads/2021/06/guia-turistica-tokio-japonismo.jpg');

