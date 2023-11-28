Create DataBase DB_Sistema_De_Facturacion
go

Use DB_Sistema_De_Facturacion
go

---Tabla Clientes---
Create Table Clientes 
(
Id_Cliente int identity(1,1) primary key not null,
Cedula varchar(11) not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Telefono varchar(15) not null,
Direccion varchar(150) not null,
)
go

--- Tabla Productos ---

Create Table Productos 
(
Id_Producto int identity(1,1) primary key not null,
Codigo varchar(15) not null,
CodigoBarra varchar(20) not null, 
Nombre varchar(50) not null,
Descripcion varchar(80) not null,
Costo_Unitario decimal(12,2) not null,
Costo_Alquiler decimal(12,2) not null,
Stock int not null,
)
go


Create Table Empresas
(
Id_Empresa int identity(1,1) primary key not null,
Nit varchar(15) not null,
Nombre varchar(40) not null,
Telefono varchar(15) not null,
Direccion varchar(80) not null, 
Correo varchar(80) not null
)
go

--- Tabla Ventas
Create Table Ventas
(
Id_Venta int identity(1,1) primary key,
Id_Cliente int not null,
No_Factura nvarchar(15) not null,
Fecha_Venta date not null,
Fecha_Validez date not null,
Sub_Total decimal(12,2) not null,
Monto_Total decimal(12,2) not null,
Metodo_Pago nvarchar(25) not null,
Estado varchar(10) not null,
Id_Usuario int
)
go

--Tabla Detalles de ventas
Create Table Detalle_Venta
(
Id_Detalle int identity(1,1) primary key,
Id_Venta int not null,
Id_Producto int not null,
Presentacion varchar(10) not null,
Cantidad int not null,
Precio_Venta decimal(12,2) not null,
Sub_Total decimal(12,2) not null,
Monto_Total decimal(12,2) not null,
)
go

--- Tabla Alquiler
Create Table Alquiler
(
Id_Alquiler int identity(1,1) primary key,
Id_Cliente int not null,
No_Factura nvarchar(15) not null,
Fecha_Alquiler date not null,
Fecha_Validez date not null,
Monto_Total decimal(12,2) not null,
Metodo_Pago nvarchar(25) not null,
Estado varchar(10) not null,
)
go

--Tabla Detalles de alquiler
Create Table Detalle_Alquiler
(
Id_Detalle_A int identity(1,1) primary key,
Id_Alquiler int not null,
Id_Producto int not null,
Duracion int not null,
Precio_Alquiler decimal(12,2) not null,
Monto_Total decimal(12,2) not null,
Cantidad int not null,
)
go


--Tabla Usuario
Create Table Usuarios
(
Id_Usuario int identity(1,1) primary key,
Nombre varchar(50) not null,
Apellidos varchar(50) not null,
Usuario varchar(30) not null,
Password varchar(20) not null,
)
go

CREATE TABLE Metodo_Pago(
    Id_Metodo_Pago INT PRIMARY KEY,
    Nombre_Metodo VARCHAR(50)
);
--------------------------------------------------------------
--------------------------------------------------------------
--------------------------------------------------------------

---- Agregar Cliente ------
Create Proc AgregarCliente
@Cedula varchar(11),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(15),
@Direccion varchar(150)
as
Insert Into Clientes(Cedula,Nombre,Apellido,Telefono,Direccion)
Values(@Cedula,@Nombre,@Apellido,@Telefono,@Direccion)
go

---- Editar Cliente ------
Create Proc EditarCliente
@Id_Cliente int,
@Cedula varchar(11),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(15),
@Direccion varchar(150)
as
Update Clientes Set Cedula=@Cedula,Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,
Direccion=@Direccion where Id_Cliente=@Id_Cliente
go

---- Eliminar Cliente ------
Create Proc EliminarCliente
@Id_Cliente int
as
Delete From Clientes where Id_Cliente=@Id_Cliente
go

---- Buscar Cliente Por Codigo ----
Create Proc Buscar_Cliente_Id
@Buscar varchar(50)
as
Select * From Clientes Where Id_Cliente Like @Buscar + '%'
go

