/****** Script for SelectTopNRows command from SSMS  ******/
SELECT F.CD_FUNC 'Código'
      ,F.CD_CARGO 'Código Cargo'
	  ,C.NOME_CARGO 'Cargo'
      ,F.NOME_FUNC 'Nome Funcionário'
      ,F.END_FUNC 'Endereço'
      ,F.CEP_FUNC 'CEP'
      ,F.CIDADE 'Cidade'
      ,F.TEL_RES 'Tel. Residencial'
      ,F.TEL_CEL 'Tel. Celular'
  FROM FUNCIONARIO F
  LEFT OUTER JOIN CARGO C
  ON F.CD_CARGO = C.CD_CARGO