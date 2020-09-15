using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Common.Domain.Entities
{
    public abstract class TEntidade<TKey>
    {
        public TKey Id { get; set; }
    }
}