---- Buscar Cliente Por Nombre ----
Create Proc Buscar_Cliente_Nombre
@Buscar varchar(50)
as
Select * From Clientes Where Nombre Like @Buscar + '%'
go

---- Buscar Cliente Por cedula ----
Create Proc Buscar_Cliente_Cedula
@Buscar varchar(50)
as
Select * From Clientes Where Cedula Like @Buscar + '%'
go

--------------------------------------------------------------------
--------------------------------------------------------------------
--------------------------------------------------------------------

---- Agregar Empresas ------
Create Proc AgregarEmpresa
@Nit varchar(15),
@Nombre varchar(40),
@Telefono varchar(15),
@Direccion varchar(80), 
@Correo varchar(80)
as
Insert Into Empresas(Nit,Nombre,Telefono,Direccion,Correo)
Values(@Nit,@Nombre,@Telefono,@Direccion,@Correo)
go

---- Editar Empresa ------
Create Proc EditarEmpresa
@Id_Empresa int,
@Nit varchar(15),
@Nombre varchar(40),
@Telefono varchar(15),
@Direccion varchar(80), 
@Correo varchar(80)
as
Update Empresas Set Nit=@Nit,Nombre=@Nombre,Telefono=@Telefono,
Direccion=@Direccion, Correo = @Correo where Id_Empresa=@Id_Empresa
go

---- Eliminar Empresa ------
Create Proc EliminarEmpresa
@Id_Empresa int
as
Delete From Empresas where Id_Empresa=@Id_Empresa
go


---- Buscar Empresa Por Nombre ----
Create Proc Buscar_Empresa_Nombre
@Buscar varchar(50)
as
Select * From Empresas Where Nombre Like @Buscar + '%'
go

---- Buscar Empresa Por cedula ----
Create Proc Buscar_Empresa_Nit
@Buscar varchar(50)
as
Select * From Empresas Where Nit Like @Buscar + '%'
go

-------------------------------------------------------------------
-------------------------------------------------------------------
-------------------------------------------------------------------

---- Agregar Productos------
Create Proc AgregarProducto
@Codigo varchar(15),
@CodigoBarra varchar(20),
@Nombre varchar(50),
@Descripcion varchar(80),
@Costo_Unitario decimal(12,2),
@Costo_Alquiler decimal(12,2),
@Stock int
as
Insert Into Productos(Codigo,CodigoBarra,Nombre,Descripcion,Costo_Unitario,Costo_Alquiler,Stock)
Values(@Codigo,@CodigoBarra,@Nombre,@Descripcion,@Costo_Unitario,@Costo_Alquiler,@Stock)
go

---- Editar Producto ------
Create Proc EditarProducto
@Id_Producto int,
@Codigo varchar(15),
@CodigoBarra varchar(20),
@Nombre varchar(50),
@Descripcion varchar(80),
@Costo_Unitario decimal(12,2),
@Costo_Alquiler decimal(12,2),
@Stock int
as
Update Productos Set Codigo=@Codigo,CodigoBarra = @CodigoBarra,Nombre=@Nombre,Descripcion=@Descripcion,
Costo_Unitario=@Costo_Unitario, Costo_Alquiler = @Costo_Alquiler, Stock = @Stock where Id_Producto=@Id_Producto
go

---- Eliminar Producto ------
Create Proc EliminarProducto
@Id_Producto int
as
Delete From Productos where Id_Producto=@Id_Producto
go


---- Buscar Producto Por Nombre ----
Create Proc Buscar_Producto_Nombre
@Buscar varchar(50)
as
Select * From Productos Where Nombre Like @Buscar + '%'
go

---- Buscar Producto por codigo ----
Create Proc Buscar_Producto_Codigo
@Buscar varchar(50)
as
Select * From Productos Where Codigo Like @Buscar + '%'
go

---- Buscar Producto por codigo ----
Create Proc Buscar_Producto_CodigoBarra
@Buscar varchar(50)
as
Select * From Productos Where CodigoBarra Like @Buscar + '%'
go

