using test_course.Entities;

namespace test_course.ViewModels
{
    public class KhoaHocViewModel
    {
        public ICollection<KhoaHoc> KhoaHocs { get; set; }
        public ICollection<MonHoc> MonHocs { get; set; }
    }
}
