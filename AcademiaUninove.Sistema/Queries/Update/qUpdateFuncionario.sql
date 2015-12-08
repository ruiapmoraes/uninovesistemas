-- Comando de update FUNCIONÁRIO

UPDATE FUNCIONARIO 
SET 
		CD_CARGO = {1}
		,NOME_FUNC = '{2}'
		,END_FUNC = '{3}'
		,CEP_FUNC = '{4}'
		,CIDADE = '{5}'
		,TEL_RES = '{6}'
		,TEL_CEL = '{7}'
WHERE
		CD_FUNC = {0}