namespace Buoi_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Điền tiêu đề vào nào !!")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Điền chủ đề của sách đi!!!")]
        [StringLength(255)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Sách này của tác giả nào ???")]
        [StringLength(255)]
        public string Author { get; set; }
        [Required(ErrorMessage = "Bạn hãy thêm ảnh của sách")]
        [StringLength(255)]
        public string Images { get; set; }
        [Range(1000,1000000,ErrorMessage ="Giá chỉ được từ 1000 đến 1000000")]
        public double? Price { get; set; }
    }
}
