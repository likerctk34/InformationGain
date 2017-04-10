using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationGain
{
    class InformatioGainForTHL
    {
        public List<TapHuanLuyen> dsthl;
        public InformatioGainForTHL()
        {
            dsthl = new List<TapHuanLuyen>();

        }
        public List<ThuocTinh> GetAllPropertysByKey(string key)
        {
            List<ThuocTinh> ds = new List<ThuocTinh>();
            dsthl.ForEach(x =>
                {
                    var tt = x.FindPropertysByKey(key);
                    if (ds.Find(tt1 => tt1 == tt) != null)
                    {
                        ds.Add(tt);
                    }
                });
            return ds;
        }
        public List<TapHuanLuyen> GetAllTHlByValueOfKeyDicision(ThuocTinh ttkey)
        {
            return dsthl.FindAll(x =>
                {
                    return x.FindPropertysByPropertyKey(ttkey) != null;
 
                });
        }

        public string Key;
        public InformatioGainForTHL(List<TapHuanLuyen> _dsthl,string _key)
        {
            dsthl = _dsthl;
            Key = _key;
        }

        public double DoLoiTHL()
        {
            double kq = 0f;
            List<int> ds=new List<int>();

            var dsthuoctinhkhoa = GetAllPropertysByKey(Key);
            foreach (var thuoctinhkhoa in dsthuoctinhkhoa)
            {
                var dsthltheott = GetAllTHlByValueOfKeyDicision(thuoctinhkhoa);
                ds.Add(dsthltheott.Count);
            }

            return Library.I(ds.ToArray());
        }


    }
}