-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------


--Ingresar Ventas 
Create Proc AgregarVenta
@Id_Cliente int,
@No_Factura nvarchar(15),
@Fecha_Venta date,
@Fecha_Validez date,
@Sub_Total decimal(12,2),
@Monto_Total decimal(12,2),
@Metodo_Pago nvarchar(25),
@Estado varchar(10),
@Id_Usuario int
as
Insert into Ventas(Id_Cliente,No_Factura,Fecha_Venta,Fecha_Validez,Sub_Total,Monto_Total,Metodo_Pago,Estado,Id_Usuario)
Values(@Id_Cliente,@No_Factura,@Fecha_Venta,@Fecha_Validez,@Sub_Total,@Monto_Total,@Metodo_Pago,@Estado,@Id_Usuario)
go


--Anular Ventas
Create Proc AnularVenta
@Id_Venta int,
@Id_Cliente int,
@No_Factura nvarchar(15),
@Fecha_Venta date,
@Fecha_Validez date,
@Sub_Total decimal(12,2),
@Monto_Total decimal(12,2),
@Metodo_Pago nvarchar(25),
@Estado varchar(10),
@Id_Usuario int
as
Update Ventas Set Id_Cliente = @Id_Cliente, No_Factura=@No_Factura,Fecha_Venta = @Fecha_Venta,Fecha_Validez=@Fecha_Validez,Sub_Total=@Sub_Total,
Monto_Total=@Monto_Total,Metodo_Pago = @Metodo_Pago,Estado = @Estado,Id_Usuario = @Id_Usuario Where Id_Venta=@Id_Venta
go


--Agregar Detalles de Ventas
Create Proc AgregarDetalleVenta
@Id_Venta int,
@Id_Producto int,
@Cantidad int,
@Precio_Venta decimal(12,2),
@Sub_Total decimal(12,2),
@Monto_Total decimal(12,2)
as
Insert into Detalle_Venta (Id_Venta,Id_Producto,Cantidad,Precio_Venta,Sub_Total,Monto_Total)
Values(@Id_Venta,@Id_Producto,@Cantidad,@Precio_Venta,@Sub_Total,@Monto_Total)
go

--Anular Detalles de Ventas 
Create Proc AnularDetalleVenta
@Id_Detalle int,
@Id_Venta int,
@Id_Producto int,
@Cantidad int,
@Precio_Venta decimal(12,2),
@Sub_Total decimal(12,2),
@Monto_Total decimal(12,2)
as
Update Detalle_Venta Set Id_Venta=@Id_Venta,Id_Producto=@Id_Producto,
Cantidad=@Cantidad,Precio_Venta=@Precio_Venta,Sub_Total=@Sub_Total,Monto_Total=@Monto_Total
Where Id_Detalle =@Id_Detalle
go

--Trigger para disminuir los productos
create Trigger Tr_Disminuir_Producto
ON Detalle_Venta
AFTER INSERT
AS
    SET NOCOUNT ON;

    -- Actualizar el stock del producto en la tabla Productos
    UPDATE p
    SET p.Stock = (p.Stock - dv.Cantidad)
    FROM Productos p
    INNER JOIN inserted dv ON p.Id_Producto = dv.Id_Producto;
go


--Trigger para aumentar los productos
Create Trigger Tr_Aumentar_Producto
on Detalle_Venta for Insert
as
Set Nocount on 
Declare @Id_Producto int
Declare @Cantidad int
Declare @Stock_Actual int
Declare @Costo_Unitario decimal(12,2)
Select @Id_Producto = Id_Producto,@Cantidad = Cantidad From inserted
Select @Stock_Actual=Stock,@Costo_Unitario=Costo_Unitario From Productos Where Id_Producto=@Id_Producto
Update Productos Set Stock=@Stock_Actual + @Cantidad
Where Id_Producto =@Id_Producto
go

