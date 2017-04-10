using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationGain
{
    class TapHuanLuyen
    {
        public List<ThuocTinh> dstt;
        public TapHuanLuyen(List<ThuocTinh> _dstt)
        {
            dstt = _dstt;
        }
        public bool IsExistProperty(ThuocTinh tt)
        {
            return dstt.Find(x => x == tt) != null;
        }
         public ThuocTinh FindPropertysByKey(string key)
        {
            return dstt.Find(x => x.Key == key);
        }
         public ThuocTinh FindPropertysByPropertyKey(ThuocTinh ttkey)
         {
             return dstt.Find(x => x == ttkey);
         }  
    }
}
