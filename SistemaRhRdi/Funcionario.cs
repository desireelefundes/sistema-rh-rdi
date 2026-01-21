using System;

public class SistemaRhRdi
{

    public class Funcionario
    {
        // Atributos:
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }

        // Construtor:
        public Funcionario(int id, string nome, int cpf, string email)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

    }

}