# 📦 Comandos Básicos e Essenciais do Docker

Este guia reúne os comandos Docker e Docker Compose mais usados no cotidiano de quem lida com containers.

---

## 🚀 Comandos Docker Mais Básicos

- `docker run imagem` — Executa um container simples.
- `docker run -it imagem` — Executa de forma interativa (ex: terminal bash).
- `docker run -d imagem` — Executa em background (modo daemon).
- `docker start container_id` — Inicia um container parado.
- `docker stop container_id` — Para um container rodando.
- `docker restart container_id` — Reinicia o container.
- `docker rm container_id` — Remove um container.
- `docker ps` — Lista containers em execução.
- `docker ps -a` — Lista todos os containers.

---

## 🐳 Docker Compose — Básico e Rápido

- `docker-compose up` — Sobe os serviços.
- `docker-compose up -d` — Sobe os serviços em background.
- `docker-compose down` — Para e remove os containers, redes e volumes.
- `docker-compose start` — Inicia containers pausados.
- `docker-compose stop` — Pausa os serviços.
- `docker-compose restart` — Reinicia todos os serviços.
- `docker-compose run servico` — Executa um serviço específico.
- `docker-compose logs -f` — Visualiza os logs dos serviços ao vivo.

---

## ⚠️ Observação

- Sempre verifique se o `docker` e o `docker-compose` estão instalados e funcionando:
  - `docker --version`
  - `docker-compose --version`

---

📘 Para mais dicas, veja a [documentação oficial](https://docs.docker.com/). E se quiser, posso transformar isso num arquivo pronto pra você clonar, usar ou até estilizar com emojis extras ou instruções específicas por ambiente (como Linux ou Windows).
