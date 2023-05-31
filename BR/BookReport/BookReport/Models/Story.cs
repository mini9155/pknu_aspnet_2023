
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookReport.Models
{
    public class Story
    {
        //독후감 제목, 책 제목, 저자명, 읽은 날짜, 메인 내용

        [Key] //PK
        [Required(ErrorMessage = "제목을 입력하세요")] // Not Null
        [MaxLength(50)] // == Varchar(500)
        public string MainTitle { get; set; }


        public DateTime ReadDate { get; set; }

        [MaxLength(50)] // == Varchar(500)
        [Required(ErrorMessage = "책 제목을 입력하세요")] // Not Null
        public string BookName { get; set; }

        [MaxLength(50)] // == Varchar(500)
        public string? Author { get; set; }

        [Required(ErrorMessage = "내용을 입력하세요")] // Not Null
        [MaxLength(500)] // == Varchar(500)
        public string Body { get; set; }
    }
}