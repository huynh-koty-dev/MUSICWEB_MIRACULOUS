namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            BaiHats = new HashSet<BaiHat>();
            NguoiDungs = new HashSet<NguoiDung>();
        }

        [Key]
        public int IdAlbum { get; set; }

        [StringLength(255)]
        public string TenAlbum { get; set; }

        public string AnhAlbum { get; set; }

        [StringLength(100)]
        public string KhuVuc { get; set; }

        [StringLength(100)]
        public string NgheSiThucHien { get; set; }

        public bool? Hot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
