using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProdAuth.Model
{
    public class Product
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;
        [Required]
        [StringLength(100)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Required]
        public int CategoryId { get; set; }
        public Category Category {get;set;}

        private string _Description;
        [StringLength(5000)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private int _View;

        public int View
        {
            get { return _View; }
            set { _View = value; }
        }

        private string _ImgUrl;

        public string ImgUrl
        {
            get { return _ImgUrl; }
            set { _ImgUrl = value; }
        }

        private bool _Avilable;
        [Required]
        public bool Avilable
        {
            get { return _Avilable; }
            set { _Avilable = value; }
        }
    }
}
