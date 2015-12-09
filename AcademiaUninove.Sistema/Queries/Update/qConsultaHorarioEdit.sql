-- Consulta horario para Edição
-- Consulta de Horário

SELECT
	CD_HORARIO 'Código',
	convert(varchar, DATA_HORARIO, 103) 'Data',
	CONVERT(VARCHAR, HORA, 8) 'HORA'

FROM HORARIO
    WHERE CD_HORARIO = {0}