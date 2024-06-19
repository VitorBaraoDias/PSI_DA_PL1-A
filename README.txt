Caro utilizador(a):

        
- Caso aconteça um erro de "... Remova a marca da Web se você quiser processar esses arquivos.", deverá executar os seguintes comandos abaixo no terminal:
	"cd C:\caminho\para\os\arquivos" (coloque o caminho que contém esse arquivos)
	
	"Get-ChildItem -Path . -Filter *.resx | Unblock-File"


- Caso aconteça algum erro de pacotes do Bunifu:
	"cd C:\caminho\para\os\arquivos" (coloque o caminho que contém esse arquivos)

	"Get-ChildItem -Path . -Filter *.dll | Unblock-File"