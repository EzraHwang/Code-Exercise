using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample 搜尋UserName等於demo的資料使用First()
        {
            return Source.First(f => f.UserName == "demo");
        }

        public Sample 搜尋UserName等於skilltree的資料使用FirstOrDefault()
        {
            return Source.FirstOrDefault(fd => fd.UserName == "skilltree");
        }

        public Sample 搜尋UserName等於skilltree的資料使用First()
        {
            return Source.First(f => f.UserName == "skilltree");
        }

        public Sample 搜尋UserName等於demo的資料使用Single()
        {
            return Source.Single(s => s.UserName == "demo");
        }

        public Sample 搜尋UserName等於bill的資料使用Single()
        {
            return Source.Single(s => s.UserName == "bill");
        }
        public Sample 搜尋UserName等於bill的資料使用SingleOrDefault()
        {
            return Source.SingleOrDefault(sd => sd.UserName == "bill");
        }

        public Sample 搜尋UserName等於skilltree的資料使用SingleOrDefault()
        {
            return Source.SingleOrDefault(sd => sd.UserName == "skilltree");
        }
    }
}
