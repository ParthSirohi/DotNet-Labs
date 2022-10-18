using System;

namespace FirstWebForm
{
    [Serializable()]
    public class Sneakers
    {
        public int ShoeId { get; internal set; }
        public string SneakerName { get; internal set; }
        public string Type { get; internal set; }
    }
}