PGDMP                         z            finalproject    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24615    finalproject    DATABASE     i   CREATE DATABASE finalproject WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE finalproject;
                postgres    false            �            1259    32800    auth    TABLE     Q   CREATE TABLE public.auth (
    id bigint NOT NULL,
    mail character varying
);
    DROP TABLE public.auth;
       public         heap    postgres    false            �          0    32800    auth 
   TABLE DATA           (   COPY public.auth (id, mail) FROM stdin;
    public          postgres    false    213   �       g           2606    32806    auth auth_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.auth
    ADD CONSTRAINT auth_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.auth DROP CONSTRAINT auth_pkey;
       public            postgres    false    213            �   $   x�3�,)�K�,)-J-rH�M���K������� �		     