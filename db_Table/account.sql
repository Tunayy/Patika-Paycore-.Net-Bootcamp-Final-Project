PGDMP     ,                    z            finalproject    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24615    finalproject    DATABASE     i   CREATE DATABASE finalproject WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE finalproject;
                postgres    false            �            1259    24616    account    TABLE     �   CREATE TABLE public.account (
    id bigint NOT NULL,
    email character varying NOT NULL,
    password character varying NOT NULL,
    role character varying,
    lastactivity date
);
    DROP TABLE public.account;
       public         heap    postgres    false            �          0    24616    account 
   TABLE DATA           J   COPY public.account (id, email, password, role, lastactivity) FROM stdin;
    public          postgres    false    209   �       g           2606    24620    account account_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    209            �   �   x�3�LI�K�M5rH�M���K����-p��v6�4���rsNL2w�-���4�4202�5��52�2�,)�K�,)-J-r�L��/M�6	,J��5O,�+u��H��HG�m��Z�4�Qd�gebzniQqjЄl�m7D��4�F\1z\\\ ��lr     