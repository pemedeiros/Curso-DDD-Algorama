using Kernel.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class Colega :  EntityKeySeq
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
