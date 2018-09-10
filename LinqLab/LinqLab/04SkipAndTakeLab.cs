using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> 跳過五筆資料()
        {
            return Source.Skip(5).ToList();
        }

        public List<Sample> 取得五筆資料()
        {
            return Source.Take(5).ToList();
        }

        public List<Sample> 跳過五筆取得兩筆()
        {
            return Source.Skip(5).Take(2).ToList();
        }
    }
}
