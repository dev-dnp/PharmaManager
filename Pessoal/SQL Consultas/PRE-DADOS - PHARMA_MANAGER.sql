/*
==============================
CRIAR USUARIOS PREDEFINIDOS
==============================
*/

-- Permitir inserção manual no campo ID_USUARIO
SET IDENTITY_INSERT TB_USUARIO ON;

SET IDENTITY_INSERT TB_USUARIO ON;

INSERT INTO TB_USUARIO (ID_USUARIO, EMAIL, SENHA, FOTO) VALUES
(1, 'evaney@pharma.com', 'senha123', NULL),
(2, 'dnp@pharma.com', 'senha123', NULL),
(3, 'aristides@pharma.com', 'senha123', NULL),
(4, 'severina@pharma.com', 'senha123', NULL),
(5, 'gelson@pharma.com', 'senha123', NULL),
(6, 'pedro@pharma.com', 'senha123', NULL),
(7, 'ana@pharma.com', 'senha123', NULL),
(8, 'mariana@pharma.com', 'senha123', NULL),
(9, 'joao@pharma.com', 'senha123', NULL),
(10, 'suzana@pharma.com', 'senha123', NULL);

SET IDENTITY_INSERT TB_USUARIO OFF;

-- Desabilitar inserção manual no campo ID_USUARIO
SET IDENTITY_INSERT TB_USUARIO OFF;


/*
==============================
CRIAR CARGOS PREDEFINIDOS
==============================
*/

INSERT INTO TB_CARGO (NOME, DESCRICAO) VALUES
('Gerente', 'Responsável pela gestão geral da farmácia, coordenação de equipe e administração de estoque.'),
('Assistente de Farmácia', 'Auxilia nas atividades diárias, atendimento ao cliente e organização de produtos.'),
('Caixa', 'Responsável pelo registro de vendas, recebimento de pagamentos e emissão de faturas.'),
('Farmacêutico', 'Profissional habilitado para prescrição e orientação de medicamentos, controle de qualidade e farmácia clínica.'),
('Estoquista', 'Responsável pelo recebimento, armazenamento e controle de estoque de produtos.'),
('Atendente', 'Atende os clientes no balcão, tira dúvidas e orienta sobre produtos.'),
('Supervisor de Vendas', 'Coordena a equipe de vendas, estabelece metas e acompanha desempenho.'),
('Analista de Compras', 'Responsável por negociação com fornecedores, reposição de produtos e análise de preços.'),
('Marketing', 'Desenvolve campanhas promocionais e ações de divulgação da farmácia.'),
('Segurança', 'Responsável pela segurança do estabelecimento, clientes e funcionários.');


/*
==============================
CRIAR FUNCIONARIOS PREDEFINIDOS
==============================
*/


INSERT INTO TB_FUNCIONARIO 
(NOME, BILHETE_IDENTIDADE, DATA_NASCIMENTO, ID_USUARIO, ID_CARGO, ID_ENDERECO, TELEFONE, EMAIL) 
VALUES
('Evaney Matadi', 'BI12345678', '1985-03-12', 1, 1, NULL, '912345678', 'evaney@pharma.com'),
('Domingos Nkula Pedro', 'BI23456789', '1990-07-21', 2, 2, NULL, '923456789', 'dnp@pharma.com'),
('Aristides Muhongo', 'BI34567890', '1982-11-05', 3, 3, NULL, '934567890', 'aristides@pharma.com'),
('Severina Elísio', 'BI45678901', '1988-01-18', 4, 4, NULL, '945678901', 'severina@pharma.com'),
('Gelson António', 'BI56789012', '1995-06-30', 5, 5, NULL, '956789012', 'gelson@pharma.com'),
('Pedro Santos', 'BI67890123', '1992-09-14', 6, 6, NULL, '967890123', 'pedro@pharma.com'),
('Ana Costa', 'BI78901234', '1987-12-02', 7, 7, NULL, '978901234', 'ana@pharma.com'),
('Mariana Lopes', 'BI89012345', '1993-04-25', 8, 8, NULL, '989012345', 'mariana@pharma.com'),
('João Carvalho', 'BI90123456', '1989-08-10', 9, 9, NULL, '991234567', 'joao@pharma.com'),
('Suzana Mendes', 'BI01234567', '1991-02-05', 10, 10, NULL, '902345678', 'suzana@pharma.com');




