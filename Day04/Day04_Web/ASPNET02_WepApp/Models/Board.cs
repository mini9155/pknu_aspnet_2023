using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNET02_WepApp.Models
{
    public class Board
    {

        [Key] // 프라이머리 키
        public int Id { get; set; }

        [Required]
        [DisplayName("아이디")]
        public string UserId { get; set; }
        [DisplayName("이름")]

        public string UserName { get; set; }

        [Required] // not null
        [MaxLength(200)]
        [DisplayName("제목")]

        public string Title { get; set; }
        [DisplayName("조회")]


        public int ReadCount { get; set; }
        [DisplayName("작성일")]

        public DateTime PostDate { get; set; }
        [DisplayName("게시글")]

        public string Contents { get; set; }

    }
}
