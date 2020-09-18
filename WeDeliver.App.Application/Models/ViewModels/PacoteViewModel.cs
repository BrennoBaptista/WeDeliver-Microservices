using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.App.Application.Models.ViewModels
{
    public class PacoteViewModel : EntidadeBase<Guid>
    {
        public Guid Id_Cliente { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }
    }
}
