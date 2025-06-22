# Guia de Introdução à Computação em Nuvem com AWS

## 1. Como a Computação em Nuvem Funciona

### 1.1 On-Premises
Infraestrutura de TI mantida fisicamente dentro da empresa. A organização é responsável por todo o hardware, software, segurança e manutenção (sem uso de Cloud).

### 1.2 As a Service
Servidores totalmente alocados na nuvem, utilizados quando não há espaço físico para servidores ou para reduzir custos.

#### Modelos de Serviço:
- **1.3 IaaS (Infraestrutura como Serviço)**: Aluguel de servidores, redes e armazenamento. Ex: AWS EC2
- **1.4 PaaS (Plataforma como Serviço)**: Foco no código enquanto a plataforma cuida do restante. Ex: AWS Elastic Beanstalk
- **1.5 SaaS (Software como Serviço)**: Software pronto para uso. Ex: Gmail, Office 365

### 1.6 Ambiente Híbrido
Combinação de servidores locais e em nuvem. Ex: aumentos temporários de demanda como na Black Friday.

### 1.7 Pagamento
Cobrança baseada no consumo de recursos (CPU, memória, armazenamento) e valorização cambial.

### 1.8 Fornecedores IaaS
Empresas que alugam infraestrutura: AWS, Azure, etc.

---

## 2. Infraestrutura Global da AWS

### 2.1 Regiões e Zonas de Disponibilidade
Redundância geográfica garante alta disponibilidade e tolerância a falhas.

### 2.2 CDN - Amazon CloudFront
Entrega de conteúdo em cache a partir de pontos de presença (PoPs), reduzindo a latência.

### 2.3 Acesso à AWS
- **Console**: Via navegador
- **AWS CLI**: Linha de comando
- **SDKs**: Automação via código

### 2.4 Provisionamento de Infraestrutura
- **Elastic Beanstalk**: Automatiza deploys
- **CloudFormation**: Define ambientes com arquivos JSON ou YAML

---

## 3. Computação na AWS

### 3.1 Instâncias EC2
Servidores virtuais configuráveis sob demanda com cobrança por uso.

### 3.2 Famílias de Instância
- Uso geral (t4g, m6i)
- CPU elevada (c6i, c7g)
- Memória intensiva (r6g, x2idn)
- Disco intenso (i4i, d3en)
- GPU (p4, g5)
- macOS/iOS (mac1.metal)

### 3.3 Modelos de Compra
- Sob demanda
- Reservadas (1–3 anos)
- Spot (capacidade ociosa)
- Savings Plans

### 3.4 EC2 - Elastic Compute Cloud
Serviços escaláveis, seguros e de uso flexível.

### 3.5 Auto Scaling
Escala horizontal automática e alta disponibilidade.

### 3.6 Elastic Load Balancer
Distribuição de carga entre instâncias EC2.

#### 3.7 Tipos de ELB
- Application Load Balancer
- Network Load Balancer
- Gateway Load Balancer

---

### 3.9 Serviços de Mensageria
- **SQS**: Filas de mensagens
- **SNS**: Sistema de publicação/assinatura (pub/sub)

### 3.10 Serverless
Execução de código sem gerenciamento de servidores com **AWS Lambda**.

### 3.11 Containers
Empacotamento isolado de aplicações. Ex: Docker

### 3.12 Containers na AWS
- **ECR**: Repositório de imagens
- **ECS**: Orquestração simples
- **EKS**: Orquestração com Kubernetes
- **Fargate**: Containers sem servidor

---

## 4. Redes na AWS

### 4.1 VPC - Virtual Private Cloud
Criação de redes privadas com sub-redes públicas e privadas.

### 4.2 Acesso à Internet
- **Internet Gateway**: Comunicação com internet pública
- **IP público**: Necessário para acesso externo

### 4.3 VPN - Virtual Gateway
Integra rede local e nuvem via VPN site-to-site.

### 4.4 AWS Direct Connect
Conexão física dedicada, ideal para alta performance.

