﻿namespace ControleClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
    }
}
