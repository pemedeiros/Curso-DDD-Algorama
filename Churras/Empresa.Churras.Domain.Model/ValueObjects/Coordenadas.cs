﻿using Kernel.Domain.Model.ValueObjects;

namespace Empresa.Churras.Domain.Model.ValueObjects
{
    public class Coordenadas : ValueObject<Coordenadas>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
