using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> 搜尋Id大於8的資料()
        {
            return Source.Where(item => item.Id > 8).ToList();
        }

        public List<Sample> 搜尋Price等於200的資料()
        {
            return Source.Where(item => item.Price == 200).ToList();
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            //return Source.Where(item => item.UserName[0] == 'd').ToList();
            return Source.Where(item => item.UserName.StartsWith("d")).ToList();
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            return Source.Where(item => item.UserName.Contains("e")).ToList();
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            //return Source.Where(item => item.UserName[item.UserName.Length-1] == 'o').ToList();
            return Source.Where(item => item.UserName.EndsWith("o")).ToList();
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            return Source.Where(item => item.UserName == "demo" || item.UserName == "joey").ToList();
        }

        public bool 判斷是否有Id等於99的資料()
        {
            return Source.Any(item => item.Id == 99);
        }
    }
}
