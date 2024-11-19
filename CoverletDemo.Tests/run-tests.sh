
#!/bin/bash

# Executar os testes
dotnet test --collect:"XPlat Code Coverage"

# Criar diretório para armazenar o arquivo de cobertura
mkdir -p ./TestResults/Coverage

# Mover o arquivo coverage.cobertura.xml
mv ./TestResults/*/coverage.cobertura.xml ./TestResults/Coverage/coverage.cobertura.xml

# Excluir pastas com hash
find ./TestResults -mindepth 1 -maxdepth 1 -type d -not -name "Coverage" -exec rm -rf {} +

# Gerar o relatório HTML
reportgenerator -reports:"./TestResults/Coverage/coverage.cobertura.xml" -targetdir:"./TestResults/Coverage/HtmlReport" -reporttypes:Html


