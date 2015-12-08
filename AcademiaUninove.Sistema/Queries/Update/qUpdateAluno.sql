-- Comando de update aluno

UPDATE ALUNO 
SET 
	CD_FUNC = {1},
	NOME_ALU = '{2}',
	CPF_ALU = '{3}',
	RG_ALU = '{4}',
	DT_NASC = '{5}',
	TEL_RES = '{6}',
	TEL_CEL = '{7}',
	END_ALU = '{8}',
	CEP_ALU = '{9}',
	CIDADE = '{10}',
	STATUS_ALU = '{11}',
	RESTRICAO = '{12}',
	OBJETIVO = '{13}'
WHERE
	CD_ALU = {0}
	