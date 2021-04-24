namespace PG.Core.Models.SinhVienEntities
{
    using System;
    public class SinhVienEntity
    {
        public SinhVienEntity(int id)
        {
            this.Id = id;
        }

        protected SinhVienEntity() { }
        public int Id { get; set; }
        public string MaSo { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Mail { get; set; }
        public string DiDong { get; set; }
        public string Cmnd { get; set; }
        public int HocBong { get; set; }
        public int? KhoaId { get; set; }
    }
}