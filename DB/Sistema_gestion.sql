Create database SellPoint
use SellPoint

----TABLE ENTIDADES---------
Create table Entidades
(
	IdEntidad int primary key identity,
	Descripcion varchar(120),
	Direccion varchar(120),
	Localidad varchar(40),
	TipoEntidad varchar(8),
	TipoDocumento varchar(9),
	NumeroDocumento bigint,
	Telefonos varchar(60),
	URLPaginaWeb varchar(120),
	URLFacebook varchar(120),
	URLInstagram varchar(120),
	URLTwitter varchar(120),
	URLTikTok varchar(120),
	CodigoPostal varchar(10),
	CoordenadasGPS varchar(255),
	LimiteCredito decimal(15,2) check(LimiteCredito>=0),
	UserNameEntidad nvarchar(60),
	PasswordEntidad nvarchar(30),
	RolUserEntidad nvarchar(20),
	Comentario varchar(60),
	Estado nvarchar(20),
	NoEliminable bit,
	FechaRegistro Date

);

-----------------PROC INSERTAR--------------------
Create proc InsertarEntidades
@Descripcion varchar(120),
@Direccion varchar(120),
@Localidad varchar(40),
@TipoEntidad varchar(8),
@TipoDocumento varchar(9),
@NumeroDocumento bigint,
@Telefonos varchar(60),
@URLPaginaWeb varchar(120),
@URLFacebook varchar(120),
@URLInstagram varchar(120),
@URLTwitter varchar(120),
@URLTikTok varchar(120),
@CodigoPostal varchar(10),
@CoordenadasGPS varchar(255),
@LimiteCredito decimal(15,2),
@UserNameEntidad nvarchar(60),
@PasswordEntidad nvarchar(30),
@RolUserEntidad nvarchar(20),
@Comentario varchar(60),
@Estado nvarchar(20),
@NoEliminable bit,
@FechaRegistro Date
as
insert into Entidades values(@Descripcion, @Direccion, @Localidad, @TipoEntidad, @TipoDocumento, @NumeroDocumento, @Telefonos, @URLPaginaWeb, @URLFacebook, @URLInstagram, @URLTwitter, @URLTikTok, @CodigoPostal, @CoordenadasGPS, @LimiteCredito, @UserNameEntidad, @PasswordEntidad, @RolUserEntidad, @Comentario, @Estado, @NoEliminable, @FechaRegistro)
GO


-----------------PROC EDITAR--------------------
Create proc EditarEntidades
@Descripcion varchar(120),
@Direccion varchar(120),
@Localidad varchar(40),
@TipoEntidad varchar(8),
@TipoDocumento varchar(9),
@NumeroDocumento bigint,
@Telefonos varchar(60),
@URLPaginaWeb varchar(120),
@URLFacebook varchar(120),
@URLInstagram varchar(120),
@URLTwitter varchar(120),
@URLTikTok varchar(120),
@CodigoPostal varchar(10),
@CoordenadasGPS varchar(255),
@LimiteCredito decimal(15,2),
@UserNameEntidad nvarchar(60),
@PasswordEntidad nvarchar(30),
@RolUserEntidad nvarchar(20),
@Comentario varchar(60),
@Estado nvarchar(20),
@NoEliminable bit,
@FechaRegistro getdate(),
@IdEntidad int
as
update Entidades set Descripcion = @Descripcion, Direccion = @Direccion, Localidad = @Localidad, TipoEntidad = @TipoEntidad, TipoDocumento= @TipoDocumento, NumeroDocumento = @NumeroDocumento, Telefonos = @Telefonos, URLPaginaWeb = @URLPaginaWeb, URLFacebook = @URLFacebook, URLInstagram = @URLInstagram, URLTwitter = @URLTwitter, URLTikTok = @URLTikTok, CodigoPostal = @CodigoPostal, CoordenadasGPS = @CoordenadasGPS, LimiteCredito = @LimiteCredito, UserNameEntidad = @UserNameEntidad, PasswordEntidad = @PasswordEntidad, RolUserEntidad = @RolUserEntidad, Comentario = @Comentario, Estado = @Estado, NoEliminable = @NoEliminable, FechaRegistro = @FechaRegistro 
where IdEntidad = @IdEntidad
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


------PROC MOSTRAR ENTIDADES--------------------------------------
Create proc MostrarEntidades
as
select * from Entidades E
go
exec MostrarEntidades
---------------------------------------------------------------------------------------------------------------------


--------PROC CREATEUSER--------------------------------------------------------------------------------------------

create proc Crearusuarios
@user varchar(100),
@Pass varchar(100)
as
insert into Entidades(UserNameEntidad, PasswordEntidad) values(@user,@Pass)

execute Crearusuarios 'Carlos', 'Carlos.123321'

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



---------PROC ELIMINARENTIDAD----------------------------------------------------------------------------------------------------------------------------


Create proc EliminarEntidades
@IdEntidad int
as
delete from Entidades where IdEntidad=@IdEntidad
GO

exec EliminarEntidades 2

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


---------PROC LOGIN-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

create proc Logear
@usuario varchar(100),
@password varchar(100)
as
select * from Entidades where UserNameEntidad=@usuario and PasswordEntidad=@password

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


---------TRANSACT SQL---------------------------------------------------------------------------------------------------------------------------------------------------

select * from Entidades

execute InsertarEntidades 'Encargado de sistemas', 'Acapulco calle 17 de octubre', 'san pedro', 'Usuario', 'Cédula', 1232234663, '8096532154/803365367', 'H','O','L','A','G','3231','ashdakjdbakbds',143.12,'Perez','Perez.123','Contable','Buen desempeño', 'Activo',1,'1998-06-04'



insert into Entidades(Descripcion,Direccion,Localidad, TipoEntidad,TipoDocumento,NumeroDocumento, Telefonos, URLPaginaWeb, URLFacebook, URLInstagram, URLTwitter, URLTikTok, CodigoPostal, CoordenadasGPS) values('ola','Adio','Null', 'dog', 'cedula', 12232123456, '5466254325', 'lkjk', 'ldas','dsada', 'dasdasd', 'asdasd', '5415', 'dasdas');

insert into Entidades values
('Encargado de sistemas', 'Acapulco calle 17 de octubre', 'Cotui', 'Usuario', 'Cédula', 1232234654, '8096532154/803365367', 'H','O','L','A','G',1,'ashdakjdbakbds',1743.12,'Luis','Morla.123321','Contable','Buen desempeño', 'Activo',1,'1998-06-04');


-----------------------------------------------------------------------------------------------------------------------------------------------------------


------------INDICES-------------------------------

Create nonclustered index IDX_Description
on Entidades(Descripcion)

Execute sp_helpindex 'Entidades'


Create nonclustered index IDX_NumDocumento
on Entidades(NumeroDocumento) 

------------------------------------------------------------------------------------------------------------------------------------------------------------------------



