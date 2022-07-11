# PMM (Project Manager Master)

O PMM é um software para gestão de projetos empresariais com foco na segurança e privacidade de seus usuários.

O PMM é capaz de:
- Listar todos os projetos. :white_check_mark:
- Buscar informações de um projeto em específico. :white_check_mark:
- Deletar um projeto. :white_check_mark:
- Atualizar todas as informações de um projeto. :white_check_mark:
- Permitir que somente usuários autorizados exerçam certas funções (Deletar um projeto). :white_check_mark:

Requisitos:
- Banco de Dados (SQL)
- SSMS (para a criação das tabelas Projetos e Usuários em seu banco de dados)
- Pacotes NuGet:
    - Microsoft.AspNetCore.Authentication.JwtBearer
    - Microsoft.EntityFrameworkCore.SqlServer
    - Swashbuckle.AspNetCore