### 4.5 NACLs (Network ACLs)
Controle de tráfego em nível de sub-rede (stateless).

### 4.6 Security Groups
Controle de tráfego em nível de instância EC2 (stateful).

---

## 5. Armazenamento de Banco de Dados na AWS

### 5.1 Tipos de Armazenamento

#### 5.2 Armazenamento de Objetos (Object Storage)
- Dados armazenados como objetos (dados + metadados + identificador único)
- Ideal para dados não estruturados e em grande volume
- Escalabilidade praticamente ilimitada
- **Serviço AWS**: Amazon S3
- **Casos de uso**: Data lakes, mídias, backups, logs, arquivos estáticos

#### 5.3 Armazenamento de Arquivos (File Storage)
- Sistema de arquivos compartilhado acessado por várias instâncias
- **Serviço AWS**: Amazon EFS
- **Casos de uso**: Ambientes de desenvolvimento, aplicações legadas, microsserviços

#### 5.4 Armazenamento de Blocos (Block Storage)
- Alta performance com baixa latência
- **Serviço AWS**: Amazon EBS
- **Casos de uso**: EC2, containers, bancos de dados relacionais

---

### 5.5 Amazon EBS - Elastic Block Store
- Armazenamento em blocos ("volumes") anexados a instâncias EC2
- Ideal para buffers, cache, dados temporários

##### 5.5.1 Perda de dados pode ocorrer em:
- Falha de disco
- Instância parada, hibernada ou encerrada

### 5.6 Criação de Volumes
1. Definir tipo do volume
2. Escolher tamanho e configurações
3. Anexar à instância EC2

### 5.7 Tipos de Volumes
- **HDD**: Lento, barato, ideal para throughput
- **SSD**: Rápido, mais caro, ideal para IOPS

---

### 5.8 Backups
- **Snapshots**: Versões automáticas diárias
- **Backup incremental**: Armazena apenas mudanças

---

### 5.9 Amazon S3 - Simple Storage Service
- Armazenamento de objetos
- Controle de acesso por objeto e versionamento

### 5.10 O que é um objeto no S3?
- **Dados**: conteúdo
- **Metadados**: nome/valor com informações adicionais
- **Chave**: identificador único para recuperação

### 5.11 Localização dos Objetos
- Objetos ficam em buckets no S3; fisicamente em HDs da AWS

### 5.12 Buckets S3
- Containers para objetos
- Até 100 buckets por conta
- Objetos de 0 até 5 TB

---

### 5.13 Classes de Armazenamento do S3

| Classe | Acesso | Redundância | Casos de Uso |
|-------|--------|--------------|--------------|
| **Standard** | Frequente | 3+ AZs | Sites, apps, dados analíticos |
| **Standard-IA** | Pouco frequente | 3+ AZs | Backups, arquivos pouco acessados |
| **One Zone-IA** | Pouco frequente | 1 AZ | Custo reduzido com menor redundância |
| **Intelligent-Tiering** | Variável | Automática | Dados com padrão de acesso incerto |
| **Glacier Instant Retrieval** | Raramente (ms) | 3+ AZs | Arquivamento com recuperação imediata |
| **Glacier Flexible Retrieval** | 1–2x/ano (min-horas) | 3+ AZs | Backups com baixa urgência |
| **Glacier Deep Archive** | 1–2x/ano (até 12h) | 3+ AZs | Conformidade e arquivamento a longo prazo |

---

### 5.14 Amazon EFS - Elastic File System
- Sistema de arquivos serverless e elástico
- Escala dinâmica até Petabytes
- Compatível com NFS
- **Serviços compatíveis**: EC2, Lambda, ECS

#### 5.14.1 Classes de Armazenamento EFS
- **Standard**: Alta disponibilidade em região inteira
- **Standard-IA**: Reduz custo para dados acessados com menos frequência
- **One Zone** e **One Zone-IA**: Versões com menor custo armazenadas em uma única AZ
