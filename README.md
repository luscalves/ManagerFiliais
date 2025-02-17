🏢 Controle de Filiais

📌 Descrição

Este é um sistema de gestão de filiais desenvolvido em C# utilizando Windows Forms (.NET) e Real TaiZor para estilização. O projeto segue o conceito de Domain-Driven Design (DDD) e usa Entity Framework para interação com o banco de dados MySQL.

🚀 Tecnologias Utilizadas

🟢 C# (.NET Windows Forms)

🎨 Real TaiZor (Framework de UI)

🛠 Entity Framework (ORM para MySQL)

🗄 MySQL Workbench (Modelagem e Administração do Banco de Dados)

🏗 DDD (Domain-Driven Design)

📂 Estrutura do Projeto (DDD)

O projeto é estruturado seguindo os princípios do DDD, separando as responsabilidades em diferentes camadas:

🔹 Domain (Domínio) - Contém as entidades, interfaces e regras de negócio.🔹 Application (Aplicação) - Contém os serviços e casos de uso da aplicação.🔹 Infrastructure (Infraestrutura) - Contém o acesso ao banco de dados e implementação de repositórios.🔹 Presentation (Apresentação) - Interface gráfica desenvolvida com Windows Forms e Real TaiZor.

⚙️ Instalação e Configuração

🔧 Requisitos

✅ .NET SDK instalado (versão compatível com o projeto)✅ MySQL Server e MySQL Workbench instalados

🏗 Configuração do Banco de Dados

1️⃣ Criar o banco de dados executando o script SQL fornecido no arquivo ConfigBanco.txt2️⃣ Atualizar a string de conexão no arquivo de configuração appsettings.json:

Server=localhost;Port=3306;DataBase=CONTROLE_FILIAIS;Uid=root;Pwd="Sua_senha"

3️⃣ Rodar as migrações do Entity Framework:

dotnet ef database update

▶️ Execução do Projeto

1️⃣ Abrir o projeto no Visual Studio.

2️⃣ Restaurar pacotes do NuGet:

dotnet restore

3️⃣ Executar a aplicação pressionando F5 ou rodando:

dotnet run

📌 Funcionalidades

✅ Gestão de Usuários (Cadastro, Login com hash de senha)✅ Cadastro e Gerenciamento de Filiais✅ Gestão de Funcionários e Departamentos✅ Controle de Projetos e Alocação de Funcionários✅ Interface Moderna com Real TaiZor

📩 Contato

📧 Para mais informações, dúvidas ou sugestões, entre em contato pelo e-mail: lucalves14@hotmail.com
