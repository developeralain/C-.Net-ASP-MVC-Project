using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class Rental
    {
        
        public int RentalId { get; set; }        
        public string RentalName { get; set; }
        public int RentalCost { get; set; }
        public string FlawsAndDamages { get; set; }
        public bool? ChokingHazard { get; set; }
        public bool? SuffocationHazard { get; set; }
        public int? PurchasePrice { get; set; }
        
        public int? RoomNumber { get; set; }
        public int? SquareFootage { get; set; }
        public int? MaxOccupancy { get; set; }
    }