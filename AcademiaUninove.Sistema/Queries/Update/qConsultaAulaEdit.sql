-- Consulta de Horário para edição

SELECT
	CD_HORARIO 'Código',
	DATA_HORARIO 'Data',
	HORA 'Hora'

FROM HORARIO

WHERE CD_HORARIO = {0}