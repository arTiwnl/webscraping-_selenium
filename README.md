
# **Web Scraping com Selenium em C#**

Este projeto demonstra o uso do Selenium em C# para automatizar o processo de login em um site e listar todas as quotes disponíveis em uma página designada. É um exemplo prático de web scraping combinado com automação de tarefas.

---

## **📋 Funcionalidades**

- Acessa um site específico.  
- Efetua o login com credenciais fornecidas.  
- Navega até a página designada.  
- Extrai e lista todas as quotes exibidas.  

---

## **🛠️ Tecnologias Utilizadas**

- **C#**  
- **Selenium WebDriver**  
- **.NET Core/Framework**  
- **NuGet Packages**:
  - Selenium.WebDriver  
  - Selenium.WebDriver.ChromeDriver (ou o driver correspondente ao navegador usado)

---

## **📂 Estrutura do Projeto**

- **Program.cs**: Arquivo principal contendo a lógica de automação e scraping.  
---

## **🚀 Como Executar**

1. **Pré-requisitos**:  
   - Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.  
   - Baixe o driver correspondente ao seu navegador e versão (ex.: [ChromeDriver](https://chromedriver.chromium.org/downloads)).  

2. **Clone o repositório**:  
   ```bash
   git clone https://github.com/arTiwnl/webscraping-_selenium.git
   cd webscraping-_selenium
   ```

3. **Configure o Projeto**:  
   - Abra o projeto no seu editor de código preferido (ex.: Visual Studio ou Visual Studio Code).  
   - Certifique-se de que o caminho para o driver está correto no código.  

4. **Execute o Código**:  
   - No terminal do editor ou Prompt de Comando, execute:  
     ```bash
     dotnet run
     ```

---

## **📖 Como Funciona**

1. **Login Automático**:  
   O script insere o nome de usuário e a senha fornecidos no formulário de login do site.

2. **Navegação**:  
   Após o login, o script navega até uma página específica onde as quotes estão localizadas.  

3. **Extração de Quotes**:  
   O Selenium percorre os elementos da página para capturar e exibir todas as quotes no console (ou em outro formato definido).  


---

## **📜 Licença**

Este projeto é livre para uso pessoal ou educacional. Para fins comerciais, entre em contato.  
