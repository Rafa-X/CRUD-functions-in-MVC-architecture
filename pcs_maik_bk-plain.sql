--
-- PostgreSQL database dump
--

-- Dumped from database version 15.2
-- Dumped by pg_dump version 15.2

-- Started on 2023-12-09 08:48:01

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 223 (class 1259 OID 24744)
-- Name: compra; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.compra (
    id_compra integer NOT NULL,
    fecha date,
    id_proveedor integer
);


ALTER TABLE public.compra OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 24743)
-- Name: compra_id_compra_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.compra_id_compra_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.compra_id_compra_seq OWNER TO postgres;

--
-- TOC entry 3424 (class 0 OID 0)
-- Dependencies: 222
-- Name: compra_id_compra_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.compra_id_compra_seq OWNED BY public.compra.id_compra;


--
-- TOC entry 233 (class 1259 OID 32897)
-- Name: detalle_compra; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detalle_compra (
    id_detalle_compra integer NOT NULL,
    id_compra integer,
    id_producto integer,
    cantidad smallint,
    precio_compra double precision
);


ALTER TABLE public.detalle_compra OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 32896)
-- Name: detalle_compra_id_detalle_compra_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.detalle_compra_id_detalle_compra_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.detalle_compra_id_detalle_compra_seq OWNER TO postgres;

--
-- TOC entry 3425 (class 0 OID 0)
-- Dependencies: 232
-- Name: detalle_compra_id_detalle_compra_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.detalle_compra_id_detalle_compra_seq OWNED BY public.detalle_compra.id_detalle_compra;


--
-- TOC entry 221 (class 1259 OID 24727)
-- Name: detalle_merma; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detalle_merma (
    id_detalle_merma integer NOT NULL,
    id_merma smallint,
    id_producto smallint,
    cantidad smallint,
    precio double precision,
    clasificacion character varying(8)
);


ALTER TABLE public.detalle_merma OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 24726)
-- Name: detalle_merma_id_merma_prod_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.detalle_merma_id_merma_prod_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.detalle_merma_id_merma_prod_seq OWNER TO postgres;

--
-- TOC entry 3426 (class 0 OID 0)
-- Dependencies: 220
-- Name: detalle_merma_id_merma_prod_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.detalle_merma_id_merma_prod_seq OWNED BY public.detalle_merma.id_detalle_merma;


--
-- TOC entry 231 (class 1259 OID 32880)
-- Name: detalle_venta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detalle_venta (
    id_detalle_venta integer NOT NULL,
    id_venta integer,
    id_producto integer,
    cantidad smallint,
    precio_venta double precision
);


ALTER TABLE public.detalle_venta OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 32879)
-- Name: detalle_venta_id_detalle_venta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.detalle_venta_id_detalle_venta_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.detalle_venta_id_detalle_venta_seq OWNER TO postgres;

--
-- TOC entry 3427 (class 0 OID 0)
-- Dependencies: 230
-- Name: detalle_venta_id_detalle_venta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.detalle_venta_id_detalle_venta_seq OWNED BY public.detalle_venta.id_detalle_venta;


--
-- TOC entry 215 (class 1259 OID 24689)
-- Name: empleado; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.empleado (
    id_empleado integer NOT NULL,
    estado boolean,
    cargo character varying(12),
    nombre character varying(40),
    telefono character varying(10),
    pass character varying(10)
);


ALTER TABLE public.empleado OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 24688)
-- Name: empleado_id_empleado_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.empleado_id_empleado_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.empleado_id_empleado_seq OWNER TO postgres;

--
-- TOC entry 3428 (class 0 OID 0)
-- Dependencies: 214
-- Name: empleado_id_empleado_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.empleado_id_empleado_seq OWNED BY public.empleado.id_empleado;


--
-- TOC entry 227 (class 1259 OID 24793)
-- Name: iva; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.iva (
    id_iva integer NOT NULL,
    fecha_inicio date,
    valor integer
);


ALTER TABLE public.iva OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 24792)
-- Name: iva_id_iva_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.iva_id_iva_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.iva_id_iva_seq OWNER TO postgres;

--
-- TOC entry 3429 (class 0 OID 0)
-- Dependencies: 226
-- Name: iva_id_iva_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.iva_id_iva_seq OWNED BY public.iva.id_iva;


--
-- TOC entry 219 (class 1259 OID 24715)
-- Name: merma; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.merma (
    id_merma integer NOT NULL,
    id_empleado smallint,
    fecha date
);


