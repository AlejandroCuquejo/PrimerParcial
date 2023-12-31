PGDMP         3                {            PrimerParcialDB3    14.6    14.6 +               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    36456    PrimerParcialDB3    DATABASE     q   CREATE DATABASE "PrimerParcialDB3" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Spanish_Paraguay.1252';
 "   DROP DATABASE "PrimerParcialDB3";
                postgres    false            �            1259    36458    ciudad    TABLE     �   CREATE TABLE public.ciudad (
    id_ciudad integer NOT NULL,
    ciudad character varying(20),
    departamento character varying(20),
    postal_code integer
);
    DROP TABLE public.ciudad;
       public         heap    postgres    false            �            1259    36457    ciudad_id_ciudad_seq    SEQUENCE     }   CREATE SEQUENCE public.ciudad_id_ciudad_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.ciudad_id_ciudad_seq;
       public          postgres    false    210                       0    0    ciudad_id_ciudad_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.ciudad_id_ciudad_seq OWNED BY public.ciudad.id_ciudad;
          public          postgres    false    209            �            1259    36472    cliente    TABLE     �   CREATE TABLE public.cliente (
    id_cliente integer NOT NULL,
    id_persona integer NOT NULL,
    fecha_ingreso date,
    calificacion character varying(10),
    estado character varying(5)
);
    DROP TABLE public.cliente;
       public         heap    postgres    false            �            1259    36471    cliente_id_cliente_seq    SEQUENCE        CREATE SEQUENCE public.cliente_id_cliente_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.cliente_id_cliente_seq;
       public          postgres    false    214                       0    0    cliente_id_cliente_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.cliente_id_cliente_seq OWNED BY public.cliente.id_cliente;
          public          postgres    false    213            �            1259    36479    cuentas    TABLE     �  CREATE TABLE public.cuentas (
    id_cliente integer NOT NULL,
    nro_cuenta character varying(20),
    fecha_alta date,
    tipo_cuenta character varying(20),
    estado character varying(10),
    saldo numeric(50,0),
    nro_contrato character varying(50),
    costo_mantenimiento numeric(50,0),
    promedio_acreditacion character varying(30),
    moneda character varying(20),
    id_cuentas integer NOT NULL
);
    DROP TABLE public.cuentas;
       public         heap    postgres    false            �            1259    36520    cuentas_id_cuentas_seq    SEQUENCE     �   CREATE SEQUENCE public.cuentas_id_cuentas_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.cuentas_id_cuentas_seq;
       public          postgres    false    215                        0    0    cuentas_id_cuentas_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.cuentas_id_cuentas_seq OWNED BY public.cuentas.id_cuentas;
          public          postgres    false    218            �            1259    36486 
   movimiento    TABLE     �  CREATE TABLE public.movimiento (
    id_movimiento integer NOT NULL,
    id_cuentas integer NOT NULL,
    fecha_movimiento date,
    tipo_movimiento character varying(20),
    saldo_anterior numeric(20,0),
    saldo_actual numeric(20,0),
    monto_movimiento numeric(20,0),
    cuenta_origen numeric(20,0),
    cuenta_destino numeric(20,0),
    canal_decimal character varying(20)
);
    DROP TABLE public.movimiento;
       public         heap    postgres    false            �            1259    36485    movimiento_id_movimiento_seq    SEQUENCE     �   CREATE SEQUENCE public.movimiento_id_movimiento_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.movimiento_id_movimiento_seq;
       public          postgres    false    217            !           0    0    movimiento_id_movimiento_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.movimiento_id_movimiento_seq OWNED BY public.movimiento.id_movimiento;
          public          postgres    false    216            �            1259    36465    persona    TABLE     [  CREATE TABLE public.persona (
    id_persona integer NOT NULL,
    id_ciudad integer NOT NULL,
    nombre character varying(20),
    apellido character varying(20),
    nro_documento character varying(20),
    direccion character varying(50),
    celular character varying(15),
    email character varying(50),
    estado character varying(20)
);
    DROP TABLE public.persona;
       public         heap    postgres    false            �            1259    36464    persona_id_persona_seq    SEQUENCE        CREATE SEQUENCE public.persona_id_persona_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.persona_id_persona_seq;
       public          postgres    false    212            "           0    0    persona_id_persona_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.persona_id_persona_seq OWNED BY public.persona.id_persona;
          public          postgres    false    211            p           2604    36461    ciudad id_ciudad    DEFAULT     t   ALTER TABLE ONLY public.ciudad ALTER COLUMN id_ciudad SET DEFAULT nextval('public.ciudad_id_ciudad_seq'::regclass);
 ?   ALTER TABLE public.ciudad ALTER COLUMN id_ciudad DROP DEFAULT;
       public          postgres    false    209    210    210            r           2604    36475    cliente id_cliente    DEFAULT     x   ALTER TABLE ONLY public.cliente ALTER COLUMN id_cliente SET DEFAULT nextval('public.cliente_id_cliente_seq'::regclass);
 A   ALTER TABLE public.cliente ALTER COLUMN id_cliente DROP DEFAULT;
       public          postgres    false    213    214    214            s           2604    36521    cuentas id_cuentas    DEFAULT     x   ALTER TABLE ONLY public.cuentas ALTER COLUMN id_cuentas SET DEFAULT nextval('public.cuentas_id_cuentas_seq'::regclass);
 A   ALTER TABLE public.cuentas ALTER COLUMN id_cuentas DROP DEFAULT;
       public          postgres    false    218    215            t           2604    36489    movimiento id_movimiento    DEFAULT     �   ALTER TABLE ONLY public.movimiento ALTER COLUMN id_movimiento SET DEFAULT nextval('public.movimiento_id_movimiento_seq'::regclass);
 G   ALTER TABLE public.movimiento ALTER COLUMN id_movimiento DROP DEFAULT;
       public          postgres    false    217    216    217            q           2604    36468    persona id_persona    DEFAULT     x   ALTER TABLE ONLY public.persona ALTER COLUMN id_persona SET DEFAULT nextval('public.persona_id_persona_seq'::regclass);
 A   ALTER TABLE public.persona ALTER COLUMN id_persona DROP DEFAULT;
       public          postgres    false    211    212    212                      0    36458    ciudad 
   TABLE DATA           N   COPY public.ciudad (id_ciudad, ciudad, departamento, postal_code) FROM stdin;
    public          postgres    false    210   4                 0    36472    cliente 
   TABLE DATA           ^   COPY public.cliente (id_cliente, id_persona, fecha_ingreso, calificacion, estado) FROM stdin;
    public          postgres    false    214   %4                 0    36479    cuentas 
   TABLE DATA           �   COPY public.cuentas (id_cliente, nro_cuenta, fecha_alta, tipo_cuenta, estado, saldo, nro_contrato, costo_mantenimiento, promedio_acreditacion, moneda, id_cuentas) FROM stdin;
    public          postgres    false    215   B4                 0    36486 
   movimiento 
   TABLE DATA           �   COPY public.movimiento (id_movimiento, id_cuentas, fecha_movimiento, tipo_movimiento, saldo_anterior, saldo_actual, monto_movimiento, cuenta_origen, cuenta_destino, canal_decimal) FROM stdin;
    public          postgres    false    217   _4                 0    36465    persona 
   TABLE DATA           |   COPY public.persona (id_persona, id_ciudad, nombre, apellido, nro_documento, direccion, celular, email, estado) FROM stdin;
    public          postgres    false    212   |4       #           0    0    ciudad_id_ciudad_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.ciudad_id_ciudad_seq', 2, true);
          public          postgres    false    209            $           0    0    cliente_id_cliente_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.cliente_id_cliente_seq', 2, true);
          public          postgres    false    213            %           0    0    cuentas_id_cuentas_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.cuentas_id_cuentas_seq', 6, true);
          public          postgres    false    218            &           0    0    movimiento_id_movimiento_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.movimiento_id_movimiento_seq', 6, true);
          public          postgres    false    216            '           0    0    persona_id_persona_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.persona_id_persona_seq', 2, true);
          public          postgres    false    211            v           2606    36463    ciudad ciudad_pk 
   CONSTRAINT     U   ALTER TABLE ONLY public.ciudad
    ADD CONSTRAINT ciudad_pk PRIMARY KEY (id_ciudad);
 :   ALTER TABLE ONLY public.ciudad DROP CONSTRAINT ciudad_pk;
       public            postgres    false    210            z           2606    36477    cliente cliente_pk 
   CONSTRAINT     X   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pk PRIMARY KEY (id_cliente);
 <   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_pk;
       public            postgres    false    214            |           2606    36523    cuentas cuentas_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.cuentas
    ADD CONSTRAINT cuentas_pkey PRIMARY KEY (id_cuentas);
 >   ALTER TABLE ONLY public.cuentas DROP CONSTRAINT cuentas_pkey;
       public            postgres    false    215            ~           2606    36491    movimiento movimiento_pk 
   CONSTRAINT     a   ALTER TABLE ONLY public.movimiento
    ADD CONSTRAINT movimiento_pk PRIMARY KEY (id_movimiento);
 B   ALTER TABLE ONLY public.movimiento DROP CONSTRAINT movimiento_pk;
       public            postgres    false    217            x           2606    36470    persona persona_pk 
   CONSTRAINT     X   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT persona_pk PRIMARY KEY (id_persona);
 <   ALTER TABLE ONLY public.persona DROP CONSTRAINT persona_pk;
       public            postgres    false    212                       2606    36492    persona ciudad_persona_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT ciudad_persona_fk FOREIGN KEY (id_ciudad) REFERENCES public.ciudad(id_ciudad);
 C   ALTER TABLE ONLY public.persona DROP CONSTRAINT ciudad_persona_fk;
       public          postgres    false    210    212    3190            �           2606    36502    cuentas cliente_cuentas_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.cuentas
    ADD CONSTRAINT cliente_cuentas_fk FOREIGN KEY (id_cliente) REFERENCES public.cliente(id_cliente);
 D   ALTER TABLE ONLY public.cuentas DROP CONSTRAINT cliente_cuentas_fk;
       public          postgres    false    3194    215    214            �           2606    36528     movimiento cuentas_movimiento_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimiento
    ADD CONSTRAINT cuentas_movimiento_fk FOREIGN KEY (id_cuentas) REFERENCES public.cuentas(id_cuentas);
 J   ALTER TABLE ONLY public.movimiento DROP CONSTRAINT cuentas_movimiento_fk;
       public          postgres    false    215    217    3196            �           2606    36497    cliente persona_cliente_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT persona_cliente_fk FOREIGN KEY (id_persona) REFERENCES public.persona(id_persona);
 D   ALTER TABLE ONLY public.cliente DROP CONSTRAINT persona_cliente_fk;
       public          postgres    false    212    214    3192                  x������ � �            x������ � �            x������ � �            x������ � �            x������ � �     