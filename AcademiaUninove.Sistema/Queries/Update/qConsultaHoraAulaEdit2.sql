-- Consulta de de aulas dos instrutores


SELECT FA.CD_FUNC_AULA 'Código'
	  ,FA.CD_FUNC 'Código Instrutor'
	  ,F.NOME_FUNC 'Instrutor'
	  ,FA.CD_AULA 'Código Aula'
	  ,A.NOME_AULA 'Mome Aula'
  FROM FUNC_AULA FA
  LEFT OUTER JOIN FUNCIONARIO F
  ON FA.CD_FUNC =F.CD_FUNC
  LEFT OUTER JOIN AULA A
  ON FA.CD_AULA = A.CD_AULA
  WHERE 
		FA.CD_FUNC = {0}