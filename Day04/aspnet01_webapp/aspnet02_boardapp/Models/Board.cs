﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet02_boardapp.Models
{
    // 게시판을 위한 테이블 매핑 정보
    public class Board
    {
        [Key]   // PK
        public int Id { get; set; }

        [Required]  // Not Null
        [DisplayName("아이디")]
        
        public string UserId { get; set; }
        [DisplayName("이름")]

        public string? UserName { get; set; }   // ?를 붙이면 Null 허용

        [Required]  // Not Null
        [MaxLength(200)]    // Varchar(200)이랑 같음
        
        [DisplayName("제목")]
        public string Title { get; set; }
        
        [DisplayName("조회")]
        public string ReadCount { get; set; }

        [DisplayName("작성일")]
        public DateTime PostDate { get; set; }
       
        [DisplayName("내용")]
        public string Contents { get; set; }
    }
}