ALTER TABLE public.merma OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 24714)
-- Name: merma_id_merma_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.merma_id_merma_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.merma_id_merma_seq OWNER TO postgres;

--
-- TOC entry 3430 (class 0 OID 0)
-- Dependencies: 218
-- Name: merma_id_merma_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.merma_id_merma_seq OWNED BY public.merma.id_merma;


--
-- TOC entry 229 (class 1259 OID 24800)
-- Name: producto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.producto (
    id_producto integer NOT NULL,
    id_proveedor smallint,
    nombre character varying(25),
    precio double precision,
    stock smallint,
    stockmin smallint,
    stockmax smallint
);


ALTER TABLE public.producto OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 24799)
-- Name: productos_id_producto_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.productos_id_producto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.productos_id_producto_seq OWNER TO postgres;

--
-- TOC entry 3431 (class 0 OID 0)
-- Dependencies: 228
-- Name: productos_id_producto_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.productos_id_producto_seq OWNED BY public.producto.id_producto;


--
-- TOC entry 217 (class 1259 OID 24696)
-- Name: proveedor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.proveedor (
    id_proveedor integer NOT NULL,
    nombre character varying(30),
    telefono character varying(10),
    direccion character varying(40)
);


ALTER TABLE public.proveedor OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 24695)
-- Name: proveedor_id_proveedor_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.proveedor_id_proveedor_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.proveedor_id_proveedor_seq OWNER TO postgres;

--
-- TOC entry 3432 (class 0 OID 0)
-- Dependencies: 216
-- Name: proveedor_id_proveedor_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.proveedor_id_proveedor_seq OWNED BY public.proveedor.id_proveedor;


--
-- TOC entry 225 (class 1259 OID 24766)
-- Name: venta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.venta (
    id_venta integer NOT NULL,
    fecha date
);


ALTER TABLE public.venta OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 24765)
-- Name: venta_id_venta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.venta_id_venta_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.venta_id_venta_seq OWNER TO postgres;

--
-- TOC entry 3433 (class 0 OID 0)
-- Dependencies: 224
-- Name: venta_id_venta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.venta_id_venta_seq OWNED BY public.venta.id_venta;


--
-- TOC entry 3222 (class 2604 OID 24747)
-- Name: compra id_compra; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.compra ALTER COLUMN id_compra SET DEFAULT nextval('public.compra_id_compra_seq'::regclass);


--
-- TOC entry 3227 (class 2604 OID 32900)
-- Name: detalle_compra id_detalle_compra; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_compra ALTER COLUMN id_detalle_compra SET DEFAULT nextval('public.detalle_compra_id_detalle_compra_seq'::regclass);


--
-- TOC entry 3221 (class 2604 OID 24730)
-- Name: detalle_merma id_detalle_merma; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_merma ALTER COLUMN id_detalle_merma SET DEFAULT nextval('public.detalle_merma_id_merma_prod_seq'::regclass);


--
-- TOC entry 3226 (class 2604 OID 32883)
-- Name: detalle_venta id_detalle_venta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_venta ALTER COLUMN id_detalle_venta SET DEFAULT nextval('public.detalle_venta_id_detalle_venta_seq'::regclass);


--
-- TOC entry 3218 (class 2604 OID 24692)
-- Name: empleado id_empleado; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.empleado ALTER COLUMN id_empleado SET DEFAULT nextval('public.empleado_id_empleado_seq'::regclass);


--
-- TOC entry 3224 (class 2604 OID 24796)
-- Name: iva id_iva; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iva ALTER COLUMN id_iva SET DEFAULT nextval('public.iva_id_iva_seq'::regclass);


--
-- TOC entry 3220 (class 2604 OID 24718)
-- Name: merma id_merma; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.merma ALTER COLUMN id_merma SET DEFAULT nextval('public.merma_id_merma_seq'::regclass);


--
-- TOC entry 3225 (class 2604 OID 24803)
-- Name: producto id_producto; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto ALTER COLUMN id_producto SET DEFAULT nextval('public.productos_id_producto_seq'::regclass);


--
-- TOC entry 3219 (class 2604 OID 24699)
-- Name: proveedor id_proveedor; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedor ALTER COLUMN id_proveedor SET DEFAULT nextval('public.proveedor_id_proveedor_seq'::regclass);


--
-- TOC entry 3223 (class 2604 OID 24769)
-- Name: venta id_venta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.venta ALTER COLUMN id_venta SET DEFAULT nextval('public.venta_id_venta_seq'::regclass);