INSERT INTO TB_PERMISSAO (NOME) VALUES
('Gerenciar Usuários'),
('Gerenciar Funcionários'),
('Gerenciar Fornecedores'),
('Gerenciar Clientes'),
('Gerenciar Produtos'),
('Gerenciar Estoque'),
('Registrar Vendas'),
('Emitir Relatórios'),
('Configurações do Sistema'),
('Acesso Administrativo');


-- Usuário 1 (Evaney) - Acesso administrativo completo
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10);

-- Usuário 2 (Domingos) - Estoque e vendas
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(2, 5),
(2, 6),
(2, 7);

-- Usuário 3 (Aristides) - Gestão de funcionários e usuários
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(3, 1),
(3, 2);

-- Usuário 4 (Severina) - Gestão de clientes e vendas
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(4, 4),
(4, 7);

-- Usuário 5 (Gelson) - Relatórios
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(5, 8);

-- Usuário 6 (Pedro) - Produtos e estoque
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(6, 5),
(6, 6);

-- Usuário 7 (Ana) - Caixa / vendas
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(7, 7);

-- Usuário 8 (Mariana) - Produtos
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(8, 5);

-- Usuário 9 (João) - Fornecedores
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(9, 3);

-- Usuário 10 (Suzana) - Configurações do sistema
INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES
(10, 9);




SET IDENTITY_INSERT TB_FORNECEDOR ON;

INSERT INTO TB_FORNECEDOR (ID_FORNECEDOR, NOME, NIF, ID_ENDERECO, TELEFONE, EMAIL) VALUES
(1, 'Farmaco Distribuidora', '123456789', NULL, '912345678', 'contato@farmacodistribuidora.com'),
(2, 'Saúde Total', '987654321', NULL, '923456789', 'vendas@saudetotal.com'),
(3, 'Distribuidora Central', '456789123', NULL, '934567890', 'info@distribuidoracentral.com'),
(4, 'Medicorp', '789123456', NULL, '945678901', 'contato@medicorp.com'),
(5, 'BioFarm', '321654987', NULL, '956789012', 'vendas@biofarm.com'),
(6, 'Farmalider', '654987321', NULL, '967890123', 'suporte@farmalider.com'),
(7, 'MedHealth', '147258369', NULL, '978901234', 'contato@medhealth.com'),
(8, 'Distribuidora Vida', '258369147', NULL, '989012345', 'info@distribuidoravida.com'),
(9, 'Saúde e Bem', '369147258', NULL, '991234567', 'vendas@saudeebem.com'),
(10, 'Pharma Supplies', '159357486', NULL, '902345678', 'contato@pharmasupplies.com');

SET IDENTITY_INSERT TB_FORNECEDOR OFF;



SET IDENTITY_INSERT TB_CATEGORIA ON;

INSERT INTO TB_CATEGORIA (ID_CATEGORIA, NOME) VALUES
(1, 'Medicamentos Genéricos'),
(2, 'Medicamentos de Marca'),
(3, 'Suplementos Alimentares'),
(4, 'Vitaminas e Minerais'),
(5, 'Produtos de Higiene'),
(6, 'Produtos de Beleza'),
(7, 'Materiais de Curativo'),
(8, 'Equipamentos Médicos'),
(9, 'Infantis e Bebês'),
(10, 'Produtos Naturais');

SET IDENTITY_INSERT TB_CATEGORIA OFF;



SET IDENTITY_INSERT TB_PRODUTO ON;

