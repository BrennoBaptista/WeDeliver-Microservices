﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel
{
    public class ClienteAddedEvent
    {
        public Cliente Cliente { get; set; }
    }
}
