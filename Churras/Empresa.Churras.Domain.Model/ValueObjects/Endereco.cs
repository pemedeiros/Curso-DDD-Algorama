﻿using Kernel.Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Churras.Domain.Model.ValueObjects
{
    public class Endereco : ValueObject<Endereco>
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Coordenadas Coordenadas { get; set; }
    }
}
