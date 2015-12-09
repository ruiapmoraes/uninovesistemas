-- Consultar dados do Aluno
SELECT 
	 A.CD_ALU 'Código'
	 ,A.CD_FUNC 'Código Instrutor'
	 ,F.NOME_FUNC 'Nome Instrutor'
	 ,A.NOME_ALU 'Aluno'
	 ,A.CPF_ALU 'CPF'
	 ,A.RG_ALU 'RG'
	 ,A.DT_NASC 'Data Nasc'
	 ,A.TEL_RES 'Tel Residencial'
	 ,A.TEL_CEL 'Tel Celular'
	 ,A.END_ALU 'Endereço'
	 ,A.CEP_ALU 'CEP'
	 ,A.CIDADE 'Cidade'
	 ,A.STATUS_ALU 'Status'
	 ,A.RESTRICAO 'Restrição'
	 ,A.OBJETIVO 'Objetivo'

FROM ALUNO A
LEFT OUTER JOIN FUNCIONARIO F
ON A.CD_FUNC = F.CD_FUNC

