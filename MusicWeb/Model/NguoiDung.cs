namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            BinhLuans = new HashSet<BinhLuan>();
        }

        [Key]
        public int IdNguoiDung { get; set; }

        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(255)]
        public string TenNguoiDung { get; set; }

        public string AnhDaiDien { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? IdBaiHat { get; set; }

        public int? IdAlbum { get; set; }

        public int? IdNgheSi { get; set; }

        public int? IdKhuVuc { get; set; }

        public virtual Album Album { get; set; }

        public virtual BaiHat BaiHat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        public virtual KhuVuc KhuVuc { get; set; }

        public virtual NgheSi NgheSi { get; set; }
    }
}
