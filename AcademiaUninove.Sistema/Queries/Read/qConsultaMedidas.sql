-- Consulta de Medidas do Aluno

SELECT 
	M.CD_MEDIDAS 'Código',
	M.CD_ALU 'Código Aluno',
	A.NOME_ALU 'Nome Aluno',
	M.DATA_MEDIDAS 'Data Medidas',
	M.PESO 'Peso',
	M.ABDOMEN 'Abdomen',
	M.ANTEBRACO_DIR 'Antebraço Direito',
	M.ANTEBRACO_ESQ 'Antebraço Esquerdo',
	M.BRACO_DIR 'Braço Direito',
	M.BRACO_ESQ 'Braço Esquerdo',
	M.BUSTO 'Busto',
	M.COXA_DIR 'Coxa Direita',
	M.COXA_ESQ 'Coxa Esquerda',
	M.OMBRO 'Ombro',
	M.PERNA_DIR 'Perna Direita',
	M.PERNA_ESQ 'Perna Esquerda',
	M.QUADRIL 'Quadril',
	M.TORAX 'Torax',
	M.ALTURA 'Altura',
	M.IMC 'IMC'


FROM MEDIDAS M
LEFT OUTER JOIN ALUNO A
ON M.CD_ALU = A.CD_ALU
