PGDMP     5                    z            finalproject    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24615    finalproject    DATABASE     i   CREATE DATABASE finalproject WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE finalproject;
                postgres    false            �            1259    24623    category    TABLE     f   CREATE TABLE public.category (
    id bigint NOT NULL,
    categoryname character varying NOT NULL
);
    DROP TABLE public.category;
       public         heap    postgres    false            �          0    24623    category 
   TABLE DATA           4   COPY public.category (id, categoryname) FROM stdin;
    public          postgres    false    210   2       g           2606    24629    category category_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.category DROP CONSTRAINT category_pkey;
       public            postgres    false    210            �   ;   x�3��ί�M-���2�I��������2�t-K��Q�H�,K��2�tϬ������� �X5     