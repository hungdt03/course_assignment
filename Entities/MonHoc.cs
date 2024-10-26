using System.ComponentModel.DataAnnotations.Schema;

namespace test_course.Entities
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMonHoc { get; set; }
        public string? MoTa { get; set; }
        [ForeignKey(nameof(KhoaHoc))]
        public int KhoaHocID { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
    }
}
