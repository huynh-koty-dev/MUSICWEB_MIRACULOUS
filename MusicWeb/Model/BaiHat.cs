namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHat")]
    public partial class BaiHat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiHat()
        {
            BinhLuans = new HashSet<BinhLuan>();
            NguoiDungs = new HashSet<NguoiDung>();
        }

        [Key]
        public int IdBaiHat { get; set; }

        [StringLength(255)]
        public string TenBaiHat { get; set; }

        public string AnhBaiHat { get; set; }

        public string LoiBaihat { get; set; }

        public DateTime? NgayPhatHanh { get; set; }

        public bool? Top100 { get; set; }

        public int? LuotNghe { get; set; }

        public int? LuotTai { get; set; }

        public int? LuotThich { get; set; }

        public string LinkBaiHat { get; set; }

        public int? IdNgheSi { get; set; }

        public int? IdTheLoai { get; set; }

        public int? IdAlbum { get; set; }

        public virtual Album Album { get; set; }

        public virtual NgheSi NgheSi { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
