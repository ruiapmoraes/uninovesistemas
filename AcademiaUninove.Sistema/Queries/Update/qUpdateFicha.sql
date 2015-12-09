-- Atualizar ficha de exericcios

UPDATE FICHA_EXERCICIOS
SET
	   CD_ALU = {1},
	   NM_EXERCICIO = '{2}',
	   REPETICOES = '{3}',
	   SERIES = '{4}',
	   TREINO = '{5}',
	   DATA_INICIO = '{6}'
WHERE CD_FICHA = {0}