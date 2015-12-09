-- Consulta da frequencia do aluno

SELECT
	F.CD_FREQ 'Código',
	F.CD_ALU 'Código Aluno',
	A.NOME_ALU 'Nome Aluno',
	f.DATA_HORA 'Data Hora'

FROM FREQUENCIA F
LEFT OUTER JOIN ALUNO A
ON F.CD_ALU = A.CD_ALU
