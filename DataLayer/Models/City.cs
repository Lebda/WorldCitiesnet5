﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.DataLayer.Models
{
    [Table("City")]
    public class City
    {
        #region Constructor
        public City()
        {
        }
        #endregion
        #region Properties
        /// <summary>
        /// The unique id and primary key for this City
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// City name (in UTF8 format)
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// City name (in ASCII format)
        /// </summary>
        [StringLength(150)]
        public string Name_ASCII { get; set; }
        /// <summary>
        /// City latitude
        /// </summary>
        public decimal Lat { get; set; }
        /// <summary>
        /// City longitude
        /// </summary>
        public decimal Lon { get; set; }
        #endregion
        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        /// <summary>
        /// The country related to this city.
        /// </summary>
        public virtual Country Country { get; set; }
    }
}