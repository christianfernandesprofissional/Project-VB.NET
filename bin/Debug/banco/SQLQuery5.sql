drop table if exists tb_colaboradores;

create table tb_funcionarios(
	 ID_FUNCIONARIO int identity(1,1) not null, 
	 NOME_FUNCIONARIO varchar(80) not null, 
	 CPF_FUNCIONARIO varchar(14) not null primary key,
	 CARGO varchar(80) not null, 
	 DATA_NASC varchar(10) not null, 
	 USUARIO varchar(50) not null, 
	 SENHA varchar(50) not null, 
	 EMAIL varchar(80) not null,
	 ENDERECO varchar(120) not null,
	 DATA_LOGIN varchar(12) not null,
	 STATUS varchar(20) not null
	 );



create table tb_clientes(
	CPF_CLIENTE varchar(14) not null primary key,
	NOME_CLIENTE varchar(80) not null,
	EMAIL varchar(80) not null, 
	TELEFONE  varchar(14) not null, 
	DATA_NASC varchar(10)not null, 
	ENDERECO varchar(120) not null, 
	QTDE_PEDIDOS integer not null
	);

create table tb_produtos(
	ID_PRODUTO int identity(1,1) not null primary key, 
	NOME_PRODUTO varchar(120) not null, 
	PRECO_ATUAL numeric(10,2) not null, 
	QTDE_ESTOQUE int not null, 
	ENCOMENDAS int not null
	);

create table tb_pedidos(
	ID_PEDIDO int identity(1,1) not null primary key,
	CPF_FUNCIONARIO varchar(14) not null, 
	CPF_CLIENTE varchar(14) not null, 
	NOME_PRODUTO varchar(120) not null, 
	STATUS varchar(20) not null, 
	DATA_COMPRA varchar(50), 
	QTDE_PEDIDO int not null, 
	PRECO_VENDA numeric(10,2) not null, 
	TOTAL_ITEM numeric(10,2) not null, 
	foreign key(CPF_CLIENTE) references tb_clientes(CPF_CLIENTE),
	foreign key(CPF_FUNCIONARIO) references tb_funcionarios(CPF_FUNCIONARIO)

	);

create table tb_carrinho(
	ID_PEDIDO int identity(1,1) not null primary key,
	CPF_FUNCIONARIO varchar(14) not null, 
	CPF_CLIENTE varchar(14) not null, 
	NOME_PRODUTO varchar(120) not null, 
	STATUS varchar(20) not null, 
	DATA_COMPRA varchar(50), 
	QTDE_PEDIDO int not null, 
	PRECO_VENDA numeric(10,2) not null, 
	TOTAL_ITEM numeric(10,2) not null, 
	foreign key(CPF_CLIENTE) references tb_clientes(CPF_CLIENTE),
	foreign key(CPF_FUNCIONARIO) references tb_funcionarios(CPF_FUNCIONARIO)

	);


