﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntegracaoSolis.DTO
{
    public class ImportarArquivoDTo
    {
        public Guid id { get; set; }
        public string? cnpj_cpf { get; set; }
        public DateTime? vencimento { get; set; }
        public decimal valor_parcela { get; set; }
        public string? numero_documento { get; set; }
        public string? nome_sacado { get; set; }
        public string? rua { get; set; }
        public string? bairro { get; set; }
        public string? cep { get; set; }
        public string? cidade { get; set; }
        public string? uf { get; set; }
        public string? telefone { get; set; }
        public string? chave { get; set; }
        public bool remessa { get; set; }

    }
}
