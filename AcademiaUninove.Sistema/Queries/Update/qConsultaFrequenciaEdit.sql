-- Consulta da frequencia do aluno

SELECT
	F.CD_FREQ 'Código',
	F.CD_ALU 'Código Aluno',
	A.NOME_ALU 'Nome Aluno',
	F.DATA_HORA 'Data Hora'

FROM FREQUENCIA F
LEFT OUTER JOIN ALUNO A
ON F.CD_ALU = A.CD_ALU

WHERE F.CD_FREQ = {0}