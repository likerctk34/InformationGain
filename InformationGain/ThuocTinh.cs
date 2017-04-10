using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationGain
{
    class ThuocTinh
    {
        int ma;
        public string Key;
        public string Value;
        public bool IsDecicision = false;
        public ThuocTinh(string _key,string _value,bool _isdecisio)
        {
            ma = Library.propertykeys.Count;
            Key = _key;
            Value = _value;
            IsDecicision = _isdecisio;
            
        }
        public static bool operator ==(ThuocTinh a, ThuocTinh b)
        {
            return a.Key == b.Key && a.Value == b.Value;
        }
        public static bool operator !=(ThuocTinh a, ThuocTinh b)
        {
            return a.Key != b.Key || a.Value != b.Value;
        }
        public override int GetHashCode()
        {
            return ma;
        }
        public override bool Equals(object obj)
        {
            var tt = obj as ThuocTinh;
            return tt == this;
        }
    }
}
