PGDMP     
                    z            finalproject    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24615    finalproject    DATABASE     i   CREATE DATABASE finalproject WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE finalproject;
                postgres    false            �            1259    24650    product    TABLE     �  CREATE TABLE public.product (
    id bigint NOT NULL,
    productname character varying,
    explanation character varying,
    color character varying,
    brand character varying,
    price bigint,
    categoryid bigint,
    issold character varying,
    offers bigint,
    isofferable character varying,
    productowner character varying,
    offerowner character varying,
    offerstatus character varying
);
    DROP TABLE public.product;
       public         heap    postgres    false            �          0    24650    product 
   TABLE DATA           �   COPY public.product (id, productname, explanation, color, brand, price, categoryid, issold, offers, isofferable, productowner, offerowner, offerstatus) FROM stdin;
    public          postgres    false    212   �       g           2606    24656    product product_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.product DROP CONSTRAINT product_pkey;
       public            postgres    false    212            �   h  x���=n�@F��)��^L�(H��f���ǫ�5��%5}:�^����d���}��֓�j�ɳr�:�8XV�������:>m�3�aF=n C�U]�%���0}�	zl\��E��8d;��n�<}.��p>k[�������_ ��pV�V	1���J�8S�h=���w�<�B�x���� @�2�c�-�RT,D�r�%�=���^���`p��H�a�=T�+w:�c(��BJ�x%^���<�K���Uz|w�b�!ȼ��-��QNK�Y�3�S=I�)Zʎ6�tN��<iiP$J�g�s��q���ލ��\����S��5�F����+���R���QLGEQ| %�     