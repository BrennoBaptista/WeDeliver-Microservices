﻿using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.App.Application.Models.ViewModels
{
    public class PostagemViewModel : EntidadeBase<Guid>
    {
        public Guid Id_Pacote { get; set; }
        public string Destino { get; set; }
        public string Recebedor { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
