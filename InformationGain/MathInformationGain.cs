using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationGain
{
    class MathInformationGain
    {
        public string Key;
        public List<TapHuanLuyen> dsthl;
        public MathInformationGain(List<TapHuanLuyen> _dsthl,string _key)
        {
            dsthl = _dsthl;
            Key = _key;
        }
        public double E()
        {
            double kq = 0f;
            var thlcha = new InformatioGainForTHL(dsthl, Key);
            List<InformatioGainForTHL> dsthlcon = new List<InformatioGainForTHL>();
            var dsttkey = thlcha.GetAllPropertysByKey(Key);
            foreach (var item in dsttkey)
            {
                var dsthlcuacon=thlcha.GetAllTHlByValueOfKeyDicision(item);
                dsthlcon.Add(new InformatioGainForTHL(dsthlcuacon,Key));
            }
            dsthlcon.ForEach(x =>
                {
                    var coutthlcon=x.dsthl.Count;
                    var countthlcha=dsthl.Count;
                    kq += ((double)coutthlcon / (double)countthlcha) * x.DoLoiTHL();
                });
            return -Math.Round(kq, 4);
        }
        public double A()
        {
            var informationgaincha=new InformatioGainForTHL(dsthl,Key);
            return Math.Round(informationgaincha.DoLoiTHL() - E(),4);
        }
    }
}
