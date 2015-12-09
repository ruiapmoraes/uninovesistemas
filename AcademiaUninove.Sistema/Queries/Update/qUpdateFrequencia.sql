-- Update da frequencia do aluno
UPDATE FREQUENCIA
SET
	F.CD_ALU = {1},
	F.DATA_HORA = '{2}'
WHERE 
	F.CD_FREQ = {0}