INSERT INTO TB_PRODUTO (ID_PRODUTO, NOME, CODIGO_BARRAS, PRECO_VENDA, ID_CATEGORIA, DATA_CRIACAO) VALUES
(1, 'Paracetamol 500mg', '789100000001', 1200.00, 1, GETDATE()), 
(2, 'Ibuprofeno 400mg', '789100000002', 2500.00, 1, GETDATE()), 
(3, 'Vitamina C 1000mg', '789100000003', 4500.00, 4, GETDATE()), 
(4, 'Suplemento Multivitamínico', '789100000004', 12500.00, 3, GETDATE()),
(5, 'Creme Hidratante', '789100000005', 8500.00, 6, GETDATE()), 
(6, 'Fralda Infantil P', '789100000006', 9500.00, 9, GETDATE()), 
(7, 'Álcool Gel 70%', '789100000007', 1500.00, 5, GETDATE()), 
(8, 'Máscara Cirúrgica', '789100000008', 150.00, 8, GETDATE()), 
(9, 'Pomada Antisséptica', '789100000009', 3500.00, 7, GETDATE()),
(10, 'Chá Natural Relaxante', '789100000010', 2800.00, 10, GETDATE());

SET IDENTITY_INSERT TB_PRODUTO OFF;



SET IDENTITY_INSERT TB_LOTE ON;

INSERT INTO TB_LOTE (ID_LOTE, ID_PRODUTO, ID_FORNECEDOR, DATA_VALIDADE, PRECO_COMPRA) VALUES
(1, 1, 1, '2026-12-31', 1.50),
(2, 2, 2, '2025-11-30', 2.00),
(3, 3, 3, '2027-01-15', 3.50),
(4, 4, 4, '2026-08-20', 8.00),
(5, 5, 5, '2026-10-10', 5.00),
(6, 6, 6, '2025-12-31', 10.00),
(7, 7, 7, '2026-06-30', 2.50),
(8, 8, 8, '2025-09-30', 1.00),
(9, 9, 9, '2026-03-15', 4.00),
(10, 10, 10, '2026-12-31', 4.50);

SET IDENTITY_INSERT TB_LOTE OFF;




SET IDENTITY_INSERT TB_ESTOQUE ON;

INSERT INTO TB_ESTOQUE (ID_ESTOQUE, ID_LOTE, QUANTIDADE, DATA_CRIACAO) VALUES
(1, 1, 100, GETDATE()),
(2, 2, 150, GETDATE()),
(3, 3, 200, GETDATE()),
(4, 4, 120, GETDATE()),
(5, 5, 80, GETDATE()),
(6, 6, 50, GETDATE()),
(7, 7, 300, GETDATE()),
(8, 8, 500, GETDATE()),
(9, 9, 60, GETDATE()),
(10, 10, 90, GETDATE());

SET IDENTITY_INSERT TB_ESTOQUE OFF;


SET IDENTITY_INSERT TB_METODO_PAGAMENTO ON;

INSERT INTO TB_METODO_PAGAMENTO (ID_METODO_PAGAMENTO, NOME) VALUES
(1, 'Dinheiro'),
(2, 'Cartão de Débito'),
(3, 'Cartão de Crédito'),
(4, 'Transferência Bancária'),
(5, 'Pix'),
(6, 'Vale Farmácia'),
(7, 'Cheque'),
(8, 'Boleto'),
(9, 'Carteira Digital'),
(10, 'Outro');

SET IDENTITY_INSERT TB_METODO_PAGAMENTO OFF;



SET IDENTITY_INSERT TB_ESTADO_FATURA ON;

INSERT INTO TB_ESTADO_FATURA (ID_ESTADO_FATURA, NOME) VALUES
(1, 'Pendente'),
(2, 'Pago'),
(3, 'Cancelada');

SET IDENTITY_INSERT TB_ESTADO_FATURA OFF;
