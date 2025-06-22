# RELATÓRIO DE IMPLEMENTAÇÃO DE SERVIÇOS AWS

Data: 22/06/2025
Empresa: Abstergo Industries
Responsável: Osvaldo Sandoli
## Introdução
Este relatório apresenta o processo de implementação de ferramentas na empresa Abstergo Industries, realizado por Osvaldo Sandoli. O objetivo do projeto foi elencar 3 serviços AWS, com a finalidade de realizar diminuição de custos imediatos com infraestrutura em nuvem, mantendo a performance e a segurança dos sistemas da empresa.

## Descrição do Projeto
O projeto de implementação de ferramentas foi dividido em 3 etapas, cada uma com seus objetivos específicos. A seguir, serão descritas as etapas do projeto:

Etapa 1:
- Nome da ferramenta: AWS Compute Savings Plans
- Foco da ferramenta: Redução de custos com instâncias EC2 e serviços de computação
- Descrição de caso de uso: A empresa possuía cargas de trabalho previsíveis em EC2. Com a adoção do Compute Savings Plans, foi possível obter até 54% de economia em relação ao modelo sob demanda, mantendo a flexibilidade de uso entre diferentes tipos de instância.

Etapa 2:
- Nome da ferramenta: Amazon S3 Intelligent-Tiering
- Foco da ferramenta: Otimização de custos de armazenamento
- Descrição de caso de uso: Os dados armazenados em S3 foram migrados para a classe Intelligent-Tiering, que move automaticamente objetos entre camadas de armazenamento com base na frequência de acesso. Isso reduziu significativamente os custos com dados pouco acessados, sem necessidade de intervenção manual.

Etapa 3:
- Nome da ferramenta: Amazon EC2 Auto Scaling
- Foco da ferramenta: Ajuste automático da capacidade computacional conforme a demanda
- Descrição de caso de uso: A empresa enfrentava picos de acesso em horários específicos, mantendo instâncias EC2 ativas mesmo em períodos de baixa demanda. Com a implementação do EC2 Auto Scaling, foi possível escalar automaticamente a quantidade de instâncias com base em métricas como uso de CPU e tráfego de rede. Isso garantiu alta disponibilidade durante picos e redução de custos em horários ociosos, evitando o provisionamento excessivo de recursos.

## Conclusão
A implementação de ferramentas na empresa Abstergo Industries teve como principal foco a redução de custos com infraestrutura em nuvem, aliada à otimização inteligente dos recursos computacionais. As soluções adotadas – Compute Savings Plans, Amazon S3 Intelligent-Tiering e Amazon EC2 Auto Scaling – proporcionaram maior controle orçamentário, automação de escalabilidade e economia sem comprometer a performance. Essa abordagem aumentou a eficiência operacional e garantiu uma utilização mais racional dos recursos em períodos de baixa demanda. Recomenda-se a continuidade da utilização das ferramentas implementadas e a busca por novas tecnologias que possam melhorar ainda mais os processos da empresa.

Anexos
- Relatório de economia gerada com Savings Plans
  ![image](https://github.com/user-attachments/assets/c690f88d-e40e-4df8-a0bb-39b73b9f0f3e)

- Planilha comparativa de custos S3 antes e depois da migração para Intelligent-Tiering
  ![image](https://github.com/user-attachments/assets/2c863e14-6d86-4758-b388-ca49a7369e10)

Assinatura do Responsável pelo Projeto:
Osvaldo Sandoli