--Mostrar los detalles de una ventas
create Proc Mostrar_Detalle_Venta
@Id_Venta int
as
Select DV.Id_Detalle,Pro.Id_Producto,Pro.CodigoBarra,Pro.Nombre,DV.Cantidad,DV.Precio_Venta,DV.Sub_Total,(DV.Cantidad * DV.Precio_Venta) as 'Total'
From Detalle_Venta DV inner join Productos Pro
on DV.Id_Producto = Pro.Id_Producto
Where DV.Id_Venta = @Id_Venta
go

---Mostrar Ventas de Productos
create Proc MostrarVenta

as
Select V.Id_Venta,V.No_Factura,C.Id_Cliente,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
V.Estado, Us.Usuario From Ventas V 
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
go

---Buscar Ventas Producto 
create Proc BuscarVentaCliente
@Buscar nvarchar(100)
as
Select V.No_Factura,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
Us.Usuario From Ventas V
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
Where C.Nombre like @Buscar + '%'
go

---Buscar Ventas Producto por cedula
Create Proc BuscarVentaCedula
@Buscar nvarchar(100)
as
Select V.No_Factura,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
Us.Usuario From Ventas V
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
Where C.Cedula like @Buscar + '%'
go

---Buscar Ventas Producto por monto_total
Create Proc BuscarVentaMonto_Total
@Buscar nvarchar(100)
as
Select V.No_Factura,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
Us.Usuario From Ventas V
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
Where V.Monto_Total like @Buscar + '%'
go

---Buscar Ventas Producto por No Factura
Create Proc BuscarVentaNoFactura
@Buscar nvarchar(100)
as
Select V.No_Factura,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
Us.Usuario From Ventas V
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
Where V.No_Factura like @Buscar + '%'
go
---Buscar Ventas Producto por No Factura
Create Proc BuscarVentaMetodoPago
@Buscar nvarchar(100)
as
Select V.No_Factura,C.Nombre,C.Apellido,C.Cedula,V.Fecha_Venta,V.Fecha_Validez,V.Sub_Total,V.Monto_Total,V.Metodo_Pago,
Us.Usuario From Ventas V
inner join Clientes C on V.Id_Cliente = C.Id_Cliente
inner join Usuarios Us on V.Id_Usuario = Us.Id_Usuario
Where V.Metodo_Pago like @Buscar + '%'
go

---Buscar Ventas Producto por Fecha
create Proc BuscarVentaFecha
@Fecha_Venta date,
@Fecha_Valides date
AS
BEGIN
    SELECT
        V.No_Factura,
        C.Nombre,
        C.Apellido,
        C.Cedula,
        V.Fecha_Venta,
        V.Fecha_Validez,
        V.Sub_Total,
        V.Monto_Total,
        V.Metodo_Pago,
        Us.Usuario
    FROM
        Ventas V
    INNER JOIN
        Clientes C ON V.Id_Cliente = C.Id_Cliente
    INNER JOIN
        Usuarios Us ON V.Id_Usuario = Us.Id_Usuario
    WHERE
        V.Fecha_Venta BETWEEN @Fecha_Venta AND @Fecha_Valides
END
go

---Mostrar Ventas Producto 
Create Proc MostrarVentaProductos
@Id_Venta int
as
Select Vent.No_Factura,Vent.Fecha_Venta,Vent.Fecha_Validez,Vent.Sub_Total as 'Sub Total',
Vent.Monto_Total,Vent.Metodo_Pago as 'Metodo de Pago',Vent.Estado,Us.Usuario,Pro.Nombre,DVent.Cantidad,DVent.Precio_Venta as 'Precio',
DVent.Sub_Total as 'Importe',DVent.Monto_Total as 'Total', Cli.Nombre,Cli.Cedula,Cli.Direccion,
Emp.Nit,Emp.Nombre,Emp.Telefono,Emp.Direccion,Emp.Correo
From Ventas Vent inner join Detalle_Venta DVent
on Vent.Id_Venta = DVent.Id_Venta
inner join Productos Pro on DVent.Id_Producto = Pro.Id_Producto
inner join Clientes Cli on Vent.Id_Cliente = Cli.Id_Cliente
inner join Usuarios Us on Vent.Id_Usuario = Us.Id_Usuario
Cross join Empresas Emp
Where Vent.Id_Venta = @Id_Venta
go

