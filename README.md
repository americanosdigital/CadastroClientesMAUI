# CadastroClientesMAUI (App MAUI)

Este é um projeto de **Cadastro de Clientes** para dispositivos móveis e desktop usando **.NET MAUI**. Ele consome a API **CadastroClientesAPP** para visualizar, adicionar, editar e excluir clientes.

### Tecnologias Utilizadas

- **.NET MAUI** para construção de aplicações móveis e desktop.
- **Blazor** para renderização da interface.
- **HttpClient** para consumo da API RESTful.
- **Swagger** para documentação da API.

### Funcionalidades

- **Exibir lista de clientes**: Mostra todos os clientes cadastrados.
- **Adicionar cliente**: Permite ao usuário adicionar um novo cliente através de um formulário.
- **Editar cliente**: Permite ao usuário editar os dados de um cliente existente.
- **Excluir cliente**: Permite ao usuário excluir um cliente da lista.

### Pré-requisitos

- **.NET 8 SDK** ou superior instalado.
- **Visual Studio 2022/2023** com suporte a **.NET MAUI**.
- **CadastroClientesAPP** (API) rodando e acessível.

### Instalação

1. Clone o repositório:
    ```bash
    git clone https://github.com/SeuUsuario/CadastroClientesMAUI.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd CadastroClientesMAUI
    ```

3. Restaure as dependências:
    ```bash
    dotnet restore
    ```

4. Adicione o **HttpClient** para consumir a API no arquivo **`App.xaml.cs`**:
    ```csharp
    builder.Services.AddSingleton<HttpClient>();
    builder.Services.AddSingleton<IClienteService, ClienteService>();
    ```
    ** Verifique se na pasta Resources/Services no arquivo ClienteService o link da API esta apontando para https://localhost:7023/api/Cliente do projeto parte 1 CadastroClientesAPP

5. Execute o aplicativo:
    ```bash
    dotnet build
    dotnet run
    ```

6. O aplicativo será executado em um emulador ou dispositivo real, dependendo da plataforma que você está usando (Android, iOS, Windows, etc.).

### Testando a Aplicação

O aplicativo irá consumir a API **CadastroClientesAPP** para mostrar a lista de clientes, e você pode testar todas as funcionalidades de adicionar, editar e excluir clientes diretamente na interface do aplicativo.

### Contribuindo

1. Fork o repositório.
2. Crie uma nova branch (`git checkout -b feature/nova-feature`).
3. Faça suas alterações e commit (`git commit -am 'Adiciona nova funcionalidade'`).
4. Envie a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

---

## **Considerações Finais**

- **CadastroClientesAPP** é a API RESTful que gerencia o cadastro de clientes.
- **CadastroClientesMAUI** é o aplicativo que interage com essa API para fornecer uma interface de usuário para dispositivos móveis e desktop.

Esses projetos demonstram como integrar **.NET MAUI** com uma API **ASP.NET Core** para criar um aplicativo funcional de cadastro de clientes.

---

### Dicas para o GitHub:
- Substitua os links **`https://github.com/SeuUsuario/`** pelos seus próprios links de repositório no GitHub.
- Certifique-se de que os **previews de markdown** estão ativados no seu editor para verificar como o README será exibido no GitHub.
