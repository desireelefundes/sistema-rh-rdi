# **Sistema para gerenciamento de funcionários, departamentos e projetos da empresa**


## Escopo Geral do Projeto:
Projeto criado por Desirée Lefundes e Priscilla Trevizan para para compor nota de avaliação no projeto final do Co﻿deRDIversity realizado pela RDI Software + Prosper Digital Skills.

## Tecnologias usadas:
* **C#** – Linguagem de programação multiparadigma utilizada no desenvolvimento do backend.
* **.NET 10.0** – Framework multiplataforma utilizado para a construção da arquitetura do sistema.
* **Visual Studio Code** – IDE (Ambiente de Desenvolvimento Integrado) utilizada para a codificação e depuração.

## Funcionalidades do projeto:
* O sistema deve permitir **cadastrar, editar, listar e remover funcionários**.
* O sistema deve permitir **cadastrar departamentos e cargos**.
* O sistema deve permitir **alocar funcionários em um projeto**.
* O sistema deve permitir **listar funcionários por projeto ou departamento**.
* O sistema deve permitir **remover um funcionário de um projeto**.

## Entidades (classes):
* **Funcionário**
Armazena os dados pessoais e profissionais básicos do colaborador.
* **Departamento**
Define a unidade organizacional à qual o funcionário pertence.
* **Cargo**
Define a função e o nível hierárquico.
* **Projeto**
Representa as iniciativas temporárias onde os funcionários serão alocados
* **AlocacaoProjeto**
Permite a relação entre Funcionário e Projeto
