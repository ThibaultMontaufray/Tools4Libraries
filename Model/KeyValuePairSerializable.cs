using System;
using System.Xml.Serialization;

namespace Tools4Libraries
{
    [Serializable]
    [XmlType(TypeName = "keyValuePairSerializable")]
    public class KeyValuePairSerializable<K, V>
    {
        [XmlChoiceIdentifier("KeySerializable")]
        [XmlElement("KeySerializable", typeof(string))]
        public K KeySerializable
        { get; set; }

        [XmlChoiceIdentifier("ValueSerializable")]
        [XmlElement("ValueSerializable", typeof(string))]
        public V ValueSerializable
        { get; set; }

        [XmlIgnore]
        public ItemChoiceType ItemType;
        
        public KeyValuePairSerializable(K k, V v) { KeySerializable = k; ValueSerializable = v; }
        public KeyValuePairSerializable() { }
    }
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        KeySerializable,
        ValueSerializable
,
    }
}
