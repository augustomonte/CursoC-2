-- 1)
select	D.Titulo, D.FechaLanzamiento, E.Descripcion from DISCOS D, ESTILOS E
where D.IdEstilo = E.Id

-- 2)
select * from ESTILOS

insert into ESTILOS values
('Trap') 
insert into ESTILOS values
('Indie Rock') 

select * from TIPOSEDICION
insert into TIPOSEDICION values
('Casete')

-- 3)
select * from DISCOS
insert into DISCOS values
('Ultimo bondi a Finisterre', '1998-11-18', 10, 'https://www.letras.com/los-redonditos-de-ricota/discografia/ultimo-bondi-a-finisterre-1998/', 3, 1)

insert into DISCOS values
('(Whats the Story) Morning Glory?', '1995-10-2', 12, 'https://biblioteca.ulpgc.es/blogs/theend/2020/10/19/whats-the-story-morning-glory-1995', 6, 2)

-- 4)
update DISCOS set CantidadCanciones = 8 where Id = 4
update DISCOS set IdTipoEdicion = 4 where Id = 4

update DISCOS set FechaLanzamiento = '2026-08-07' where Id = 4

-- 5)
delete from DISCOS where Id = 1

-- 6)
select E.Descripcion, D.Titulo from ESTILOS E, DISCOS D where D.IdEstilo = E.Id


-- 7)
select D.Titulo, E.Descripcion, T.Descripcion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id 

-- 8)
select * from DISCOS where Titulo like '%bon%'