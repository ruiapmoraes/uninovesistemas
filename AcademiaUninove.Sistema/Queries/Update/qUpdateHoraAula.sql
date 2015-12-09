-- Comando de update aula dos instrutores

UPDATE HORA_AULA 
SET 
		CD_HORARIO = {1}
		,CD_AULA = {2}	
WHERE
		CD_HORA_AULA = {0}