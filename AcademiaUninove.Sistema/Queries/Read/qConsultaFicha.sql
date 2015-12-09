-- Consulta da Ficha de Exercícios

SELECT 
	F.CD_FICHA 'Código',
	F.CD_ALU 'Código Aluno',
	A.NOME_ALU 'Nome Aluno',
	F.NM_EXERCICIO 'Nome Exercício',
	F.REPETICOES 'Repetições',
	F.SERIES 'Séries',
	F.TREINO 'Treino',
	F.DATA_INICIO 'Data de Início'

FROM FICHA_EXERCICIOS F
LEFT OUTER JOIN ALUNO A
ON F.CD_ALU = A.CD_ALU