--Mostrar productos para la venta
Create Proc Mostrar_Productos_Ventas
as
Select Id_Producto,Codigo,CodigoBarra,Nombre as 'Nombre Producto',Descripcion, Costo_Unitario as 'Precio de Venta', Stock
From Productos
go

--Motrar Factura
create Proc SP_Mostrar_Factura
@Id_Venta int
as
Select Cli.Nombre,Cli.Direccion,Vent.No_Factura,Vent.Fecha_Venta, Met.Nombre_Metodo as 'Metodo_Pagos',
Vent.Metodo_Pago,
Vent.Sub_Total,Vent.Monto_Total,Vent.Estado,(Us.Nombre + ' '+Us.Apellidos) as Usuario,
Pro.Nombre as 'Descripcion',DVent.Cantidad,
DVent.Precio_Venta,DVent.Monto_Total as 'Total',
Emp.Nombre as 'Empresa', Emp.Nit,Emp.Correo,Emp.Direccion,Emp.Telefono
From Ventas Vent inner join Detalle_Venta DVent on Vent.Id_Venta = DVent.Id_Venta
inner join Clientes Cli on Vent.Id_Cliente = Cli.Id_Cliente
inner join Productos Pro on DVent.Id_Producto = Pro.Id_Producto
inner join Usuarios Us on Vent.Id_Usuario = Us.Id_Usuario
Cross join Empresas Emp
Cross join Metodo_Pago Met
Where Vent.Id_Venta =@Id_Venta
go

---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------

--agregar Alquiler
Create Proc AgregarAlquiler
@Id_Cliente int,
@No_Factura nvarchar(15),
@Fecha_Alquiler date,
@Fecha_Validez date ,
@Monto_Total decimal(12,2),
@Metodo_Pago nvarchar(25),
@Estado varchar(10)
as
Insert into Alquiler(Id_Cliente,No_Factura,Fecha_Alquiler,Fecha_Validez,Monto_Total,Metodo_Pago,Estado)
Values(@Id_Cliente,@No_Factura,@Fecha_Alquiler,@Fecha_Validez,@Monto_Total,@Metodo_Pago,@Estado)
go


--Anular Alquiler
Create Proc AnularAlquiler
@Id_Alquiler int, 
@Id_Cliente int,
@No_Factura nvarchar(15),
@Fecha_Alquiler date,
@Fecha_Validez date ,
@Monto_Total decimal(12,2),
@Metodo_Pago nvarchar(25),
@Estado varchar(10)
as
Update Alquiler Set Id_Cliente = @Id_Cliente, No_Factura=@No_Factura,Fecha_Alquiler = @Fecha_Alquiler,Fecha_Validez=@Fecha_Validez,
Monto_Total=@Monto_Total,Metodo_Pago=@Metodo_Pago,Estado = @Estado Where Id_Alquiler=@Id_Alquiler
go


--Agregar Detalles de Alquiler
Create Proc AgregarDetalleAlquiler
@Id_Alquiler int,
@Id_Producto int,
@Duracion int,
@Precio_Alquiler decimal(12,2),
@Monto_Total decimal(12,2)
as
Insert into Detalle_Alquiler(Id_Alquiler,Id_Producto,Duracion,Precio_Alquiler,Monto_Total, Cantidad)
Values(@Id_Alquiler,@Id_Producto,@Duracion,@Precio_Alquiler,@Monto_Total, 1)
go

--Anular Detalles de Alquiler 
create Proc AnularDetalleAlquiler
@Id_Detalle_Alquiler int,
@Id_Alquiler int,
@Id_Producto int,
@Duracion int,
@Precio_Alquiler decimal(12,2),
@Monto_Total decimal(12,2)
as
Update Detalle_Alquiler Set Id_Alquiler=@Id_Alquiler,Id_Producto=@Id_Producto,
Duracion=@Duracion,Precio_Alquiler=@Precio_Alquiler, Monto_Total=@Monto_Total, Cantidad = 1
Where Id_Detalle_A = @Id_Detalle_Alquiler
go

