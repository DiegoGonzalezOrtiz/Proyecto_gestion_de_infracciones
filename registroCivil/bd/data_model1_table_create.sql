CREATE TABLE public.vehiculo (
    id_vehiculo SERIAL NOT NULL,
    id_propietario bigint NOT NULL,
    patente varchar(15) NOT NULL,
    marca varchar(100) NOT NULL,
    modelo varchar(100) NOT NULL,
    version varchar(100) NOT NULL,
    anio integer NOT NULL,
    PRIMARY KEY (id_vehiculo)
);

CREATE INDEX ON public.vehiculo
    (id_propietario);


CREATE TABLE public.propietario (
    id_propietario SERIAL NOT NULL,
    run varchar(15) NOT NULL,
    nombre varchar(100) NOT NULL,
    apellido_paterno varchar(100) NOT NULL,
    apellido_materno varchar(100),
    PRIMARY KEY (id_propietario)
);

