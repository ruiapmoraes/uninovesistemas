﻿-- Consulta de hortas aulas


SELECT 
	HA.CD_HORA_AULA 'Código',
	HA.CD_HORARIO 'Código Horário',
	H.DATA_HORARIO 'Horário',
	HA.CD_AULA 'Código Aula',
	A.NOME_AULA 'Nome Aula'
FROM HORA_AULA HA
LEFT OUTER JOIN HORARIO H
ON HA.CD_HORARIO = H.CD_HORARIO
LEFT OUTER JOIN AULA A
ON HA.CD_AULA = A.CD_AULA
