﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.Common.Infra.Helper.Serializers
{
    public class SerializerService : ISerializerService
    {
        public T Deserialize<T>(string serializedObj)
        {
            return JsonConvert.DeserializeObject<T>(serializedObj);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