--
-- TOC entry 3408 (class 0 OID 24744)
-- Dependencies: 223
-- Data for Name: compra; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.compra (id_compra, fecha, id_proveedor) FROM stdin;
1	2023-11-18	1
2	2023-11-22	1
\.


--
-- TOC entry 3418 (class 0 OID 32897)
-- Dependencies: 233
-- Data for Name: detalle_compra; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detalle_compra (id_detalle_compra, id_compra, id_producto, cantidad, precio_compra) FROM stdin;
1	1	1	5	1000
2	1	2	3	200
3	2	3	2	400
4	2	2	3	200
\.


--
-- TOC entry 3406 (class 0 OID 24727)
-- Dependencies: 221
-- Data for Name: detalle_merma; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detalle_merma (id_detalle_merma, id_merma, id_producto, cantidad, precio, clasificacion) FROM stdin;
1	1	1	2	1000	Roto
\.


--
-- TOC entry 3416 (class 0 OID 32880)
-- Dependencies: 231
-- Data for Name: detalle_venta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detalle_venta (id_detalle_venta, id_venta, id_producto, cantidad, precio_venta) FROM stdin;
1	1	1	5	1000
2	1	2	10	200
3	2	1	1	1000
4	2	2	3	200
\.


--
-- TOC entry 3400 (class 0 OID 24689)
-- Dependencies: 215
-- Data for Name: empleado; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.empleado (id_empleado, estado, cargo, nombre, telefono, pass) FROM stdin;
2	t	Almacenista	Jorge Campos	3325145695	2gt6d36epl
1	t	Gerente	Cesar Castillo	3325694785	d58ddgyf62
\.


--
-- TOC entry 3412 (class 0 OID 24793)
-- Dependencies: 227
-- Data for Name: iva; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.iva (id_iva, fecha_inicio, valor) FROM stdin;
2	2010-01-01	16
1	2006-01-01	15
\.


--
-- TOC entry 3404 (class 0 OID 24715)
-- Dependencies: 219
-- Data for Name: merma; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.merma (id_merma, id_empleado, fecha) FROM stdin;
1	2	2023-11-21
\.


--
-- TOC entry 3414 (class 0 OID 24800)
-- Dependencies: 229
-- Data for Name: producto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.producto (id_producto, id_proveedor, nombre, precio, stock, stockmin, stockmax) FROM stdin;
3	2	Gabinete XPG 500	400	10	2	10
1	1	Memoria Ram ADATA 4GB	1000	4	4	15
2	1	Pasta termica artic mx-4	200	2	3	15
\.


--
-- TOC entry 3402 (class 0 OID 24696)
-- Dependencies: 217
-- Data for Name: proveedor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.proveedor (id_proveedor, nombre, telefono, direccion) FROM stdin;
1	Luis Flores	3326594852	Revolucion 1200
2	Benito Gamesa	3369584715	Rosales 132
3	Rafael Delgadillo	3325648975	Periferico Sur 1210
\.


--
-- TOC entry 3410 (class 0 OID 24766)
-- Dependencies: 225
-- Data for Name: venta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.venta (id_venta, fecha) FROM stdin;
1	2023-11-19
2	2023-11-22
\.


--
-- TOC entry 3434 (class 0 OID 0)
-- Dependencies: 222
-- Name: compra_id_compra_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.compra_id_compra_seq', 2, true);


--
-- TOC entry 3435 (class 0 OID 0)
-- Dependencies: 232
-- Name: detalle_compra_id_detalle_compra_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detalle_compra_id_detalle_compra_seq', 4, true);


--
-- TOC entry 3436 (class 0 OID 0)
-- Dependencies: 220
-- Name: detalle_merma_id_merma_prod_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detalle_merma_id_merma_prod_seq', 1, true);


--
-- TOC entry 3437 (class 0 OID 0)
-- Dependencies: 230
-- Name: detalle_venta_id_detalle_venta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detalle_venta_id_detalle_venta_seq', 4, true);


--
-- TOC entry 3438 (class 0 OID 0)
-- Dependencies: 214
-- Name: empleado_id_empleado_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.empleado_id_empleado_seq', 2, true);


--
-- TOC entry 3439 (class 0 OID 0)
-- Dependencies: 226
-- Name: iva_id_iva_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.iva_id_iva_seq', 2, true);


--
-- TOC entry 3440 (class 0 OID 0)
-- Dependencies: 218
-- Name: merma_id_merma_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.merma_id_merma_seq', 1, true);


