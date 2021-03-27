namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NgheSi")]
    public partial class NgheSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NgheSi()
        {
            BaiHats = new HashSet<BaiHat>();
            NguoiDungs = new HashSet<NguoiDung>();
        }

        [Key]
        public int IdNgheSi { get; set; }

        [StringLength(255)]
        public string TenNgheSi { get; set; }

        [StringLength(255)]
        public string NgheDanh { get; set; }

        public string AnhNgheSi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string QuocGia { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        public int? LuotQuanTam { get; set; }

        public int? IdAlbum { get; set; }

        [StringLength(255)]
        public string CongTy { get; set; }

        public bool? Hot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
