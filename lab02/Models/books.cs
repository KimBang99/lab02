using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab02.Models
{
    public class books
    {
        private int id;
        private string name;
        private string author;
        private string image;
        public books()
        {

        }
        public books(int id, string name, string author, string image)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.image = image;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Tieu de khong duoc de trong")]
        [StringLength(250,ErrorMessage ="Tieu de khong duoc qua 250 ky tu")]
        [Display(Name = "Tieu de")]
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}