--
-- TOC entry 3441 (class 0 OID 0)
-- Dependencies: 228
-- Name: productos_id_producto_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.productos_id_producto_seq', 3, true);


--
-- TOC entry 3442 (class 0 OID 0)
-- Dependencies: 216
-- Name: proveedor_id_proveedor_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.proveedor_id_proveedor_seq', 3, true);


--
-- TOC entry 3443 (class 0 OID 0)
-- Dependencies: 224
-- Name: venta_id_venta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.venta_id_venta_seq', 2, true);


--
-- TOC entry 3237 (class 2606 OID 24749)
-- Name: compra compra_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.compra
    ADD CONSTRAINT compra_pkey PRIMARY KEY (id_compra);


--
-- TOC entry 3247 (class 2606 OID 32902)
-- Name: detalle_compra detalle_compra_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_compra
    ADD CONSTRAINT detalle_compra_pkey PRIMARY KEY (id_detalle_compra);


--
-- TOC entry 3235 (class 2606 OID 24732)
-- Name: detalle_merma detalle_merma_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_merma
    ADD CONSTRAINT detalle_merma_pkey PRIMARY KEY (id_detalle_merma);


--
-- TOC entry 3245 (class 2606 OID 32885)
-- Name: detalle_venta detalle_venta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_pkey PRIMARY KEY (id_detalle_venta);


--
-- TOC entry 3229 (class 2606 OID 24694)
-- Name: empleado empleado_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_pkey PRIMARY KEY (id_empleado);


--
-- TOC entry 3241 (class 2606 OID 24798)
-- Name: iva iva_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iva
    ADD CONSTRAINT iva_pkey PRIMARY KEY (id_iva);


--
-- TOC entry 3233 (class 2606 OID 24720)
-- Name: merma merma_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.merma
    ADD CONSTRAINT merma_pkey PRIMARY KEY (id_merma);


--
-- TOC entry 3243 (class 2606 OID 24807)
-- Name: producto productos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id_producto);


--
-- TOC entry 3231 (class 2606 OID 24701)
-- Name: proveedor proveedor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedor
    ADD CONSTRAINT proveedor_pkey PRIMARY KEY (id_proveedor);


--
-- TOC entry 3239 (class 2606 OID 24771)
-- Name: venta venta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.venta
    ADD CONSTRAINT venta_pkey PRIMARY KEY (id_venta);


--
-- TOC entry 3255 (class 2606 OID 32903)
-- Name: detalle_compra detalle_compra_id_compra_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_compra
    ADD CONSTRAINT detalle_compra_id_compra_fkey FOREIGN KEY (id_compra) REFERENCES public.compra(id_compra);


--
-- TOC entry 3256 (class 2606 OID 32908)
-- Name: detalle_compra detalle_compra_id_producto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_compra
    ADD CONSTRAINT detalle_compra_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.producto(id_producto);


--
-- TOC entry 3249 (class 2606 OID 24733)
-- Name: detalle_merma detalle_merma_id_merma_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_merma
    ADD CONSTRAINT detalle_merma_id_merma_fkey FOREIGN KEY (id_merma) REFERENCES public.merma(id_merma);


--
-- TOC entry 3250 (class 2606 OID 24818)
-- Name: detalle_merma detalle_merma_id_producto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_merma
    ADD CONSTRAINT detalle_merma_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.producto(id_producto) NOT VALID;


--
-- TOC entry 3253 (class 2606 OID 32891)
-- Name: detalle_venta detalle_venta_id_producto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.producto(id_producto);


--
-- TOC entry 3254 (class 2606 OID 32886)
-- Name: detalle_venta detalle_venta_id_venta_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_id_venta_fkey FOREIGN KEY (id_venta) REFERENCES public.venta(id_venta);


--
-- TOC entry 3251 (class 2606 OID 32914)
-- Name: compra id_proveedor_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.compra
    ADD CONSTRAINT id_proveedor_fk FOREIGN KEY (id_proveedor) REFERENCES public.proveedor(id_proveedor);


--
-- TOC entry 3248 (class 2606 OID 24721)
-- Name: merma merma_id_empleado_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.merma
    ADD CONSTRAINT merma_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);


--
-- TOC entry 3252 (class 2606 OID 24808)
-- Name: producto productos_id_proveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto
    ADD CONSTRAINT productos_id_proveedor_fkey FOREIGN KEY (id_proveedor) REFERENCES public.proveedor(id_proveedor);


-- Completed on 2023-12-09 08:48:06

--
-- PostgreSQL database dump complete
--

