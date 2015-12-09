-- uPDATE nas medidas do aluno

UPDATE MEDIDAS
SET
	   CD_MEDIDAS = {0},
	   CD_ALU = {1},
	   DATA_MEDIDAS = '{2}',
	   PESO = {3},
	   ABDOMEN = {4},
	   ANTEBRACO_DIR = {5},
	   ANTEBRACO_ESQ = {6},
	   BRACO_DIR = {7},
	   BRACO_ESQ = {8},
	   BUSTO = {9},
	   CINTURA = {10},
	   COXA_DIR = {11},
	   COXA_ESQ = {12},
	   OMBRO = {13},
	   PERNA_DIR = {14},
	   PERNA_ESQ ={15},
	   QUADRIL = {16},
	   TORAX = {17},
	   ALTURA = {18},
	   IMC = {19}

WHERE CD_MEDIDAS = {0}