--Mostrar los detalles de una Alquiler
Create Proc Mostrar_Detalle_Alquiler
@Id_Alquiler int
as
Select Da.Id_Detalle_A,Pro.Id_Producto,Pro.CodigoBarra,Pro.Nombre,Da.Duracion,Da.Precio_Alquiler,(Da.Duracion * Da.Precio_Alquiler) as 'Total'
From Detalle_Alquiler Da inner join Productos Pro
on Da.Id_Producto = Pro.Id_Producto
Where Da.Id_Alquiler = @Id_Alquiler
go

---Mostrar Alquiler de Productos
Create Proc MostrarAlquiler
as
Select A.Id_Alquiler,A.No_Factura,C.Id_Cliente,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago,
A.Estado From Alquiler A 
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
go

---Buscar Cliente
create Proc BuscarAlquilerCliente
@Buscar nvarchar(100)
as
Select A.No_Factura,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago 
From Alquiler A
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
Where C.Nombre like @Buscar + '%'
go

---Buscar Cedula
Create Proc BuscarAlquilerCedula
@Buscar nvarchar(100)
as
Select A.No_Factura,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago 
From Alquiler A
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
Where C.Cedula like @Buscar + '%'
go

---Buscar monto total
Create Proc BuscarAlquilerMontoTotal
@Buscar nvarchar(100)
as
Select A.No_Factura,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago 
From Alquiler A
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
Where A.Monto_Total like @Buscar + '%'
go

---Buscar no factura
Create Proc BuscarAlquilerNoFactura
@Buscar nvarchar(100)
as
Select A.No_Factura,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago 
From Alquiler A
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
Where A.No_Factura like @Buscar + '%'
go

---Buscar Metodo Pago
Create Proc BuscarAlquilerMetodoPago
@Buscar nvarchar(100)
as
Select A.No_Factura,C.Nombre,C.Apellido,C.Cedula,A.Fecha_Alquiler,A.Fecha_Validez,A.Monto_Total,A.Metodo_Pago 
From Alquiler A
inner join Clientes C on A.Id_Cliente = C.Id_Cliente
Where A.Metodo_Pago like @Buscar + '%'
go

---Buscar FechaAlquiler
create Proc BuscarAlquilerFechaAlquiler
@Fecha_Alquiler date,
@Fecha_Valides date
AS
BEGIN
    SELECT
        A.No_Factura,
        C.Nombre,
        C.Apellido,
        C.Cedula,
        A.Fecha_Alquiler,
        A.Fecha_Validez,
        A.Monto_Total,
        A.Metodo_Pago
    FROM
        Alquiler A
    INNER JOIN
        Clientes C ON A.Id_Cliente = C.Id_Cliente
    WHERE
        A.Fecha_Alquiler BETWEEN @Fecha_Alquiler AND @Fecha_Valides
END
go

---Mostrar Alquiler Producto 
Create Proc MostrarAlquilerProductos
@Id_Alquiler int
as
Select Alqui.No_Factura,Alqui.Fecha_Alquiler,Alqui.Fecha_Validez,Alqui.Monto_Total,Alqui.Metodo_Pago as 'Metodo Pago',
Alqui.Estado,Pro.Nombre,DAlqui.Duracion,DAlqui.Precio_Alquiler as 'Precio',
DAlqui.Monto_Total as 'Total', Cli.Nombre,Cli.Cedula,Cli.Direccion,
Emp.Nit,Emp.Nombre,Emp.Telefono,Emp.Direccion,Emp.Correo
From Alquiler Alqui inner join Detalle_Alquiler DAlqui
on Alqui.Id_Alquiler = DAlqui.Id_Alquiler
inner join Productos Pro on DAlqui.Id_Producto = Pro.Id_Producto
inner join Clientes Cli on Alqui.Id_Cliente = Cli.Id_Cliente
Cross join Empresas Emp
Where Alqui.Id_Alquiler = @Id_Alquiler
go

--Mostrar productos para la Alquiler
Create Proc Mostrar_Productos_Alquiler
as
Select Id_Producto,Codigo,CodigoBarra,Nombre as 'Nombre Producto',Descripcion, Costo_Alquiler as 'Precio de Alquiler', Stock
From Productos
go

--Motrar Factura
create Proc SP_Mostrar_Factura_Alquiler
@Id_Alquiler int
as
Select Cli.Nombre,Cli.Direccion,Alqui.No_Factura,Alqui.Fecha_Alquiler,
Alqui.Monto_Total,Alqui.Metodo_Pago,Alqui.Estado,
Pro.Nombre as 'Descripcion',DAlqui.Duracion,
DAlqui.Precio_Alquiler,DAlqui.Monto_Total as 'Total',
Emp.Nombre as 'Empresa', Emp.Nit,Emp.Correo,Emp.Direccion,Emp.Telefono
From Alquiler Alqui inner join Detalle_Alquiler DAlqui on Alqui.Id_Alquiler = DAlqui.Id_Alquiler
inner join Clientes Cli on Alqui.Id_Cliente = Cli.Id_Cliente
inner join Productos Pro on DAlqui.Id_Producto = Pro.Id_Producto
Cross join Empresas Emp
Where Alqui.Id_Alquiler =@Id_Alquiler
go
---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------



---Agregar Usuario
Create Proc SP_Agregar_Usuario
@Nombre varchar(50),
@Apellidos varchar(50),
@Usuario varchar(30),
@Password varchar(20)
as
Insert Into Usuarios(Nombre,Apellidos,Usuario,Password)
Values(@Nombre,@Apellidos,@Usuario,@Password)
go

---Editar Usuario
Create Proc SP_Editar_Usuario
@Id_Usuario int,
@Nombre varchar(50),
@Apellidos varchar(50),
@Usuario varchar(30),
@Password varchar(20)
as
Update Usuarios Set Nombre=@Nombre,Apellidos=@Apellidos,Usuario=@Usuario,Password=@Password
Where Id_Usuario=@Id_Usuario
go

---Eliminar Usuario
Create Proc SP_Eliminar_Usuario
@Id_Usuario int
as
Delete From Usuarios Where Id_Usuario=@Id_Usuario
go

---Login
Create Proc SP_Login
@Usuario varchar(30),
@Password varchar(20)
as
Select * From Usuarios Where Usuario = @Usuario And Password = @Password
go

---Mostrar informacion del Usuario logeado
Create Proc SP_DatosUsuario
@Usuario varchar(30)
as
Select * From Usuarios Where Usuario = @Usuario
go



--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------


insert into Metodo_Pago(Id_Metodo_Pago,Nombre_Metodo) Values(01, 'EFECTIVO');
insert into Metodo_Pago(Id_Metodo_Pago,Nombre_Metodo) Values(02, 'TARJETA DE CREDITO');
insert into Metodo_Pago(Id_Metodo_Pago,Nombre_Metodo) Values(03, 'TRANSFERENCIA BANCARIA');


CREATE PROC BuscarClientePorCedula
@Cedula VARCHAR(11)
AS
 SELECT * FROM Clientes WHERE Cedula = @Cedula
go

CREATE PROC BuscarProductoPorCodigoBarra
@CodigoBarra VARCHAR(20)
AS
 SELECT * FROM Productos WHERE CodigoBarra = @CodigoBarra
go


Create PROC ObtenerProductosmasvendido
AS
BEGIN
    SELECT
	Top 1
        P.Id_Producto,P.Codigo,P.CodigoBarra,P.Nombre as 'Nombre Producto',P.Descripcion,
        P.Costo_Unitario as 'Precio de Venta',P.Stock,SUM(DV.Cantidad) as 'Cantidad Vendida'
    FROM Detalle_Venta DV
    INNER JOIN Productos P ON DV.Id_Producto = P.Id_Producto
    GROUP BY P.Id_Producto,P.Codigo,P.CodigoBarra,P.Nombre,P.Descripcion,P.Costo_Unitario,P.Stock
    ORDER BY SUM(DV.Cantidad) DESC;
END;
